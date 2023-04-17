using RoboDeApostas.Models.CasasDeAposta.SportingBetAPI.ListaDePartida;

namespace RoboDeApostas.Models.CasasDeAposta;
class SportingBet : CasaDeAposta
{
    public override async Task AtribuirDataDosJogosAsync(Partida partida)
    {
        DateTime dataAtual = DateTime.Now;
        string? seletor_data = await Pagina.Locator("div.event-time > span.date").TextContentAsync();
        string? seletor_hora = await Pagina.Locator("div.event-time > span.time").TextContentAsync();
        int dia, mes, ano, hora, minuto;

        if (seletor_data == "Hoje")
        {
            dia = dataAtual.Day;
            mes = dataAtual.Month;
            ano = dataAtual.Year;
        }
        else if (seletor_data == "Amanhã")
        {
            dia = dataAtual.AddDays(1).Day;
            mes = dataAtual.Month;
            ano = dataAtual.Year;
        }
        else
        {
            string[] _data = seletor_data!.Split("/");
            dia = int.Parse(_data[0]);
            mes = int.Parse(_data[1]);
            ano = int.Parse(_data[2]);
        }

        string[] horario = seletor_hora!.Split(":");
        hora = int.Parse(horario[0]);
        minuto = int.Parse(horario[1]);

        partida.DataCompleta = new DateTime(ano, mes, dia, hora, minuto, 0);
    }

    protected override async Task AtribuirNomeDosTimesAsync(Partida jogo)
    {
        // await Pagina.WaitForSelectorAsync(Seletor_NomeDosTimes);
        // await this.Esperar3Vezes_Seletor(Pagina, Seletor_NomeDosTimes);
        var nomeDosTimes = await Pagina.Locator(Seletor_NomeDosTimes).AllInnerTextsAsync();
        jogo.NomeTimeDaCasa = nomeDosTimes[0];
        jogo.NomeTimeVisitante = nomeDosTimes[1];
    }

    protected override void Configurar()
    {
        NomeDoSite = "Sporting Bet";
        Link_PaginaInicial = "https://sports.sportingbet.com";
        Seletor_Tabela = "ms-grid.grid.grid-live-favourite";
        Seletor_CardDeJogos = ".grid-event-wrapper.ng-star-inserted";
        Seletor_NomeDosTimes = ".participant-name-value";
        Seletor_ODDS = "div.value.option-value.ng-star-inserted";
        Seletor_LinkDaPartida = "a.grid-info-wrapper.fixed";
        Seletor_OpcoesDeAposta = "ms-option-panel.option-panel.ng-star-inserted";
        Seletor_TituloDaOpcaoDeAposta = "div.option-group-name-info-name.ng-star-inserted";
        Titulo_ChanceDupla.Add("Chance Dupla");
        Titulo_ResultadoFinal.AddRange(new string[] { "Resultado da Partida", "Match Result" });
        indice_VitoriaEmpateTimeVisitante = 1;
        Seletor_AoVivo = "i.live-icon.ng-star-inserted";
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
                await SalvarPartidaNoBanco(partida);

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

    protected override async Task PreencherListaDePartidas(string link)
    {
        List<Task> tasks = new()
        {
            Task.Run(async () => await Pagina.GotoAsync(link, new() { Timeout = 0 })),

            Task.Run(async () =>
            {
                try
                {
                    var response = await this.Esperar3VezesPeloResponse(r => r.Url.Contains("widget"));
                    var json = await response.TextAsync();
                    var data = ResponseListaDePartida.FromJson(json);
                    var widget = data.Widgets.Find(i => i.Type == "Composable");
                    if (widget == null) return;
                    var tc = widget.Payload.Items[0].ActiveChildren[0].Payload.Fixtures;
                    foreach (var item in tc)
                    {
                        double RetornarOdd(List<string> titulos, int indice){
                            OptionMarket? opcaoDeAposta = item.OptionMarkets.ToList().Find(o => titulos.Contains(o.Name.Value));
                            return opcaoDeAposta != null ? opcaoDeAposta.Options[indice].Price.Odds ?? 0 : 0;
                        }
                        Partida partida = new()
                        {
                            NomeTimeDaCasa = item.Participants.Find(p => p.Properties.Type == "HomeTeam").Name.Value,
                            NomeTimeVisitante = item.Participants.Find(p => p.Properties.Type == "AwayTeam").Name.Value,
                            DataCompleta = Funcoes.ConverterFusoHorario((DateTimeOffset)item.StartDate!),
                            ODD_Vitoria_TimeDaCasa = RetornarOdd(this.Titulo_ResultadoFinal, 0),
                            ODD_Empate_Ambos = RetornarOdd(this.Titulo_ResultadoFinal, 1),
                            ODD_Vitoria_TimeVisitante = RetornarOdd(this.Titulo_ResultadoFinal, 2),
                            ODD_VitoriaOuEmpate_TimeCasa = RetornarOdd(this.Titulo_ChanceDupla, indice_VitoriaEmpateTimeDaCasa),
                            ODD_VitoriaOuEmpate_TimeVisitante = RetornarOdd(this.Titulo_ChanceDupla, indice_VitoriaEmpateTimeVisitante),
                            LinkDaPartida = $"{Link_PaginaInicial}/pt-br/sports/eventos/{item.Participants.Find(p => p.Properties.Type == "HomeTeam").Name.Value}-{item.Participants.Find(p => p.Properties.Type == "AwayTeam").Name.Value}-{item.Id}",
                            Liga = LigaEmExecucao,
                            NomeDaCasaDeAposta = NomeDoSite
                        };
                        if (partida.DataCompleta < DateTimeOffset.Now) continue;
                        this.ListaDePartidas.Add(partida);
                    }
                }
                catch(Exception){ throw; }
            })
        };

        await Task.WhenAll(tasks);
    }
}