namespace RoboDeApostas.Models.CasasDeAposta;
class Betano : CasaDeAposta
{
    // public Betano(IBrowser navegador) : base(navegador) { }

    protected override async Task AtribuirNomeDosTimesAsync(Partida jogo)
    {
        // await page.WaitForSelectorAsync(Seletor_NomeDosTimes);
        // await this.Esperar3Vezes_Seletor(page, Seletor_NomeDosTimes);
        var nomeDosTimes = await page.Locator(Seletor_NomeDosTimes).AllInnerTextsAsync();
        jogo.NomeTimeDaCasa = nomeDosTimes[0];
        jogo.NomeTimeVisitante = nomeDosTimes[1];
    }

    public override async Task AtribuirDataDosJogosAsync(Partida partida)
    {
        var valor = await page.Locator(".event-details__info__top__datetime").TextContentAsync();
        string[] valorArray = valor!.Split(", ")[1].Split(" ");
        byte dia = byte.Parse(valorArray[0]);
        byte mes = Dicionarios.Meses[valorArray[1][..3].ToLower()];
        int ano = int.Parse(valorArray[2]);
        string[] horario = valorArray[3].Split(":");
        byte hora = byte.Parse(horario[0]);
        byte minuto = byte.Parse(horario[1]);
        DateTime novaData = new(ano, mes, dia, hora, minuto, 0);
        partida.DataCompleta = novaData;
    }

    protected override void Configurar()
    {
        NomeDoSite = "Betano";
        Link_PaginaInicial = "https://br.betano.com";
        //ListaDeLinkDasLigas[Ligas.Internacional_LigaDosCampeoes] = "https://br.betano.com/sport/futebol/liga-dos-campeoes/jogos/182748/";
        //ListaDeLinkDasLigas[Ligas.Inglaterra_PremierLeague] = "https://br.betano.com/sport/futebol/inglaterra/premier-league/1/";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga] = "https://br.betano.com/sport/futebol/espanha/laliga/5/";
        //ListaDeLinkDasLigas[Ligas.Alemanha_Bundesliga] = "https://br.betano.com/sport/futebol/alemanha/bundesliga/216/";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieA] = "https://br.betano.com/sport/futebol/italia/serie-a/1635/";
        //ListaDeLinkDasLigas[Ligas.Brasil_LigaBrasileiraPaulista] = "https://br.betano.com/sport/futebol/brasil/campeonato-paulista-serie-a1/16901/";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue1] = "https://br.betano.com/sport/futebol/franca/ligue-1/215/";
        //ListaDeLinkDasLigas[Ligas.Holanda_Eredivisie] = "https://br.betano.com/sport/futebol/holanda/eredivisie/17067r/";
        //ListaDeLinkDasLigas[Ligas.CopaDasNacoesAfricanasEliminatorias] = "https://br.betano.com/sport/futebol/caf/copa-das-nacoes-africanas-eliminatorias/191348/";
        //ListaDeLinkDasLigas[Ligas.Internacional_AmistososInternacionais] = "https://br.betano.com/sport/futebol/internacional/jogos-amistosos/17026/";
        //ListaDeLinkDasLigas[Ligas.Colombia_Primera_A] = "https://br.betano.com/sport/futebol/colombia/categoria-primera-a/16940r/";
        //ListaDeLinkDasLigas[Ligas.Mexico_MX] = "https://br.betano.com/sport/futebol/mexico/liga-mx/17264r/";
        //ListaDeLinkDasLigas[Ligas.EUA_MajorLeagueSoccer] = "https://br.betano.com/sport/futebol/eua/mls/17103r/";
        //ListaDeLinkDasLigas[Ligas.Internacional_Libertadores] = "https://br.betano.com/sport/futebol/competicoes/copa-libertadores/189817/";
        //ListaDeLinkDasLigas[Ligas.Internacional_SulAmericana] = "https://br.betano.com/sport/futebol/competicoes/copa-sul-americana/189818/";
        //ListaDeLinkDasLigas[Ligas.Espanha_CopaDelRey] = "https://br.betano.com/sport/futebol/espanha/copa-do-rei/10067/";
        //ListaDeLinkDasLigas[Ligas.Italia_CoppaItalia] = "https://br.betano.com/sport/futebol/italia/copa-de-italia/10815/";
        //ListaDeLinkDasLigas[Ligas.Portugal_PrimeiraLiga] = "https://br.betano.com/sport/futebol/portugal/primeira-liga/17083/";
        //ListaDeLinkDasLigas[Ligas.Portugal_SegundaLiga] = "https://br.betano.com/sport/futebol/portugal/liga-2/17385r/";
        //ListaDeLinkDasLigas[Ligas.Portugal_TerceiraLiga] = "https://br.betano.com/sport/futebol/portugal/liga-3/197549r/";
        //ListaDeLinkDasLigas[Ligas.Alemanha_2Bundesliga] = "https://br.betano.com/sport/futebol/alemanha/2-bundesliga/217r/";
        //ListaDeLinkDasLigas[Ligas.Alemanha_3Liga] = "https://br.betano.com/sport/futebol/alemanha/3-liga/17313r/";
        //ListaDeLinkDasLigas[Ligas.Holanda_EersteDivisie] = "https://br.betano.com/sport/futebol/holanda/eerste-divisie/17370/";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieB] = "https://br.betano.com/sport/futebol/italia/serie-b/10210r/";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieC] = "https://br.betano.com/sport/futebol/italia/serie-c/17714r/";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieD] = "https://br.betano.com/sport/futebol/italia/serie-d/15285r/";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraDivison] = "https://br.betano.com/sport/futebol/argentina/liga-profesional/195785r/";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraNacional] = "https://br.betano.com/sport/futebol/argentina/primera-b-nacional/17244/";
        //ListaDeLinkDasLigas[Ligas.Bolivia_DivisionProfesional] = "https://br.betano.com/sport/futebol/bolivia/division-profesional/18274/";
        //ListaDeLinkDasLigas[Ligas.Franca_CoupeDeFrance] = "https://br.betano.com/sport/futebol/franca/coupe-de-france/11963/";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue2] = "https://br.betano.com/sport/futebol/franca/ligue-2/10467/";
        //ListaDeLinkDasLigas[Ligas.Franca_National] = "https://br.betano.com/sport/futebol/franca/national/11962/";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga2] = "https://br.betano.com/sport/futebol/espanha/segunda-division/10000/";
        //ListaDeLinkDasLigas[Ligas.Espanha_TerceraDivision] = "https://br.betano.com/sport/futebol/espanha/tercera-division-rfef/17592/";
        //ListaDeLinkDasLigas[Ligas.Australia_ALeague] = "https://br.betano.com/sport/futebol/australia/a-league/16816/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplNSW] = "https://br.betano.com/sport/futebol/australia/npl-nsw-premier-league/17458/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplQueensland] = "https://br.betano.com/sport/futebol/australia/npl-queensland/189802/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria] = "https://br.betano.com/sport/futebol/australia/npl-victoria/17360/";
        //ListaDeLinkDasLigas[Ligas.Australia_WesternPremierLeague] = "https://br.betano.com/sport/futebol/australia/npl-western-australia/17499/";
        //ListaDeLinkDasLigas[Ligas.Australia_SouthPremierLeague] = "https://br.betano.com/sport/futebol/australia/npl-south-australia/17318/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoriaPremierLeague2] = "https://br.betano.com/sport/futebol/australia/npl-2-victoria/186782/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoriaPremierLeague3] = "https://br.betano.com/sport/futebol/australia/npl-3-victoria/196380/";
        //ListaDeLinkDasLigas[Ligas.Australia_QueenslandPreimierLeague2] = "https://br.betano.com/sport/futebol/australia/queensland-premier-league-2/196366/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria_Female] = "https://br.betano.com/sport/futebol/australia/npl-victoria-f/199063/";
        //ListaDeLinkDasLigas[Ligas.Australia_NorthernNswPremierLeague] = "https://br.betano.com/sport/futebol/australia/npl-northern-nsw-premier-league/183992/";
        //ListaDeLinkDasLigas[Ligas.Australia_QueenslandPremierLeague1_Sub23] = "https://br.betano.com/sport/futebol/australia/queensland-premier-league-1-sub-23/196299/";
        //ListaDeLinkDasLigas[Ligas.Australia_NSWPremierLeague_Sub20] = "https://br.betano.com/sport/futebol/australia/npl-nsw-premier-league-sub-20/17543/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria_Sub21] = "https://br.betano.com/sport/futebol/australia/npl-victoria-sub-21/18206/";
        //ListaDeLinkDasLigas[Ligas.Australia_NSWLeague1_Sub20] = "https://br.betano.com/sport/futebol/australia/nsw-league-one-sub-20/187778/";
        //ListaDeLinkDasLigas[Ligas.Australia_NorthernNSWLeague1] = "https://br.betano.com/sport/futebol/australia/northern-nsw-league-one/18394/";
        //ListaDeLinkDasLigas[Ligas.Brasil_Brasileirao_Sub20] = "https://br.betano.com/sport/futebol/brasil/campeonato-brasileiro-sub-20/184051r/";
        //ListaDeLinkDasLigas[Ligas.Brasil_BrasileiraoSerieA] = "https://br.betano.com/sport/futebol/brasil/brasileirao-serie-a/10016/";
        //ListaDeLinkDasLigas[Ligas.Internacional_AmistososFeminino] = "https://br.betano.com/sport/futebol/competicoes/internacional/11364/";
        //ListaDeLinkDasLigas[Ligas.Paraguai_PrimeraDivision] = "https://br.betano.com/sport/futebol/competicoes/paraguai/11379/";
        Seletor_Tabela = ".events-list__grid";
        Seletor_CardDeJogos = ".events-list__grid__event";
        Seletor_NomeDosTimes = "span.participant__name span";
        Seletor_ODDS = ".selections__selection__odd";
        Seletor_LinkDaPartida = "a.GTM-event-link.events-list__grid__info__main";
        Seletor_OpcoesDeAposta = ".markets__market";
        Seletor_TituloDaOpcaoDeAposta = ".markets__market__header__title";
        Titulo_ChanceDupla.Add("Chance Dupla");
        Titulo_ResultadoFinal.Add("Resultado Final");
        Link_PaginaDeLogin = "https://br.betano.com/myaccount/login";
        Seletor_Formulario_De_Login = ".main-content.main-content-login";
        Seletor_Input_Usuario = ".main-content.main-content-login input#username";
        Seletor_Input_Senha = ".main-content.main-content-login input#password";
        Seletor_Botao_Entrar = ".main-content.main-content-login button[type='submit']";
        Seletor_AoVivo = "span[data-msgid*='LIVE']";
        indice_VitoriaEmpateTimeVisitante = 1;
    }

    // protected override async Task PularCaptcha()
    // {
    //     IFrameLocator frameDoCaptcha = page!.FrameLocator("iframe[title='Widget containing a Cloudflare security challenge']");
    //     var botoes = page.Locator("input[type='button']");
    //     var caixasDeConfirmacao = frameDoCaptcha.Locator("input[type='checkbox']");
    //     var mensagemQueEstaChegandoONavegador = page.Locator("p#cf-spinner-please-wait");
    //     // while (true)
    //     // {
    //     //     try
    //     //     {
    //     //         foreach (var botao in await botoes.AllAsync())
    //     //         {
    //     //             await botao.ClickAsync();
    //     //             continue;
    //     //         }
    //     //         if (await page.Locator("iframe[title='Widget containing a Cloudflare security challenge']").CountAsync() > 0)
    //     //         {
    //     //             foreach (var caixaDeConfirmacao in await caixasDeConfirmacao.AllAsync())
    //     //                 await caixaDeConfirmacao.CheckAsync();
    //     //             continue;
    //     //         }
    //     //     }
    //     //     catch (System.Exception)
    //     //     {
    //     //         Console.WriteLine("Deu erro, mas vamos continuar");
    //     //         continue;
    //     //     }

    //     //     int c = await mensagemQueEstaChegandoONavegador.CountAsync();
    //     //     if (c == 0) break;
    //     //     await page.WaitForTimeoutAsync(5);
    //     //     Console.WriteLine("Aguardando a verificação do robô");
    //     // }
    // }
}