namespace RoboDeApostas.Models.CasasDeAposta;
class SportingBet : CasaDeAposta
{
    public override async Task AtribuirDataDosJogosAsync(Partida partida)
    {
        DateTime dataAtual = DateTime.Now;
        string? seletor_data = await page.Locator("div.event-time > span.date").TextContentAsync();
        string? seletor_hora = await page.Locator("div.event-time > span.time").TextContentAsync();
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
        // await page.WaitForSelectorAsync(Seletor_NomeDosTimes);
        // await this.Esperar3Vezes_Seletor(page, Seletor_NomeDosTimes);
        var nomeDosTimes = await page.Locator(Seletor_NomeDosTimes).AllInnerTextsAsync();
        jogo.NomeTimeDaCasa = nomeDosTimes[0];
        jogo.NomeTimeVisitante = nomeDosTimes[1];
    }

    protected override void Configurar()
    {
        NomeDoSite = "Sporting Bet";
        Link_PaginaInicial = "https://sports.sportingbet.com";
        //ListaDeLinkDasLigas[Ligas.Internacional_LigaDosCampeoes] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/europa-7/liga-dos-campe%C3%B5es-0:3";
        //ListaDeLinkDasLigas[Ligas.Inglaterra_PremierLeague] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/inglaterra-14/premier-league-102841";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/espanha-28/laliga-102829";
        //ListaDeLinkDasLigas[Ligas.Alemanha_Bundesliga] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/alemanha-17/bundesliga-102842";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieA] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/it%C3%A1lia-20/s%C3%A9rie-a-102846";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue1] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/fran%C3%A7a-16/ligue-1-102843";
        //ListaDeLinkDasLigas[Ligas.Holanda_Eredivisie] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/holanda-36";
        //ListaDeLinkDasLigas[Ligas.CopaDasNacoesAfricanasEliminatorias] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/%C3%A1frica-11/copa-africana-de-na%C3%A7%C3%B5es-eliminat%C3%B3rias-103058";
        //ListaDeLinkDasLigas[Ligas.Internacional_AmistososInternacionais] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/mundo-6/amistosos-internacionais-102897";
        //ListaDeLinkDasLigas[Ligas.Colombia_Primera_A] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/col%C3%B4mbia-45/primera-a-apertura-102161";
        //ListaDeLinkDasLigas[Ligas.Mexico_MX] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/m%C3%A9xico-43/liga-mx-clausura-102375";
        //ListaDeLinkDasLigas[Ligas.EUA_MajorLeagueSoccer] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/am%C3%A9rica-do-norte-9/major-league-soccer-102849";
        //ListaDeLinkDasLigas[Ligas.Internacional_Libertadores] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/am%C3%A9rica-do-sul-42/conmebol-libertadores-102827";
        //ListaDeLinkDasLigas[Ligas.Internacional_SulAmericana] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/am%C3%A9rica-do-sul-42/conmebol-sudamericana-102696";
        //ListaDeLinkDasLigas[Ligas.Alemanha_DFBPokal] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/alemanha-17/copa-da-alemanha-102809";
        //ListaDeLinkDasLigas[Ligas.Espanha_CopaDelRey] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/espanha-28/copa-do-rei-102728";
        //ListaDeLinkDasLigas[Ligas.Italia_CoppaItalia] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/it%C3%A1lia-20/copa-da-it%C3%A1lia-102811";
        //ListaDeLinkDasLigas[Ligas.Portugal_PrimeiraLiga] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/portugal-37/primeira-liga-102851";
        //ListaDeLinkDasLigas[Ligas.Portugal_SegundaLiga] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/portugal-37/liga-portugal-2-102206";
        //ListaDeLinkDasLigas[Ligas.Alemanha_2Bundesliga] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/alemanha-17/2-bundesliga-102845";
        //ListaDeLinkDasLigas[Ligas.Alemanha_3Liga] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/alemanha-17/3%C2%AA-liga-102377";
        //ListaDeLinkDasLigas[Ligas.Holanda_EersteDivisie] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/holanda-36/segunda-divis%C3%A3o-holanda-102254";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieB] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/it%C3%A1lia-20/s%C3%A9rie-b-102848";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraDivison] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/argentina-38/primera-divisi%C3%B3n-102540";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraNacional] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/argentina-38/primera-nacional-102234";
        //ListaDeLinkDasLigas[Ligas.Bolivia_DivisionProfesional] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/bol%C3%ADvia-44/divisi%C3%B3n-profesional-102510";
        //ListaDeLinkDasLigas[Ligas.Franca_CoupeDeFrance] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/fran%C3%A7a-16/copa-da-fran%C3%A7a-102808";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue2] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/fran%C3%A7a-16/ligue-2-102376";
        //ListaDeLinkDasLigas[Ligas.Franca_National] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/fran%C3%A7a-16/national-101523";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga2] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/espanha-28/laliga-2-102830";
        //ListaDeLinkDasLigas[Ligas.Australia_ALeague] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/a-league-2068";
        //ListaDeLinkDasLigas[Ligas.Australia_NplNSW] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/npl-new-south-wales-101878";
        //ListaDeLinkDasLigas[Ligas.Australia_NplQueensland] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/queensland-npl-101879";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/victoria-npl-1-101871";
        //ListaDeLinkDasLigas[Ligas.Australia_WesternPremierLeague] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/western-australia-npl-101882";
        //ListaDeLinkDasLigas[Ligas.Australia_SouthPremierLeague] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/south-australia-npl-101881";
        //ListaDeLinkDasLigas[Ligas.Australia_NorthernNswPremierLeague] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/northern-nsw-npl-101877";
        //ListaDeLinkDasLigas[Ligas.Brasil_Brasileirao_Sub20] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/brasil-33/campeonato-brasileiro-sub-20-102135";
        //ListaDeLinkDasLigas[Ligas.Brasil_BrasileiraoSerieA] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/brasil-33/brasileir%C3%A3o-s%C3%A9rie-a-102838";
        //ListaDeLinkDasLigas[Ligas.Internacional_AmistososFeminino] = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/mundo-6/amistosos-internacionais-feminino-102932";
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
        // this.Link_PaginaDeLogin = "https://www.sportingbet.com/pt-br/labelhost/login";
        // this.Seletor_Formulario_De_Login = "form.loginForm";
        // this.Seletor_Input_Usuario = "div.inputContainer.usernameInput input";
        // this.Seletor_Input_Senha = "div.inputContainer.passwordInput input";
        // this.Seletor_Botao_Entrar = "input.loginSubmit";
        Seletor_AoVivo = "i.live-icon.ng-star-inserted";
    }
}