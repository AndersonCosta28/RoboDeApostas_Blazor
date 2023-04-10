namespace RoboDeApostas.Models.CasasDeAposta;

class Betway : CasaDeAposta
{
    protected override async Task AtribuirNomeDosTimesAsync(Partida jogo)
    {
        var nomeDosTimes = await page.Locator(Seletor_NomeDosTimes).InnerTextAsync();
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
                //await page.WaitForLoadStateAsync(LoadState.NetworkIdle);
                if (await page.Locator(seletor_secundario).CountAsync() > 0)
                {
                    // Formato desse texto normalmente vem assim -> O evento começa às 10:30, 08/04/2023
                    var texto = await page.Locator(seletor_secundario).InnerTextAsync();
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
                    IFrameLocator frame = page.FrameLocator(seletor_frame);
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
                    SalvarLog($"Não conseguiu capturar a data deste link -> {page.Url} \n{e.Message} \n {e.StackTrace}");
                    partida.DataCompleta = new DateTime();
                }
                SalvarLog($"Executou a tentiva {numeroDeTentativas} neste link -> {page.Url}");
                numeroDeTentativas--;
                await page.WaitForTimeoutAsync(2000);
            }
    }
    protected override void Configurar()
    {
        NomeDoSite = "Betway";
        Link_PaginaInicial = "https://betway.com";
        //ListaDeLinkDasLigas[Ligas.Internacional_LigaDosCampeoes] = "https://betway.com/pt/sports/grp/soccer/european-cups/uefa-champions-league";
        //ListaDeLinkDasLigas[Ligas.Inglaterra_PremierLeague] = "https://betway.com/pt/sports/grp/soccer/england/premier-league";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga] = "https://betway.com/pt/sports/grp/soccer/spain/la-liga";
        //ListaDeLinkDasLigas[Ligas.Alemanha_Bundesliga] = "https://betway.com/pt/sports/grp/soccer/germany/bundesliga";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieA] = "https://betway.com/pt/sports/grp/soccer/italy/serie-a";
        //ListaDeLinkDasLigas[Ligas.Brasil_LigaBrasileiraPaulista] = "https://betway.com/pt/sports/grp/soccer/brazil/paulista";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue1] = "https://betway.com/pt/sports/grp/soccer/france/ligue-1";
        //ListaDeLinkDasLigas[Ligas.Holanda_Eredivisie] = "https://betway.com/pt/sports/grp/soccer/netherlands/eredivisie";
        //ListaDeLinkDasLigas[Ligas.CopaDasNacoesAfricanasEliminatorias] = "https://betway.com/pt/sports/grp/soccer/international/africa-cup-of-nations-qualifiers";
        //ListaDeLinkDasLigas[Ligas.Colombia_Primera_A] = "https://betway.com/pt/sports/grp/soccer/colombia/primera-a";
        //ListaDeLinkDasLigas[Ligas.Mexico_MX] = "https://betway.com/pt/sports/grp/soccer/mexico/liga-mx";
        //ListaDeLinkDasLigas[Ligas.EUA_MajorLeagueSoccer] = "https://betway.com/pt/sports/grp/soccer/usa/championship";
        //ListaDeLinkDasLigas[Ligas.Internacional_Libertadores] = "https://betway.com/pt/sports/grp/soccer/international-club/copa-libertadores";
        //ListaDeLinkDasLigas[Ligas.Alemanha_DFBPokal] = "https://betway.com/pt/sports/grp/soccer/germany/dfb-pokal";
        //ListaDeLinkDasLigas[Ligas.Espanha_CopaDelRey] = "https://betway.com/pt/sports/grp/soccer/spain/copa-del-rey";
        //ListaDeLinkDasLigas[Ligas.Italia_CoppaItalia] = "https://betway.com/pt/sports/grp/soccer/italy/coppa-italia";
        //ListaDeLinkDasLigas[Ligas.Portugal_PrimeiraLiga] = "https://betway.com/pt/sports/grp/soccer/portugal/primeira-liga";
        //ListaDeLinkDasLigas[Ligas.Portugal_SegundaLiga] = "https://betway.com/pt/sports/grp/soccer/portugal/segunda-liga";
        //ListaDeLinkDasLigas[Ligas.Alemanha_2Bundesliga] = "https://betway.com/pt/sports/grp/soccer/germany/2-bundesliga";
        //ListaDeLinkDasLigas[Ligas.Alemanha_3Liga] = "https://betway.com/pt/sports/grp/soccer/germany/3-liga";
        //ListaDeLinkDasLigas[Ligas.Holanda_EersteDivisie] = "https://betway.com/pt/sports/grp/soccer/netherlands/eerste-divisie";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieB] = "https://betway.com/pt/sports/grp/soccer/italy/serie-b";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieC] = "https://betway.com/pt/sports/grp/soccer/italy/serie-c";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieD] = "https://betway.com/pt/sports/grp/soccer/italy/serie-d";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraDivison] = "https://betway.com/pt/sports/grp/soccer/argentina/primera-division";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraNacional] = "https://betway.com/pt/sports/grp/soccer/argentina/primera-nacional";
        //ListaDeLinkDasLigas[Ligas.Franca_CoupeDeFrance] = "https://betway.com/pt/sports/grp/soccer/france/coupe-de-france";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue2] = "https://betway.com/pt/sports/grp/soccer/france/ligue-2";
        //ListaDeLinkDasLigas[Ligas.Franca_National] = "https://betway.com/pt/sports/grp/soccer/france/national";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga2] = "https://betway.com/pt/sports/grp/soccer/spain/la-liga-2";
        //ListaDeLinkDasLigas[Ligas.Espanha_TerceraDivision] = "https://betway.com/pt/sports/grp/soccer/spain/tercera-division";
        //ListaDeLinkDasLigas[Ligas.Australia_ALeague] = "https://betway.com/pt/sports/grp/soccer/australia/a-league";
        //ListaDeLinkDasLigas[Ligas.Australia_NplNSW] = "https://betway.com/pt/sports/grp/soccer/australia/new-south-wales-premier-league";
        //ListaDeLinkDasLigas[Ligas.Australia_NplQueensland] = "https://betway.com/pt/sports/grp/soccer/australia/queensland-premier-league";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria] = "https://betway.com/pt/sports/grp/soccer/australia/victoria-premier-league";
        //ListaDeLinkDasLigas[Ligas.Australia_WesternPremierLeague] = "https://betway.com/pt/sports/grp/soccer/australia/western-australia-premier-league";
        //ListaDeLinkDasLigas[Ligas.Australia_SouthPremierLeague] = "https://betway.com/pt/sports/grp/soccer/australia/south-australia-premier-league";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoriaPremierLeague2] = "https://betway.com/pt/sports/grp/soccer/australia/victoria-premier-league-2";
        //ListaDeLinkDasLigas[Ligas.Australia_NorthernNswPremierLeague] = "https://betway.com/pt/sports/grp/soccer/australia/northern-nsw-premier-league";
        //ListaDeLinkDasLigas[Ligas.Brasil_Brasileirao_Sub20] = "https://betway.com/pt/sports/grp/soccer/brazil/u20-matches";
        //ListaDeLinkDasLigas[Ligas.Internacional_AmistososFeminino] = "https://betway.com/pt/sports/grp/soccer/international/womens-matches";
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
}
