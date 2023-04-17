using System.Text.RegularExpressions;
using RoboDeApostas.Models.CasasDeAposta.SportsbetioAPI.DetalheDaPartida;
using RoboDeApostas.Models.CasasDeAposta.SportsbetioAPI.ListaDePartida;

namespace RoboDeApostas.Models.CasasDeAposta;
class Sportsbet_IO : CasaDeAposta
{
    public override async Task AtribuirDataDosJogosAsync(Partida partida)
    {
        string seletor = ".sr-lmt-plus-scb__status.srt-text-secondary.srt-neutral-9 div";
        byte hora = 0;
        byte minuto = 0;
        byte dia;
        byte mes;
        try
        {
            await Pagina.WaitForSelectorAsync(seletor, new());
            var r = await Pagina.Locator(seletor).AllInnerTextsAsync();
            string[] data = r[0].Split(" ");
            dia = byte.Parse(data[0]);
            mes = Dicionarios.Meses[data[1].ToLower()];
            string[] horarioDoJogo = r[2].Split(":");
            hora = byte.Parse(horarioDoJogo[0]);
            minuto = byte.Parse(horarioDoJogo[1]);
        }
        catch (Exception)
        {
            string r = await Pagina.Locator(".BasicScoreboard__StyledBasicSportsMatchInfo-sc-pv94f8-1.byYQaP > p").InnerTextAsync();
            dia = byte.Parse(r.Split(" ")[0]);
            mes = Dicionarios.Meses[r.Split(" ")[1][..3].ToLower()];
        }
        partida.DataCompleta = new DateTime(DateTime.Now.Year, mes, dia, hora, minuto, 0);
    }

    protected override async Task<bool> ValidarCardAsync(ILocator cardDoJogo)
    {
        if (await cardDoJogo.Locator("svg.sc-fEyLLm").CountAsync() > 0)
            return false;
        return await base.ValidarCardAsync(cardDoJogo);
    }

    protected override async Task AtribuirNomeDosTimesAsync(Partida jogo)
    {
        string tituloDaPagina = await Pagina.TitleAsync();
        Regex regex = new(@"(?<=Odds de aposta do )(.*?)(?= - Sportsbet.io)");
        MatchCollection resultado = regex.Matches(tituloDaPagina);
        string[] nomeDosTimes = resultado[0].Value.Split(" - ");
        jogo.NomeTimeDaCasa = nomeDosTimes[0];
        jogo.NomeTimeVisitante = nomeDosTimes[1];
    }

    protected override void Configurar()
    {
        NomeDoSite = "Sportsbet.io";
        Link_PaginaInicial = "https://sportsbet.io";
        Seletor_Tabela = ".StyledContentWrappers__StyledRenderScreen-sc-maqa94-2.CNPrz.large > div:nth-child(4)";
        Seletor_CardDeJogos = ".grid__EventListBodyWrapper-sc-l1d0h4-0.evtRDd";
        Seletor_ODDS = ".FormattedOdds__OddsWrapper-sc-dio9ku-0.dBomYP";
        Seletor_OpcoesDeAposta = ".MarketGroup__StyledMarketEventsContainer-sc-1eqfpkd-0.kYsGhH";
        Seletor_TituloDaOpcaoDeAposta = ".MarketGroup__StyledMarketTitle-sc-1eqfpkd-3.dmJViX";
        Titulo_ChanceDupla.Add("Hipótese dupla");
        Titulo_ResultadoFinal.Add("1x2");
        Seletor_AoVivo = ".sc-fCJrvB.EuropeanEventInfo__StreamAvailableIcon-sc-1bgjk1r-3.gWaKcu";
        Seletor_LinkDaPartida = "div.sc-dJjYzT.ibZrSG > p:nth-child(1) > a";
        indice_VitoriaEmpateTimeVisitante = 2;
        InjetarValoresNaPagina = false;
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

    protected override async Task PreencherListaDePartidas(string link)
    {
        List<Task> tasks = new()
        {
            Task.Run(async () =>
        {
            await Pagina.GotoAsync(link, new PageGotoOptions() { Timeout = 0 });
        }),
            Task.Run(async () =>
            {
                var response = await this.Esperar3VezesPeloResponse((r) => r.Url.Contains("https://sportsbet.io/graphql") && r.Request.Method == "POST" && r.Request.PostData.Contains("tournamentId"));
                var json = await response.TextAsync();
                var data = ResponseListaDePartida.FromJson(json);
                var events = data.Data.SportsbetNewGraphql.GetTournamentById.Events;
                foreach (var _event in events)
                {
                    string link = $"{this.Link_PaginaInicial}/pt/sports/event/{_event.Sport.Slug}/{_event.League.Slug}/{_event.Tournament.Slug}/{_event.Slug}";
                    Partida partida = new(link, this.LigaEmExecucao, this.NomeDoSite) {
                        NomeTimeDaCasa = _event.Competitors.ToList().Find(m => m.Type == "home").Name,
                        NomeTimeVisitante = _event.Competitors.ToList().Find(m => m.Type == "away").Name,
                        DataCompleta = Funcoes.ConverterFusoHorario(DateTimeOffset.FromUnixTimeSeconds((long)_event.StartTime!))
                    };
                    this.ListaDePartidas.Add(partida);
                }
            })
        };
        await Task.WhenAll(tasks);
    }

    protected override async Task PreencherDetalhesDaPartida_RequestAsync(Partida partida)
    {
        List<Task> tasks = new()
        {
            Task.Run(async () =>
            {
                await this.Pagina.GotoAsync(partida.LinkDaPartida, new PageGotoOptions() { Timeout = 0 });
            }),
            Task.Run(async () =>
            {
                var response = await this.Esperar3VezesPeloResponse((r) => r.Url.Contains("https://sportsbet.io/graphql") && r.Request.Method == "POST" && r.Request.PostData.Contains("MainMarketsQuery"), 2, 2);

                string json = await response.TextAsync();
                string regex1 = (@"{(!|\$)(.*?)}|({from})|({to}|{hcp})");
                string regex2 = ("\"{");
                string regex3 = ("}\"");
                string regex4 = (@"\\");
                string regex5 = @",\""specifiers\"":\""(\{.*?\})\""";
                json = Regex.Replace(json, regex1, "");
                json = Regex.Replace(json, regex5, "");
                json = Regex.Replace(json, regex2, "");
                json = Regex.Replace(json, regex3, "");
                json = Regex.Replace(json, regex4, "");


                var data = ResponseDetalheDaPartida.FromJson(json).Data.SportsbetNewGraphql.GetEventById;
                double RetornarOdd(List<string> titulos, string textoParaPesquisa){
                    MainMarket? opcaoDeAposta = data.MainMarkets.ToList().Find(m => titulos.Contains(m.Name));
                    if (opcaoDeAposta == null) return 0;
                    List<SportsbetioAPI.DetalheDaPartida.Selection> selections = opcaoDeAposta.Selections.ToList();
                    SportsbetioAPI.DetalheDaPartida.Selection? selection = selections.Find(s => s.Name.Contains(textoParaPesquisa));
                    if (selection == null) return 0;
                    else return selection.Odds ?? 0;
                }

                partida.ODD_Vitoria_TimeDaCasa = RetornarOdd(this.Titulo_ResultadoFinal, partida.NomeTimeDaCasa);
                partida.ODD_Empate_Ambos = RetornarOdd(this.Titulo_ResultadoFinal, "Empate");
                partida.ODD_Vitoria_TimeVisitante = RetornarOdd(this.Titulo_ResultadoFinal, partida.NomeTimeVisitante);
                partida.ODD_VitoriaOuEmpate_TimeCasa = RetornarOdd(this.Titulo_ChanceDupla, $"{partida.NomeTimeDaCasa} ou empate");
                partida.ODD_VitoriaOuEmpate_TimeVisitante = RetornarOdd(this.Titulo_ChanceDupla, $"Empate ou {partida.NomeTimeVisitante}");
            })
        };
        await Task.WhenAll(tasks);
    }
}