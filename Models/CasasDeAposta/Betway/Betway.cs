using RoboDeApostas.Models.CasasDeAposta.BetwayAPI.DetalheDaPartida;
using RoboDeApostas.Models.CasasDeAposta.BetwayAPI.ListaDePartida;
using RoboDeApostas.Utils;
using System.Net.Http.Headers;
using System.Text;

namespace RoboDeApostas.Models.CasasDeAposta;

class Betway : CasaDeAposta
{
    protected override async Task AtribuirNomeDosTimesAsync(Partida jogo)
    {
        var nomeDosTimes = await Pagina.Locator(Seletor_NomeDosTimes).InnerTextAsync();
        jogo.NomeTimeDaCasa = nomeDosTimes.Split("-")[0].Trim();
        jogo.NomeTimeVisitante = nomeDosTimes.Split("-")[1].Trim();
    }
    protected override async Task<bool> ValidarCardAsync(ILocator cardDoJogo)
    {
        var odds = await cardDoJogo.Locator("div.odds").CountAsync();
        if (odds == 0) return false;
        return await base.ValidarCardAsync(cardDoJogo);
    }
    public override async Task AtribuirDataDosJogosAsync(Partida partida)
    {
        int numeroDeTentativas = 3;
        string seletor_frame = "iframe[name^=\"gizmo\"]",
                seletor_primario = ".sr-lmt-plus-scb__status.srt-text-secondary.srt-neutral-9 div", // Este está dentro do frame
                seletor_secundario = ".rotatorTextComponent.eventTime.transitionRotatorText"; // Este está fora do frame        
        while (true)
            try
            {
                byte dia;
                byte mes;
                string horario;
                byte hora;
                byte minuto;
                int ano = DateTime.Now.Year;
                //await Pagina.WaitForLoadStateAsync(LoadState.NetworkIdle);
                if (await Pagina.Locator(seletor_secundario).CountAsync() > 0)
                {
                    // Formato desse texto normalmente vem assim -> O evento começa às 10:30, 08/04/2023
                    var texto = await Pagina.Locator(seletor_secundario).InnerTextAsync();
                    string dataCompleta = texto.Split("O evento começa às ")[1];
                    string[] data = texto.Split(", ")[1].Split("/");
                    horario = texto.Split(", ")[0].Split("O evento começa às ")[1];
                    dia = byte.Parse(data[0]);
                    mes = byte.Parse(data[1]);
                    hora = byte.Parse(horario.Split(":")[0]);
                    minuto = byte.Parse(horario.Split(":")[1]);
                }
                else
                {
                    IFrameLocator frame = Pagina.FrameLocator(seletor_frame);
                    var texto = await frame.Locator(seletor_primario).AllTextContentsAsync();
                    string data = texto[0];
                    dia = byte.Parse(data!.Split(" ")[0]);
                    mes = Dicionarios.Meses[data!.Split(" ")[1].ToLower()];
                    horario = texto[2];
                    hora = byte.Parse(horario.Split(":")[0]);
                    minuto = byte.Parse(horario.Split(":")[1]);
                }
                partida.DataCompleta = new DateTime(ano, mes, dia, hora, minuto, 0);
                return;
            }
            catch (Exception e)
            {
                if (numeroDeTentativas <= 0)
                {
                    //throw new Exception("Lançando excessão de Betway.CapturarDataDosJogos \n" + e.Message);
                    SalvarLog($"Não conseguiu capturar a data deste link -> {Pagina.Url} \n{e.Message} \n {e.StackTrace}");
                    partida.DataCompleta = new DateTime();
                }
                SalvarLog($"Executou a tentiva {numeroDeTentativas} neste link -> {Pagina.Url}");
                numeroDeTentativas--;
                await Pagina.WaitForTimeoutAsync(2000);
            }
    }
    protected override void Configurar()
    {
        NomeDoSite = "Betway";
        Link_PaginaInicial = "https://betway.com";
        Seletor_Tabela = ".eventTableItemCollection";
        Seletor_CardDeJogos = ".eventHolder";
        Seletor_NomeDosTimes = "h1.title";
        Seletor_ODDS = "div.odds";
        Seletor_LinkDaPartida = "a.scoreboardInfoNames";
        Seletor_OpcoesDeAposta = ".collapsablePanel:has(div.collapsableHeader > div.marketTitleWrapper > div.titleText > span)";
        Seletor_TituloDaOpcaoDeAposta = "div.collapsableHeader > div.marketTitleWrapper > div.titleText > span";
        Titulo_ChanceDupla.Add("Chance Dupla");
        Titulo_ResultadoFinal.Add("Vitória/Empate/Vitória");
        Link_PaginaDeLogin = "https://betway.com/pt/sports";
        Seletor_Formulario_De_Login = "form.loginForm";
        Seletor_Input_Usuario = "div.inputContainer.usernameInput input";
        Seletor_Input_Senha = "div.inputContainer.passwordInput input";
        Seletor_Botao_Entrar = "input.loginSubmit";
        Seletor_AoVivo = "div.oneLineScoreboard.live";
        segundosParaAguardarAposEntrarNaPaginaDaLiga = 5;
    }

    protected override async Task PreencherListaDePartidas(string link)
    {
        List<Task> tasks = new()
        {
            Task.Run(async () => await Pagina.GotoAsync(link, new() { Timeout = 0 })),
            Task.Run(async () =>
            {
                try
                {
                    var resposta = await this.Esperar3VezesPeloResponse(r => r.Url.Contains("https://betway.com/api/Events/v2/GetEvents"),2,2);
                    string json = await resposta.TextAsync();
                    var data = ResponseListaDePartida.FromJson(json);
                    foreach (var item in data.Events)
                    {
                        if ((bool)item.IsLive! || item.Markets.Count == 0) continue;
                        Partida partida = new($"{Link_PaginaInicial}/pt/sports/evt/{item.Id}", LigaEmExecucao, NomeDoSite);
                        string[] dataCompleta = item.Date.Split('/');
                        string[] horario = item.Time.Split(":");
                        byte dia = byte.Parse(dataCompleta[1]), mes = byte.Parse(dataCompleta[0]);
                        int ano = int.Parse(dataCompleta[2]);
                        byte hora = byte.Parse(horario[0]), minuto = byte.Parse(horario[1]);
                        partida.DataCompleta = Funcoes.ConverterFusoHorario(new(ano, mes, dia, hora, minuto, 0, TimeSpan.Zero));
                        partida.NomeTimeDaCasa = item.HomeTeamName;
                        partida.NomeTimeVisitante = item.AwayTeamName;
                        this.ListaDePartidas.Add(partida);
                    }
                }
                catch(Exception){ throw; }
            })
        };
        await Task.WhenAll(tasks);
    }

    protected override async Task PreencherDetalhesDaPartida_RequestAsync(Partida partida)
    {
        List<Task> tasks = new()
        {
            Task.Run(async () => await Pagina.GotoAsync(partida.LinkDaPartida, new() { Timeout = 0 })),
            Task.Run(async () =>
            {
                try
                {
                    var resposta = await this.Esperar3VezesPeloResponse(r => r.Url.Contains("https://betway.com/api/Events/v2/GetEventDetails"), 2, 2);
                    string json = await resposta.TextAsync();
                    var data = ResponseDetalheDaPartida.FromJson(json);

                    partida.ODD_Vitoria_TimeDaCasa = data.Outcomes.Find(o => o.Id == data.Markets.Find(m => Titulo_ResultadoFinal.Contains(m.Title)).Outcomes[0][0]).OddsDecimal! ?? 0;
                    partida.ODD_Empate_Ambos = data.Outcomes.Find(o => o.Id == data.Markets.Find(m => Titulo_ResultadoFinal.Contains(m.Title)).Outcomes[0][1]).OddsDecimal! ?? 0;
                    partida.ODD_Vitoria_TimeVisitante = data.Outcomes.Find(o => o.Id == data.Markets.Find(m => Titulo_ResultadoFinal.Contains(m.Title)).Outcomes[0][2]).OddsDecimal ?? 0;

                    if (data.Markets.Find(m => Titulo_ChanceDupla.Contains(m.Title)) == null || data.Markets.Find(m => Titulo_ChanceDupla.Contains(m.Title)) == null ) return;
                    partida.ODD_VitoriaOuEmpate_TimeCasa = data.Outcomes.Find(o => o.Id == data.Markets.Find(m => Titulo_ChanceDupla.Contains(m.Title)).Outcomes[0][indice_VitoriaEmpateTimeDaCasa]).OddsDecimal ?? 0;
                    partida.ODD_VitoriaOuEmpate_TimeVisitante = data.Outcomes.Find(o => o.Id == data.Markets.Find(m => Titulo_ChanceDupla.Contains(m.Title)).Outcomes[0][indice_VitoriaEmpateTimeVisitante]).OddsDecimal ?? 0;
                }
                catch (Exception) { throw; }
            })
        };
        await Task.WhenAll(tasks);
    }

    public override async Task RodarPadraoAsync(string link)
    {
        var playwright = await Playwright.CreateAsync();
        Navegador = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions() { Headless = !AbrirNavegador, Devtools = false });
        Pagina = await Navegador.NewPageAsync(new BrowserNewPageOptions() { ExtraHTTPHeaders = ValoresParaInjetarNaPagina });
        try
        {
            SalvarLog($"Executando Robo em {NomeDoSite} e na liga {LigaEmExecucao}");
            await PreencherListaDePartidas(link);
            foreach (Partida partida in ListaDePartidas)
            {
                await PreencherDetalhesDaPartida_RequestAsync(partida);
                await SalvarPartidaNoBanco(partida);
            }
        }
        catch (Exception ex)
        {
            SalvarLog($"Lançou erro no link: ${link} \n {ex.Message} \n {ex.InnerException.Message}");
        }
        finally
        {
            await Pagina.CloseAsync();
            await Navegador.CloseAsync();
            ListaDePartidas.Clear();
        }
    }
}
