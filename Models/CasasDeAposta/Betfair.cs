namespace RoboDeApostas.Models.CasasDeAposta;

class Betfair : CasaDeAposta
{
    public override async Task AtribuirDataDosJogosAsync(Partida partida)
    {
        var valor = await page.Locator("#mod-matchheader-1001 .ui-countdown").TextContentAsync();
        DateTime novaData;
        List<string> valorArray = valor!.Trim().Split("\n").ToList();
        if (valor.Contains("KO"))
        {
            string[] horario = valorArray[1].Split(":");
            byte hora = byte.Parse(horario[0]);
            byte minuto = byte.Parse(horario[1]);
            novaData = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hora, minuto, 0);
        }
        else
        {
            var data = valorArray[0].Split(" ").ToList();
            data.RemoveAt(0); // Dia da semana
            byte dia = byte.Parse(data[0]);
            byte mes = Dicionarios.Meses[data[1][..3].ToLower()];
            string[] horario = valorArray[1].Split(":");
            byte hora = byte.Parse(horario[0]);
            byte minuto = byte.Parse(horario[1]);
            novaData = new DateTime(DateTime.Now.Year, mes, dia, hora, minuto, 0);
        }
        partida.DataCompleta = novaData;
    }

    protected override async Task AtribuirNomeDosTimesAsync(Partida jogo)
    {
        string timeDaCasa = "td.home-runner",
               timeVisitante = "td.away-runner";

        // await this.Esperar3Vezes_Seletor(page, timeDaCasa);
        // await this.Esperar3Vezes_Seletor(page, timeVisitante);
        jogo.NomeTimeDaCasa = await page.Locator(timeDaCasa).InnerTextAsync();
        jogo.NomeTimeVisitante = await page.Locator(timeVisitante).InnerTextAsync();
    }

    protected override async Task<bool> JogoJaComecouAsync(ILocator cardDoJogo)
    {
        var texto = cardDoJogo.Locator("span.date.ui-countdown");
        if (texto == null || await texto.CountAsync() == 0) return true;

        string texto2 = await texto.InnerTextAsync();
        return texto2.Contains("Ao vivo");
    }

    protected override void Configurar()
    {
        NomeDoSite = "Betfair";
        Link_PaginaInicial = "https://www.betfair.com";
        //ListaDeLinkDasLigas[Ligas.Internacional_LigaDosCampeoes] = "https://www.betfair.com/sport/football/uefa-champions-league/228";
        //ListaDeLinkDasLigas[Ligas.Inglaterra_PremierLeague] = "https://www.betfair.com/sport/football/inglaterra-premier-league/10932509";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga] = "https://www.betfair.com/sport/football/espanha-la-liga/117";
        //ListaDeLinkDasLigas[Ligas.Alemanha_Bundesliga] = "https://www.betfair.com/sport/football/bundesliga-alem%C3%A3/59";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieA] = "https://www.betfair.com/sport/football/it%C3%A1lia-s%C3%A9rie-a/81";
        //ListaDeLinkDasLigas[Ligas.Brasil_LigaBrasileiraPaulista] = "https://www.betfair.com/sport/football/brasil-paulista-serie-a1/2490975";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue1] = "https://www.betfair.com/sport/football/fran%C3%A7a-ligue-1/55";
        //ListaDeLinkDasLigas[Ligas.Holanda_Eredivisie] = "https://www.betfair.com/sport/football/holanda-eredivisie/9404054";
        //ListaDeLinkDasLigas[Ligas.Internacional_AmistososInternacionais] = "https://www.betfair.com/sport/football/amistosos-internacionais/12205166";
        //ListaDeLinkDasLigas[Ligas.Colombia_Primera_A] = "https://www.betfair.com/sport/football/colombian-primera-a/844197";
        //ListaDeLinkDasLigas[Ligas.Mexico_MX] = "https://www.betfair.com/sport/football/mexican-liga-mx/5627174";
        //ListaDeLinkDasLigas[Ligas.EUA_MajorLeagueSoccer] = "https://www.betfair.com/sport/football/eua-mls/141";
        //ListaDeLinkDasLigas[Ligas.Internacional_Libertadores] = "https://www.betfair.com/sport/football/conmebol-copa-libertadores/12147796";
        //ListaDeLinkDasLigas[Ligas.Internacional_SulAmericana] = "https://www.betfair.com/sport/football/conmebol-copa-sul-americana/12204604";
        //ListaDeLinkDasLigas[Ligas.Alemanha_DFBPokal] = "https://www.betfair.com/sport/football/copa-da-alemanha/11458113";
        //ListaDeLinkDasLigas[Ligas.Espanha_CopaDelRey] = "https://www.betfair.com/sport/football/espanha-copa-do-rei/12801";
        //ListaDeLinkDasLigas[Ligas.Italia_CoppaItalia] = "https://www.betfair.com/sport/football/copa-da-it%C3%A1lia/12214429";
        //ListaDeLinkDasLigas[Ligas.Portugal_PrimeiraLiga] = "https://www.betfair.com/sport/football/portugal-primeira-liga/99";
        //ListaDeLinkDasLigas[Ligas.Portugal_SegundaLiga] = "https://www.betfair.com/sport/football/portuguese-segunda-liga/9513";
        //ListaDeLinkDasLigas[Ligas.Alemanha_2Bundesliga] = "https://www.betfair.com/sport/football/alemanha-bundesliga-2/61";
        //ListaDeLinkDasLigas[Ligas.Alemanha_3Liga] = "https://www.betfair.com/sport/football/alemanha-3-liga/11591693";
        //ListaDeLinkDasLigas[Ligas.Holanda_EersteDivisie] = "https://www.betfair.com/sport/football/holanda-eerste-divisie/11";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieB] = "https://www.betfair.com/sport/football/it%C3%A1lia-s%C3%A9rie-b/12199689";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieC] = "https://www.betfair.com/sport/football/it%C3%A1lia-s%C3%A9rie-c/12199513";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieD] = "https://www.betfair.com/sport/football/it%C3%A1lia-serie-d/7210007";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraDivison] = "https://www.betfair.com/sport/football/primera-division-da-argentina/67387";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraNacional] = "https://www.betfair.com/sport/football/divis%C3%A3o-2-da-argentina/803237";
        //ListaDeLinkDasLigas[Ligas.Franca_CoupeDeFrance] = "https://www.betfair.com/sport/football/copa-da-fran%C3%A7a/12209560";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue2] = "https://www.betfair.com/sport/football/fran%C3%A7a-ligue-2/57";
        //ListaDeLinkDasLigas[Ligas.Franca_National] = "https://www.betfair.com/sport/football/fran%C3%A7a-national/1081960";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga2] = "https://www.betfair.com/sport/football/espanha-segunda-divis%C3%A3o/12204313";
        //ListaDeLinkDasLigas[Ligas.Espanha_TerceraDivision] = "https://www.betfair.com/sport/football/espanha-tercera-division/821269";
        //ListaDeLinkDasLigas[Ligas.Australia_ALeague] = "https://www.betfair.com/sport/football/australian-a-league-men/12117172";
        //ListaDeLinkDasLigas[Ligas.Australia_NplNSW] = "https://www.betfair.com/sport/football/australian-npl-nsw/12006346";
        //ListaDeLinkDasLigas[Ligas.Australia_NplQueensland] = "https://www.betfair.com/sport/football/austr%C3%A1lia-npl-queensland/12006772";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria] = "https://www.betfair.com/sport/football/australian-npl-victoria/12006103";
        //ListaDeLinkDasLigas[Ligas.Brasil_Brasileirao_Sub20] = "https://www.betfair.com/sport/football/brasil-sub20/12148223";
        //ListaDeLinkDasLigas[Ligas.Internacional_AmistososFeminino] = "https://www.betfair.com/sport/football/amistosos-internacionais-f/12200369";
        Seletor_Tabela = "ul.event-list";
        Seletor_CardDeJogos = Seletor_Tabela + " li.com-coupon-line-new-layout.betbutton-layout.avb-row.avb-table.market-avb.quarter-template.market-2-columns";
        Seletor_LinkDaPartida = "a.ui-nav.markets-number-arrow.ui-top.event-link.ui-gtm-click:first-child";
        Seletor_ODDS = ".ui-runner-price";
        Seletor_OpcoesDeAposta = "div.mod-minimarketview.mod-minimarketview-minimarketview.yui3-minimarketview-content, div.mod-yesnomarkets.mod-yesnomarkets-yesnomarkets.yui3-yesnomarkets-content";
        Seletor_TituloDaOpcaoDeAposta = "span.title";
        Titulo_ChanceDupla.Add("Chance Dupla");
        Titulo_ResultadoFinal.AddRange(new string[] { "Resultado Final", "Mercados de resultados da partida" });
        Seletor_AoVivo = "i.live-icon.ng-star-inserted";
        Seletor_NomeDosTimes = "td[class*='runner']";
        indice_VitoriaEmpateTimeVisitante = 1;
    }
}