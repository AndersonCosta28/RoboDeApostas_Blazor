namespace RoboDeApostas.Models.CasasDeAposta;
class Bet365 : CasaDeAposta
{
    public override async Task AtribuirDataDosJogosAsync(Partida jogo)
    {
        string[] data = (await Pagina.Locator(".sph-ExtraData_TimeStamp").InnerTextAsync()).Trim().Split(" ");
        string horario = data[2];
        byte dia = byte.Parse(data[0]);
        byte mes = Dicionarios.Meses[data[1].ToLower()];
        jogo.DataCompleta = new DateTime(DateTime.Now.Year, mes, dia, byte.Parse(horario.Split(":")[0]), byte.Parse(horario.Split(":")[1]), 0);
    }

    protected override async Task AtribuirNomeDosTimesAsync(Partida jogo)
    {
        var nomeDosTimes = (await Pagina.Locator(".sph-EventHeader_Label span").InnerTextAsync()).Trim().Split(" v ");
        jogo.NomeTimeDaCasa = nomeDosTimes[0];
        jogo.NomeTimeVisitante = nomeDosTimes[1];
    }

    protected override void Configurar()
    {
        NomeDoSite = "Bet365";
        Link_PaginaInicial = "https://www.bet365.com";
        //ListaDeLinkDasLigas[Ligas.Internacional_LigaDosCampeoes] = "https://www.bet365.com/#/AC/B1/C1/D1002/E79147586/G40/";
        //ListaDeLinkDasLigas[Ligas.Internacional_Libertadores] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85780589/G40/";
        //ListaDeLinkDasLigas[Ligas.Inglaterra_PremierLeague] = "https://www.bet365.com/#/AC/B1/C1/D1002/E76169570/G40/H^1/";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga] = "https://www.bet365.com/#/AC/B1/C1/D1002/E76473591/G40/H^1/";
        //ListaDeLinkDasLigas[Ligas.Alemanha_Bundesliga] = "https://www.bet365.com/#/AC/B1/C1/D1002/E76469135/G40/H^1/";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieA] = "https://www.bet365.com/#/AC/B1/C1/D1002/E76509991/G40/H^1/";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue1] = "https://www.bet365.com/#/AC/B1/C1/D1002/E76468858/G40/";
        //ListaDeLinkDasLigas[Ligas.Colombia_Primera_A] = "https://www.bet365.com/#/AC/B1/C1/D1002/E26331167/G40/";
        //ListaDeLinkDasLigas[Ligas.Mexico_MX] = "https://www.bet365.com/#/AC/B1/C1/D1002/E83937487/G40/";
        //ListaDeLinkDasLigas[Ligas.EUA_MajorLeagueSoccer] = "https://www.bet365.com/#/AC/B1/C1/D1002/E84854676/G40/";
        //ListaDeLinkDasLigas[Ligas.Internacional_SulAmericana] = "https://www.bet365.com/#/AC/B1/C1/D1002/E88156539/G40/H^1/";
        //ListaDeLinkDasLigas[Ligas.Alemanha_DFBPokal] = "https://www.bet365.com/#/AC/B1/C1/D1002/E87835190/G40/";
        //ListaDeLinkDasLigas[Ligas.Espanha_CopaDelRey] = "https://www.bet365.com/#/AC/B1/C1/D1002/E83756156/G40/";
        //ListaDeLinkDasLigas[Ligas.Italia_CoppaItalia] = "https://www.bet365.com/#/AC/B1/C1/D1002/E84659091/G40/";
        //ListaDeLinkDasLigas[Ligas.Portugal_PrimeiraLiga] = "https://www.bet365.com/#/AC/B1/C1/D1002/E83376269/G40/";
        //ListaDeLinkDasLigas[Ligas.Alemanha_2Bundesliga] = "https://www.bet365.com/#/AC/B1/C1/D1002/E76947587/G40/";
        //ListaDeLinkDasLigas[Ligas.Alemanha_3Liga] = "https://www.bet365.com/#/AC/B1/C1/D1002/E76947633/G40/";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieB] = "https://www.bet365.com/#/AC/B1/C1/D1002/E77423349/G40/";
        //ListaDeLinkDasLigas[Ligas.Italia_SerieD] = "https://www.bet365.com/#/AC/B1/C1/D1002/E79320847/G40/";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraDivison] = "https://www.bet365.com/#/AC/B1/C1/D1002/E84855132/G40/";
        //ListaDeLinkDasLigas[Ligas.Argentina_PrimeraNacional] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85703530/G40/";
        //ListaDeLinkDasLigas[Ligas.Bolivia_DivisionProfesional] = "https://www.bet365.com/#/AC/B1/C1/D1002/E88048552/G40/";
        //ListaDeLinkDasLigas[Ligas.Franca_CoupeDeFrance] = "https://www.bet365.com/#/AC/B1/C1/D1002/E87834881/G40/";
        //ListaDeLinkDasLigas[Ligas.Franca_Ligue2] = "https://www.bet365.com/#/AC/B1/C1/D1002/E83374192/G40/";
        //ListaDeLinkDasLigas[Ligas.Franca_National] = "https://www.bet365.com/#/AC/B1/C1/D1002/E77817255/G40/";
        //ListaDeLinkDasLigas[Ligas.Espanha_LaLiga2] = "https://www.bet365.com/#/AC/B1/C1/D1002/E76947668/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_ALeague] = "https://www.bet365.com/#/AC/B1/C1/D1002/E78975603/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplNSW] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85724828/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplQueensland] = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294051/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85742801/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_WesternPremierLeague] = "https://www.bet365.com/#/AC/B1/C1/D1002/E87270813/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_SouthPremierLeague] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85742770/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoriaPremierLeague2] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85742819/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoriaPremierLeague3] = "https://www.bet365.com/#/AC/B1/C1/D1002/E87268254/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_QueenslandPreimierLeague2] = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294086/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria_Female] = "https://www.bet365.com/#/AC/B1/C1/D1002/E87268303/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NorthernNswPremierLeague] = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294159/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_QueenslandPremierLeague1_Sub23] = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294133/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NSWPremierLeague_Sub20] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85704033/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NplVictoria_Sub21] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85742821/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NSWLeague1_Sub20] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85724836/G40/";
        //ListaDeLinkDasLigas[Ligas.Australia_NorthernNSWLeague1] = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294162/G40/";
        //ListaDeLinkDasLigas[Ligas.Brasil_Brasileirao_Sub20] = "https://www.bet365.com/#/AC/B1/C1/D1002/E86834272/G40/";
        //ListaDeLinkDasLigas[Ligas.Internacional_AmistososFeminino] = "https://www.bet365.com/#/AC/B1/C1/D1002/E87626707/G40/";
        //ListaDeLinkDasLigas[Ligas.Paraguai_PrimeraDivision] = "https://www.bet365.com/#/AC/B1/C1/D1002/E85440928/G40/";
        Seletor_Tabela = ".cm-CouponModule";
        Seletor_CardDeJogos = ".rcl-ParticipantFixtureDetails_LhsContainerInner:not(:has(.pi-CouponParticipantClockInPlay_GameTimerWrapper)) .rcl-ParticipantFixtureDetails_TeamAndScoresContainer";
        Seletor_ODDS = ".gl-Participant_Odds";
        Seletor_OpcoesDeAposta = ".gl-MarketGroup";
        Seletor_TituloDaOpcaoDeAposta = ".gl-MarketGroupButton_Text";
        Titulo_ChanceDupla.Add("Dupla Hipótese");
        Titulo_ResultadoFinal.Add("Resultado Final");
        Seletor_AoVivo = ".pi-CouponParticipantClockInPlay_GameTimerWrapper";
        indice_VitoriaEmpateTimeVisitante = 1;
    }

    public override async Task PegarOsJogosCorrentesAsync(string link)
    {
        string liga = this.LigaEmExecucao;
        Pagina = await Navegador!.NewPageAsync(new()
        {
            UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36",
            ExtraHTTPHeaders = ValoresParaInjetarNaPagina,

        });
        using var db = new DatabaseContext();
        await NavegarEEsperar3VezesSeletoresAsync(new[] { Seletor_Tabela }, link);
        await Pagina.WaitForSelectorAsync(Seletor_Tabela);
        await Pagina.WaitForTimeoutAsync(1000);
        var cards = await Pagina.Locator(Seletor_CardDeJogos).AllAsync();
        for (int i = 0; i < cards.Count; i++)
        {
            await Pagina.WaitForSelectorAsync(Seletor_Tabela);
            await Pagina.WaitForTimeoutAsync(1000);
            var itens = await Pagina.Locator(Seletor_CardDeJogos).AllAsync();
            await itens[i].ClickAsync();
            SalvarLog($"Acessando jogo {i + 1}/{cards.Count} da liga {this.LigaEmExecucao} da casa de aposta {NomeDoSite}");
            await Pagina.WaitForTimeoutAsync(1000);
            await Pagina.ReloadAsync(new PageReloadOptions() { WaitUntil = WaitUntilState.DOMContentLoaded });
            try
            {
                await Pagina.WaitForSelectorAsync(".sph-EventHeader.sph-EventHeader-hasnavbar.sph-EventHeader-wide");
            }
            catch (Exception)
            {
                await Pagina.GoBackAsync();
                await Pagina.WaitForTimeoutAsync(1000);
                await Pagina.ReloadAsync();
                await Pagina.WaitForSelectorAsync(Seletor_Tabela);
                continue;
            }
            Partida partida = new(Pagina.Url, this.LigaEmExecucao, NomeDoSite);
            await AtribuirNomeDosTimesAsync(partida);
            await AtribuirOddsAsync(partida);
            await AtribuirDataDosJogosAsync(partida);
            ListaDePartidas.Add(partida);
            await Pagina.GotoAsync(link);
            await Pagina.WaitForTimeoutAsync(1000);
            await Pagina.ReloadAsync();
            await Pagina.WaitForSelectorAsync(Seletor_Tabela);
            await SalvarPartidaNoBanco(partida);
        }

        // await Pagina.WaitForSelectorAsync(".sph-EventHeader.sph-EventHeader-hasnavbar.sph-EventHeader-wide");
        await Pagina.CloseAsync();
    }
}