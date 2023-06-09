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
        try
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
            
            double RetornarOdd(List<string> titulos, string textoParaPesquisa){
                if (data == null) return 0;
                BetanoAPI.DetalheDaPartida.PurpleMarket? opcaoDeAposta = data.Markets.ToList().Find(m => titulos.Contains(m.Name));
                if (opcaoDeAposta == null) return 0;
                List<BetanoAPI.DetalheDaPartida.Selection> selections = opcaoDeAposta.Selections.ToList();
                BetanoAPI.DetalheDaPartida.Selection? selection = selections.Find(s => s.Name.Contains(textoParaPesquisa));
                if (selection == null) return 0;
                else return selection.Price ?? 0;
            }
            if (data.LiveNow ?? false)
            {
                return;
            }
            partida.ODD_Vitoria_TimeDaCasa = RetornarOdd(this.Titulo_ResultadoFinal, "1");
            partida.ODD_Empate_Ambos = RetornarOdd(this.Titulo_ResultadoFinal, "X");
            partida.ODD_Vitoria_TimeVisitante = RetornarOdd(this.Titulo_ResultadoFinal, "2");
            partida.ODD_VitoriaOuEmpate_TimeCasa = RetornarOdd(this.Titulo_ChanceDupla, "1X");
            partida.ODD_VitoriaOuEmpate_TimeVisitante = RetornarOdd(this.Titulo_ChanceDupla, "X2");
        }
        catch (Exception)
        {
            Console.WriteLine("Lan�ou erro daqui 2");
            throw;
        }
    }

    protected override async Task PreencherListaDePartidas(string link)
    {
        try
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
            if (String.IsNullOrEmpty(json)) return;
            else if (json[0] == '{')
            {
                var item = BetanoAPI.ListaDePartida.ResponseListaDePartida.FromJson(json);
                if (item.HomeTeam == null || item.AwayTeam == null) return;
                Partida partida = new(item.Url.ToString(), LigaEmExecucao, NomeDoSite)
                {
                    NomeTimeDaCasa = item.HomeTeam.Name,
                    NomeTimeVisitante = item.AwayTeam.Name,
                    LinkDaPartida = item.Url.ToString(),
                    DataCompleta = Funcoes.ConverterFusoHorario((DateTimeOffset)item.StartDate!)
                };
                this.ListaDePartidas.Add(partida);
            }
            else
            {
                var data = BetanoAPI.ListaDePartida.ResponseListaDePartida.FromJsonList(json);

                foreach (var item in data)
                {
                    Partida partida = new(item.Url.ToString(), LigaEmExecucao, NomeDoSite)
                    {
                        NomeTimeDaCasa = item.HomeTeam.Name,
                        NomeTimeVisitante = item.AwayTeam.Name,
                        LinkDaPartida = item.Url.ToString(),
                        DataCompleta = Funcoes.ConverterFusoHorario((DateTimeOffset)item.StartDate!)
                    };
                    if (partida.DataCompleta < DateTimeOffset.Now) continue;
                    ListaDePartidas.Add(partida);
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Lan�ou erro daqui 1");
            throw;
        }
    }

    public override async Task RodarPadraoAsync(string link)
    {
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
            SalvarLog($"Lan�ou erro no link: ${link} \n {ex.Message} \n {ex.InnerException.Message}");
        }
        finally
        {
            ListaDePartidas.Clear();
        }
    }
}