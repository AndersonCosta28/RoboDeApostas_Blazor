using System.Text.Unicode;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.HttpResults;

namespace RoboDeApostas.Models;

public abstract class CasaDeAposta
{
    #region Campos estáticos
    public static bool AbrirNavegador;
    #endregion

    #region Campos
    protected IBrowser Navegador;
    public string NomeDoSite = string.Empty;
    public List<Partida> ListaDePartidas = new();

    protected string
        Seletor_Tabela = string.Empty,
        Seletor_CardDeJogos = string.Empty,
        Seletor_NomeDosTimes = string.Empty,
        Seletor_ODDS = string.Empty,
        Seletor_LinkDaPartida = string.Empty,
        Seletor_OpcoesDeAposta = string.Empty,
        Seletor_TituloDaOpcaoDeAposta = string.Empty,
        Seletor_Formulario_De_Login = string.Empty,
        Seletor_Input_Usuario = string.Empty,
        Seletor_Input_Senha = string.Empty,
        Seletor_Botao_Entrar = string.Empty,
        Seletor_AoVivo = string.Empty;

    protected List<string> Titulo_ChanceDupla = new(),
                    Titulo_ResultadoFinal = new();

    protected string Link_PaginaDeLogin = string.Empty;

    protected bool InjetarValoresNaPagina = true;

    protected Dictionary<string, string> ValoresParaInjetarNaPagina = new();

    protected sbyte indice_VitoriaEmpateTimeDaCasa = 0, indice_VitoriaEmpateTimeVisitante = 2;

    protected byte segundosParaAguardarAposEntrarNaPaginaDaLiga = 0;

    public string Link_PaginaInicial = string.Empty;

    protected IPage Pagina;

    public string LigaEmExecucao = string.Empty;

    #endregion

    #region Funções de configurações
    public CasaDeAposta()
    {
        Configurar();
        ValoresParaInjetarNaPagina.Add("Accept", "*/*");
        ValoresParaInjetarNaPagina.Add("Accept-Language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
        ValoresParaInjetarNaPagina.Add("Accept-Encoding", "gzip, deflate, br");
        ValoresParaInjetarNaPagina.Add("Connection", "keep-alive");
        ValoresParaInjetarNaPagina.Add("Referer", Link_PaginaInicial + "/");
        ValoresParaInjetarNaPagina.Add("sec-ch-ua", "\"Google Chrome\";v=\"111\", \"Not(A:Brand\";v=\"8\", \"Chromium\";v=\"111\"");
        ValoresParaInjetarNaPagina.Add("sec-ch-ua-platform", "\"Windows\"");
        ValoresParaInjetarNaPagina.Add("sec-ch-ua-mobile", "?0");
        ValoresParaInjetarNaPagina.Add("Sec-Fetch-Mode", "cors");
        ValoresParaInjetarNaPagina.Add("Sec-Fetch-Site", "same-origin");
        ValoresParaInjetarNaPagina.Add("Sec-Fetch-Dest", "empty");
        ValoresParaInjetarNaPagina.Add("DNT", "1");
        ValoresParaInjetarNaPagina.Add("Origin", Link_PaginaInicial);
        //CasasDeAposta.Add(this);
    }
    protected abstract void Configurar();

    public virtual async Task RodarPadraoAsync()
    {
        using var db = new DatabaseContext();
        var link = db.LinkDaLiga.Where(lk => lk.CasaDeAposta == this.NomeDoSite).Select(lk => new { lk.Link, Liga = lk.Liga.Nome }).ToList();
        foreach (var lk in link)
        {
            this.LigaEmExecucao = lk.Liga;
            await this.RodarPadraoAsync(lk.Link);
        }
    }


    public virtual async Task RodarPadraoAsync(string link)
    {
        var playwright = await Playwright.CreateAsync();
        IBrowser navegador = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions() { Headless = !AbrirNavegador, Devtools = false });
        this.Navegador = navegador;
        try
        {
            SalvarLog($"Executando Robo em {NomeDoSite} e na liga {LigaEmExecucao}");
            await this.PegarOsJogosCorrentesAsync(link);
        }
        finally
        {
            await navegador.CloseAsync();
        }
    }
    #endregion

    #region Funções de navegação

    protected virtual async Task NavegarParaTelaInicialDaLiga(string link)
    {
        SalvarLog($"Navegando até a liga {this.LigaEmExecucao} do site {this.NomeDoSite}");
        await NavegarEEsperar3VezesSeletoresAsync(new[] { Seletor_Tabela }, link);
        await Pagina.WaitForSelectorAsync(Seletor_CardDeJogos, new() { Timeout = 10000 });
        await Pagina.WaitForTimeoutAsync(segundosParaAguardarAposEntrarNaPaginaDaLiga * 1000);
    }

    protected virtual async Task<List<Partida>> PegarCardsDosJogosNaTelaInicialDaLiga()
    {
        List<Partida> partidas = new();
        var cardDosJogos = await Pagina.Locator(Seletor_CardDeJogos).AllAsync();
        foreach (var cardDoJogo in cardDosJogos)
            if (await ValidarCardAsync(cardDoJogo))
                partidas.Add(new(await MontarLinkDoParaAcessarOJogoAsync(cardDoJogo), this.LigaEmExecucao, NomeDoSite));
        return partidas;
    }

    public virtual async Task PegarOsJogosCorrentesAsync(string link)
    {
        Pagina = await Navegador!.NewPageAsync(InjetarValoresNaPagina ? new BrowserNewPageOptions()
        {
            UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36",
            ExtraHTTPHeaders = ValoresParaInjetarNaPagina
        } : null);
        try
        {
            await this.NavegarParaTelaInicialDaLiga(link);
            List<Partida> partidas = await this.PegarCardsDosJogosNaTelaInicialDaLiga();

            int i = 1;
            foreach (Partida partida in partidas)
            {
                try
                {
                    SalvarLog($"Acessando partida {i}/{partidas.Count} da liga {this.LigaEmExecucao} da casa de aposta {NomeDoSite}");
                    await this.NavegarEEsperar3VezesSeletoresAsync(new string[] { Seletor_ODDS, Seletor_NomeDosTimes }, partida.LinkDaPartida);
                    await this.AtribuirNomeDosTimesAsync(partida);
                    await this.AtribuirOddsAsync(partida);
                    await this.AtribuirDataDosJogosAsync(partida);
                }
                catch (Exception e)
                {
                    SalvarLog($"Erro no link -> {partida.LinkDaPartida} \n {e.Message} \n {e.StackTrace}");
                }
                finally
                {
                    i++;
                    await this.SalvarPartidaNoBanco(partida);
                }
            }
            ListaDePartidas.AddRange(partidas);
        }
        catch (Exception e)
        {
            SalvarLog($"Lançou erro final {NomeDoSite} na liga {this.LigaEmExecucao} no link {Pagina.Url} \n {e.Message} \n {e.StackTrace} \n {e.InnerException}");
            await Pagina.ScreenshotAsync(new PageScreenshotOptions() { Path = "./Prints/" + NomeDoSite + DateTime.Now.Ticks.ToString() + ".png" });
        }
        finally
        {
            await Pagina.CloseAsync();
        }
    }

    protected virtual async Task<bool> ValidarCardAsync(ILocator cardDoJogo) => !await JogoJaComecouAsync(cardDoJogo);

    protected async virtual Task<bool> JogoJaComecouAsync(ILocator cardDoJogo) => await cardDoJogo.Locator(Seletor_AoVivo).CountAsync() > 0;

    protected abstract Task AtribuirNomeDosTimesAsync(Partida jogo);

    protected virtual async Task AtribuirOddsAsync(Partida jogo)
    {
        await Pagina.WaitForSelectorAsync(Seletor_ODDS);
        var opcoesDeAposta = await Pagina.Locator(Seletor_OpcoesDeAposta).AllAsync();
        foreach (var opcaoDeAposta in opcoesDeAposta)
        {
            if (await opcaoDeAposta.Locator(Seletor_TituloDaOpcaoDeAposta).CountAsync() == 0) continue;
            var titulo = await opcaoDeAposta.Locator(Seletor_TituloDaOpcaoDeAposta).InnerTextAsync();
            if (Titulo_ChanceDupla.Contains(titulo))
            {
                await Pagina.WaitForSelectorAsync(Seletor_ODDS);
                var valor = await opcaoDeAposta.Locator(Seletor_ODDS).AllInnerTextsAsync();
                if (valor.Count < 3)
                {
                    jogo.ODD_VitoriaOuEmpate_TimeCasa = 0;
                    jogo.ODD_VitoriaOuEmpate_TimeVisitante = 0;
                    jogo.ODD_VitoriaOuEmpate_TimeVisitante = 0;
                }
                else
                {
                    if (float.TryParse(valor[indice_VitoriaEmpateTimeDaCasa].Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat, out float _valor1))
                        jogo.ODD_VitoriaOuEmpate_TimeCasa = _valor1;
                    else
                        jogo.ODD_VitoriaOuEmpate_TimeCasa = 0;

                    if (float.TryParse(valor[indice_VitoriaEmpateTimeVisitante].Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat, out float _valor2))
                        jogo.ODD_VitoriaOuEmpate_TimeVisitante = _valor2;
                    else
                        jogo.ODD_VitoriaOuEmpate_TimeVisitante = 0;
                }
            }
            else if (Titulo_ResultadoFinal.Contains(titulo))
            {
                await Pagina.WaitForSelectorAsync(Seletor_ODDS);
                var valor = await opcaoDeAposta.Locator(Seletor_ODDS).AllInnerTextsAsync();
                if (valor.Count < 3)
                {
                    jogo.ODD_Vitoria_TimeDaCasa = 0;
                    jogo.ODD_Empate_Ambos = 0;
                    jogo.ODD_Vitoria_TimeVisitante = 0;
                }
                else
                {
                    if (float.TryParse(valor[0].Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat, out float v1))
                        jogo.ODD_Vitoria_TimeDaCasa = v1;
                    else jogo.ODD_Vitoria_TimeDaCasa = 0;

                    if (float.TryParse(valor[1].Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat, out float v2))
                        jogo.ODD_Empate_Ambos = v2;
                    else jogo.ODD_Empate_Ambos = 0;

                    if (float.TryParse(valor[2].Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat, out float v3))
                        jogo.ODD_Vitoria_TimeVisitante = v3;
                    else jogo.ODD_Vitoria_TimeVisitante = 0;
                }
            }
        }
    }

    protected virtual async Task<string> MontarLinkDoParaAcessarOJogoAsync(ILocator cardDoJogo)
    {
        var link = await cardDoJogo.Locator(Seletor_LinkDaPartida).GetAttributeAsync("href") ?? throw new Exception("Link não disponível no partida dessa casa de aposta -> " + NomeDoSite);
        if (!link.Contains(Link_PaginaInicial))
            return Link_PaginaInicial + link;
        return link;
    }

    public abstract Task AtribuirDataDosJogosAsync(Partida jogo);

    public virtual async Task NavegarEEsperar3VezesSeletoresAsync(string[] seletores, string link)
    {
        string _seletores = string.Join(", ", seletores.Where(s => !string.IsNullOrWhiteSpace(s)));
        int tentativas = 3;
        try { await Pagina.GotoAsync(link); }
        catch (Exception) { }
        while (true)
        {
            try
            {
                await Pagina.WaitForSelectorAsync(_seletores, new PageWaitForSelectorOptions() { });
                break;
            }
            catch (Exception)
            {
                if (tentativas < 0)
                    throw;

                if (await Pagina.Locator(_seletores).CountAsync() != 0)
                    return;

                tentativas--;
                SalvarLog("Executou a tentativa: " + tentativas + " no link -> " + link);
                await Pagina.ReloadAsync();
            }
        }
    }

    #endregion

    #region Funções de API

    protected virtual async Task PreencherDetalhesDaPartida_RequestAsync(Partida partida) { }

    protected async virtual Task PreencherListaDePartidas(string link) { }

    protected async virtual Task<IResponse> Esperar3VezesPeloResponse(Func<IResponse, bool> acaoDeFiltrarOResponse, float tempoParaAguardarAntesDeExecutar = 0, float tempoParaAguardarDepoisDeAtualizarAPagina = 0)
    {
        sbyte i = 3;
        while (true)
        {
            try
            {
                await this.Pagina.WaitForTimeoutAsync(tempoParaAguardarAntesDeExecutar * 1000);
                return await this.Pagina.WaitForResponseAsync(r => acaoDeFiltrarOResponse(r));
            }
            catch (Exception e)
            {
                if (i < 0) throw;
                this.SalvarLog($"Executando tentativa {i} no site {this.NomeDoSite} e na liga {this.LigaEmExecucao} -> {e.Message}");
                await this.Pagina.ReloadAsync(new PageReloadOptions() { Timeout = 0 });
                await this.Pagina.WaitForTimeoutAsync(tempoParaAguardarDepoisDeAtualizarAPagina * 1000);
                i--;
            }
        }
    }

    #endregion

    #region Funções de operação

    public async Task SalvarEmJsonAsync()
    {
        using var db = new DatabaseContext();
        var lista = db.Partidas.Where(p => p.NomeDaCasaDeAposta == NomeDoSite).ToList();
        string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        });
        await File.WriteAllTextAsync($"./Resultados/{NomeDoSite}.json", json);
    }

    protected void SalvarLog(string mensagem)
    {
        string caminhoDoArquivo = $"./Logs/{NomeDoSite}.txt";
        string mensagemFormatada = $"{DateTime.Now.ToShortTimeString()} -> {mensagem}\n";
        // This text is added only once to the file.
        if (!File.Exists(caminhoDoArquivo))
        {
            // Create a file to write to.
            using StreamWriter sw = File.CreateText(caminhoDoArquivo);
            sw.WriteLine(mensagemFormatada);
        }
        // This text is always added, making the file longer over time
        // if it is not deleted.
        using (StreamWriter sw = File.AppendText(caminhoDoArquivo))
        {
            sw.WriteLine(mensagemFormatada);
        }
        Console.WriteLine(mensagemFormatada);
        File.AppendAllText(caminhoDoArquivo, mensagemFormatada);
    }

    protected async Task SalvarPartidaNoBanco(Partida partida)
    {
        using var db = new DatabaseContext();
        Partida? _partida = await db.Partidas.Where(p => p.NomeDaCasaDeAposta == this.NomeDoSite && p.NomeTimeDaCasa == partida.NomeTimeDaCasa && p.NomeTimeVisitante == partida.NomeTimeVisitante && p.DataCompleta == partida.DataCompleta).FirstOrDefaultAsync();
        if (_partida == null)
        {
            await db.Partidas.AddAsync(partida);
        }
        else
        {
            partida.Id = _partida.Id;
            db.Entry(_partida).State = EntityState.Detached;
            db.Entry(partida).State = EntityState.Modified;
            db.Partidas.Update(partida);
        }

        await db.SaveChangesAsync();
    }
    #endregion  

}