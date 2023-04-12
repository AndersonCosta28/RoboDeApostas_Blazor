using System.Text.RegularExpressions;

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
        //ListaDeLinkDasLigas[Ligas.Internacional_LigaDosCampeoes] = "https://sportsbet.io/pt/sports/soccer/international-clubs/uefa-champions-league/matches";
        //ListaDeLinkDasLigas[Ligas.Internacional_Libertadores] = "https://sportsbet.io/pt/sports/soccer/international-clubs/copa-libertadores/matches";
        //ListaDeLinkDasLigas[Ligas.Inglaterra_PremierLeague] = "https://sportsbet.io/pt/sports/soccer/england/premier-league/matches";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga] = "https://sportsbet.io/pt/sports/soccer/spain/la-liga/matches";
        //ListaDeLinkDasLigas[Ligas.Alemanha_Bundesliga] = "https://sportsbet.io/pt/sports/soccer/germany/bundesliga/matches";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieA] = "https://sportsbet.io/pt/sports/soccer/italy/serie-a/matches";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue1] = "https://sportsbet.io/pt/sports/soccer/france/ligue-1/matches";
        //ListaDeLinkDasLigas[Ligas.Colombia_Primera_A] = "https://sportsbet.io/pt/sports/soccer/colombia/primera-a-apertura/matches";
        //ListaDeLinkDasLigas[Ligas.Mexico_MX] = "https://sportsbet.io/pt/sports/soccer/mexico/matches/future";
        //ListaDeLinkDasLigas[Ligas.EUA_MajorLeagueSoccer] = "https://sportsbet.io/pt/sports/soccer/usa/matches/future";
        //ListaDeLinkDasLigas[Ligas.Internacional_SulAmericana] = "https://sportsbet.io/pt/sports/soccer/international-clubs/copa-sudamericana/matches";
        //ListaDeLinkDasLigas[Ligas.Alemanha_DFBPokal] = "https://sportsbet.io/pt/sports/soccer/germany/dfb-pokal/matches";
        //ListaDeLinkDasLigas[Ligas.Espanha_CopaDelRey] = "https://sportsbet.io/pt/sports/soccer/spain/matches/future";
        //ListaDeLinkDasLigas[Ligas.Italia_CoppaItalia] = "https://sportsbet.io/pt/sports/soccer/italy/coppa-italia/matches";
        //ListaDeLinkDasLigas[Ligas.Portugal_PrimeiraLiga] = "https://sportsbet.io/pt/sports/soccer/portugal/primeira-liga/matches";
        //ListaDeLinkDasLigas[Ligas.Holanda_Eredivisie] = "https://sportsbet.io/pt/sports/soccer/netherlands/eredivisie/matches";
        //ListaDeLinkDasLigas[Ligas.Portugal_SegundaLiga] = "https://sportsbet.io/pt/sports/soccer/portugal/segunda-liga/matches";
        //ListaDeLinkDasLigas[Ligas.Alemanha_2Bundesliga] = "https://sportsbet.io/pt/sports/soccer/germany/2nd-bundesliga/matches";
        //ListaDeLinkDasLigas[Ligas.Alemanha_3Liga] = "https://sportsbet.io/pt/sports/soccer/germany/3rd-liga/matches";
        //ListaDeLinkDasLigas[Ligas.Holanda_EersteDivisie] = "https://sportsbet.io/pt/sports/soccer/netherlands/eerste-divisie/matches";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieB] = "https://sportsbet.io/pt/sports/soccer/italy/serie-b/matches";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieC] = "https://sportsbet.io/pt/sports/soccer/italy/serie-c/matches";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieD] = "https://sportsbet.io/pt/sports/soccer/italy/serie-d/matches";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraDivison] = "https://sportsbet.io/pt/sports/soccer/argentina/superliga/matches";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraNacional] = "https://sportsbet.io/pt/sports/soccer/argentina/primera-nacional/matches";
        //ListaDeLinkDasLigas[Ligas.Franca_CoupeDeFrance] = "https://sportsbet.io/pt/sports/soccer/france/coupe-de-france/matches";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue2] = "https://sportsbet.io/pt/sports/soccer/france/ligue-2/matches";
        //ListaDeLinkDasLigas[Ligas.Franca_National] = "https://sportsbet.io/pt/sports/soccer/france/national/matches";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga2] = "https://sportsbet.io/pt/sports/soccer/spain/la-liga-2/matches";
        //ListaDeLinkDasLigas[Ligas.Australia_ALeague] = "https://sportsbet.io/pt/sports/soccer/australia/a-league/matches";
        //ListaDeLinkDasLigas[Ligas.Australia_NplNSW] = "https://sportsbet.io/pt/sports/soccer/australia/npl-new-south-wales/matches";
        //ListaDeLinkDasLigas[Ligas.Australia_NplQueensland] = "https://sportsbet.io/pt/sports/soccer/australia/npl-queensland/matches";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria] = "https://sportsbet.io/pt/sports/soccer/australia/npl-victoria/matches";
        //ListaDeLinkDasLigas[Ligas.Australia_WesternPremierLeague] = "https://sportsbet.io/pt/sports/soccer/australia/npl-western-australia/matches";
        //ListaDeLinkDasLigas[Ligas.Australia_SouthPremierLeague] = "https://sportsbet.io/pt/sports/soccer/australia/npl-south-australia/matches";
        //ListaDeLinkDasLigas[Ligas.Australia_NorthernNswPremierLeague] = "https://sportsbet.io/pt/sports/soccer/australia/npl-northern-new-south/matches";
        //ListaDeLinkDasLigas[Ligas.Brasil_Brasileirao_Sub20] = "https://sportsbet.io/pt/sports/soccer/brazil/u-20-campeonato-brasileiro/matches";
        //ListaDeLinkDasLigas[Ligas.Internacional_AmistososFeminino] = "https://sportsbet.io/pt/sports/soccer/international/national-friendlies-women/matches";

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
        // this.ValoresParaInjetarNaPagina.Add("cache-control", "max-age=0");
        // this.ValoresParaInjetarNaPagina.Add(":authority", this.NomeDoSite.ToLower());
        // this.ValoresParaInjetarNaPagina.Add(":scheme", "https");
    }
}