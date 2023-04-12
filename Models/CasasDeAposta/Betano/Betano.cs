using RoboDeApostas.Utils;

namespace RoboDeApostas.Models.CasasDeAposta;
class Betano : CasaDeAposta
{
    protected override async Task AtribuirNomeDosTimesAsync(Partida jogo)
    {
        var nomeDosTimes = await Pagina.Locator(Seletor_NomeDosTimes).AllInnerTextsAsync();
        jogo.NomeTimeDaCasa = nomeDosTimes[0];
        jogo.NomeTimeVisitante = nomeDosTimes[1];
    }

    public override async Task AtribuirDataDosJogosAsync(Partida partida)
    {
        var valor = await Pagina.Locator(".event-details__info__top__datetime").TextContentAsync();
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
        Seletor_Tabela = ".events-list__grid";
        Seletor_CardDeJogos = ".events-list__grid__event";
        Seletor_NomeDosTimes = "span.participant__name span";
        Seletor_ODDS = ".selections__selection__odd";
        Seletor_LinkDaPartida = "a.GTM-event-linkApi.events-list__grid__info__main";
        Seletor_OpcoesDeAposta = ".markets__market";
        Seletor_TituloDaOpcaoDeAposta = ".markets__market__header__title";
        Titulo_ChanceDupla.Add("Chance Dupla");
        Titulo_ResultadoFinal.Add("Resultado Final");
        Link_PaginaDeLogin = "https://br.betano.com/myaccount/login";
        Seletor_Formulario_De_Login = ".main-json.main-json-login";
        Seletor_Input_Usuario = ".main-json.main-json-login input#username";
        Seletor_Input_Senha = ".main-json.main-json-login input#password";
        Seletor_Botao_Entrar = ".main-json.main-json-login button[type='submit']";
        Seletor_AoVivo = "span[data-msgid*='LIVE']";
        indice_VitoriaEmpateTimeVisitante = 1;
    }

    protected override async Task PreencherDetalhesDaPartida_RequestAsync(Partida partida)
    {
        string linkBaseAPI = $"{Link_PaginaInicial}/api";
        string linkApi = partida.LinkDaPartida.Replace(Link_PaginaInicial, linkBaseAPI);
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, $"{linkApi}?req=la,s,stnf,c,mb");
        request.Headers.Add("authority", "br.betano.com");
        request.Headers.Add("accept", "application/json, text/plain, */*");
        request.Headers.Add("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
        request.Headers.Add("dnt", "1");
        request.Headers.Add("sec-ch-ua", "\"Google Chrome\";v=\"111\", \"Not(A:Brand\";v=\"8\", \"Chromium\";v=\"111\"");
        request.Headers.Add("sec-ch-ua-mobile", "?0");
        request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
        request.Headers.Add("sec-fetch-dest", "empty");
        request.Headers.Add("sec-fetch-mode", "cors");
        request.Headers.Add("sec-fetch-site", "same-origin");
        request.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36");
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        string html = await response.Content.ReadAsStringAsync();
        html = html.Replace("\r\n", "").Replace("\n", "").Replace("\\", "");
        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(html);

        //string json = htmlDoc.DocumentNode.SelectSingleNode("/html/body/script[1]").InnerText.Replace("window[\"initial_state\"]=", "").Trim();
        var data = BetanoAPI.DetalheDaPartida.ResponseDetalheDaPartida.FromJson(html).Data.Event;
        if ((bool)(data.LiveNow ?? false))
        {
            this.ListaDePartidas.Remove(partida);
            return;
        }
        partida.ODD_Vitoria_TimeDaCasa = data.Markets.Where(m => Titulo_ResultadoFinal.Contains(m.Name)).ToList()[0].Selections[0].Price ?? 0;
        partida.ODD_Empate_Ambos = data.Markets.Where(m => Titulo_ResultadoFinal.Contains(m.Name)).First().Selections[1].Price ?? 0;
        partida.ODD_Vitoria_TimeVisitante = data.Markets.Where(m => Titulo_ResultadoFinal.Contains(m.Name)).First().Selections[2].Price ?? 0;
        partida.ODD_VitoriaOuEmpate_TimeCasa = data.Markets.Where(m => Titulo_ChanceDupla.Contains(m.Name)).First().Selections[indice_VitoriaEmpateTimeDaCasa].Price ?? 0;
        partida.ODD_VitoriaOuEmpate_TimeVisitante = data.Markets.Where(m => Titulo_ChanceDupla.Contains(m.Name)).First().Selections[indice_VitoriaEmpateTimeVisitante].Price ?? 0;
    }

    protected override async Task PreencherListaDePartidas(string link)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, link);
        request.Headers.Add("authority", "br.betano.com");
        request.Headers.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
        request.Headers.Add("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
        request.Headers.Add("cache-control", "max-age=0");
        request.Headers.Add("dnt", "1");
        request.Headers.Add("sec-ch-ua", "\"Google Chrome\";v=\"111\", \"Not(A:Brand\";v=\"8\", \"Chromium\";v=\"111\"");
        request.Headers.Add("sec-ch-ua-mobile", "?0");
        request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
        request.Headers.Add("sec-fetch-dest", "document");
        request.Headers.Add("sec-fetch-mode", "navigate");
        request.Headers.Add("sec-fetch-site", "same-origin");
        request.Headers.Add("sec-fetch-user", "?1");
        request.Headers.Add("upgrade-insecure-requests", "1");
        request.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36");
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        string html = await response.Content.ReadAsStringAsync();
        html = html.Replace("\r\n", "").Replace("\n", "").Replace("\\", "");
        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(html);
        var json = htmlDoc.DocumentNode.SelectSingleNode("/html/head/script[2]").InnerText.Trim();
        List<BetanoAPI.ListaDePartida.ResponseListaDePartida> data = BetanoAPI.ListaDePartida.ResponseListaDePartida.FromJson(json);
        foreach (var item in data)
        {
            Partida partida = new(item.Url.ToString(), LigaEmExecucao, NomeDoSite)
            {
                NomeTimeDaCasa = item.HomeTeam.Name,
                NomeTimeVisitante = item.AwayTeam.Name,
                LinkDaPartida = item.Url.ToString(),
                DataCompleta = Funcoes.ConverterFusoHorario((DateTimeOffset) item.StartDate!)
            };
            ListaDePartidas.Add(partida);
        }

    }

    public override Task PegarOsJogosCorrentesAsync(string link)
    {
        return base.PegarOsJogosCorrentesAsync(link);
    }

    public override async Task RodarPadraoAsync(string link)
    {
        try
        {
            this.SalvarLog($"Executando Robo em {this.NomeDoSite} e na liga {LigaEmExecucao}");
            this.ListaDePartidas.Clear();
            await this.PreencherListaDePartidas(link);
            foreach (Partida partida in this.ListaDePartidas)
            {
                await this.PreencherDetalhesDaPartida_RequestAsync(partida);
                await this.SalvarPartidaNoBanco(partida);
            }
        }
        catch (Exception ex)
        {
            this.SalvarLog($"Lançou erro no link: ${link} \n {ex.Message} \n {ex.InnerException.Message}");
        }
    }
}