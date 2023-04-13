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