using RoboDeApostas.Models.CasasDeAposta;

namespace RoboDeApostas
{
    public static class InicializadorDeValores
    {
        public static void Bet365()
        {
            {
                using var db = new DatabaseContext();
                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_LigaDosCampeoes).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E79147586/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_Libertadores).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85780589/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Inglaterra_PremierLeague).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E76169570/G40/H^1/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E76473591/G40/H^1/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_Bundesliga).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E76469135/G40/H^1/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieA).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E76509991/G40/H^1/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue1).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E76468858/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Colombia_Primera_A).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E26331167/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Mexico_MX).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E83937487/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.EUA_MajorLeagueSoccer).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E84854676/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_SulAmericana).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E88156539/G40/H^1/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_DFBPokal).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E87835190/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_CopaDelRey).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E83756156/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_CoppaItalia).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E84659091/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_PrimeiraLiga).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E83376269/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_2Bundesliga).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E76947587/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_3Liga).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E76947633/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieB).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E77423349/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieD).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E79320847/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraDivison).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E84855132/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraNacional).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85703530/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Bolivia_DivisionProfesional).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E88048552/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_CoupeDeFrance).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E87834881/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue2).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E83374192/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_National).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E77817255/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga2).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E76947668/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_ALeague).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E78975603/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplNSW).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85724828/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplQueensland).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294051/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85742801/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_WesternPremierLeague).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E87270813/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_SouthPremierLeague).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85742770/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoriaPremierLeague2).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85742819/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoriaPremierLeague3).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E87268254/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_QueenslandPreimierLeague2).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294086/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria_Female).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E87268303/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NorthernNswPremierLeague).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294159/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_QueenslandPremierLeague1_Sub23).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294133/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NSWPremierLeague_Sub20).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85704033/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria_Sub21).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85742821/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NSWLeague1_Sub20).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85724836/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NorthernNSWLeague1).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E86294162/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_Brasileirao_Sub20).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E86834272/G40/",
                    CasaDeAposta = "Bet365"
                });

                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_AmistososFeminino).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E87626707/G40/",
                    CasaDeAposta = "Bet365"
                });


                db.LinkDaLiga.Add(new LinkDaLiga
                {
                    LigaId = db.Liga.Where(l => l.Nome == Ligas.Paraguai_PrimeraDivision).First().Id,
                    Link = "https://www.bet365.com/#/AC/B1/C1/D1002/E85440928/G40/",
                    CasaDeAposta = "Bet365"
                });
                db.SaveChanges();
            }
        }

        public static void Betway()
        {
            using var db = new DatabaseContext();

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_LigaDosCampeoes).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/european-cups/uefa-champions-league",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Inglaterra_PremierLeague).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/england/premier-league",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/spain/la-liga",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_Bundesliga).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/germany/bundesliga",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieA).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/italy/serie-a",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_LigaBrasileiraPaulista).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/brazil/paulista",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue1).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/france/ligue-1",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_Eredivisie).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/netherlands/eredivisie",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.CopaDasNacoesAfricanasEliminatorias).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/international/africa-cup-of-nations-qualifiers",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Colombia_Primera_A).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/colombia/primera-a",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Mexico_MX).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/mexico/liga-mx",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.EUA_MajorLeagueSoccer).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/usa/championship",
                CasaDeAposta = "Betway"
            });


            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_Libertadores).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/international-club/copa-libertadores",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_DFBPokal).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/germany/dfb-pokal",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_CopaDelRey).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/spain/copa-del-rey",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_CoppaItalia).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/italy/coppa-italia",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_PrimeiraLiga).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/portugal/primeira-liga",
                CasaDeAposta = "Betway"
            });


            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_SegundaLiga).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/portugal/segunda-liga",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_2Bundesliga).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/germany/2-bundesliga",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_3Liga).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/germany/3-liga",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_EersteDivisie).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/netherlands/eerste-divisie",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieB).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/italy/serie-b",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieC).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/italy/serie-c",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieD).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/italy/serie-d",
                CasaDeAposta = "Betway"
            });


            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraDivison).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/argentina/primera-division",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraNacional).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/argentina/primera-nacional",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_CoupeDeFrance).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/france/coupe-de-france",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue2).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/france/ligue-2",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_National).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/france/national",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga2).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/spain/la-liga-2",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_TerceraDivision).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/spain/tercera-division",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_ALeague).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/australia/a-league",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplNSW).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/australia/new-south-wales-premier-league",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplQueensland).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/australia/queensland-premier-league",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/australia/victoria-premier-league",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_WesternPremierLeague).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/australia/western-australia-premier-league",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_SouthPremierLeague).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/australia/south-australia-premier-league",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoriaPremierLeague2).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/australia/victoria-premier-league-2",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NorthernNswPremierLeague).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/australia/northern-nsw-premier-league",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_Brasileirao_Sub20).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/brazil/u20-matches",
                CasaDeAposta = "Betway"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_AmistososFeminino).First().Id,
                Link = "https://betway.com/pt/sports/grp/soccer/international/womens-matches",
                CasaDeAposta = "Betway"
            });


            db.SaveChanges();
        }

        public static void Betano()
        {
            using var db = new DatabaseContext();

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_LigaDosCampeoes).First().Id,
                Link = "https://br.betano.com/sport/futebol/liga-dos-campeoes/jogos/182748/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Inglaterra_PremierLeague).First().Id,
                Link = "https://br.betano.com/sport/futebol/inglaterra/premier-league/1/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga).First().Id,
                Link = "https://br.betano.com/sport/futebol/espanha/laliga/5/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_Bundesliga).First().Id,
                Link = "https://br.betano.com/sport/futebol/alemanha/bundesliga/216/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieA).First().Id,
                Link = "https://br.betano.com/sport/futebol/italia/serie-a/1635/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_LigaBrasileiraPaulista).First().Id,
                Link = "https://br.betano.com/sport/futebol/brasil/campeonato-paulista-serie-a1/16901/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue1).First().Id,
                Link = "https://br.betano.com/sport/futebol/franca/ligue-1/215/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_Eredivisie).First().Id,
                Link = "https://br.betano.com/sport/futebol/holanda/eredivisie/17067r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.CopaDasNacoesAfricanasEliminatorias).First().Id,
                Link = "https://br.betano.com/sport/futebol/caf/copa-das-nacoes-africanas-eliminatorias/191348/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_AmistososInternacionais).First().Id,
                Link = "https://br.betano.com/sport/futebol/internacional/jogos-amistosos/17026/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Colombia_Primera_A).First().Id,
                Link = "https://br.betano.com/sport/futebol/colombia/categoria-primera-a/16940r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Mexico_MX).First().Id,
                Link = "https://br.betano.com/sport/futebol/mexico/liga-mx/17264r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.EUA_MajorLeagueSoccer).First().Id,
                Link = "https://br.betano.com/sport/futebol/eua/mls/17103r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_Libertadores).First().Id,
                Link = "https://br.betano.com/sport/futebol/competicoes/copa-libertadores/189817/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_SulAmericana).First().Id,
                Link = "https://br.betano.com/sport/futebol/competicoes/copa-sul-americana/189818/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_CopaDelRey).First().Id,
                Link = "https://br.betano.com/sport/futebol/espanha/copa-do-rei/10067/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_CoppaItalia).First().Id,
                Link = "https://br.betano.com/sport/futebol/italia/copa-de-italia/10815/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_PrimeiraLiga).First().Id,
                Link = "https://br.betano.com/sport/futebol/portugal/primeira-liga/17083/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_SegundaLiga).First().Id,
                Link = "https://br.betano.com/sport/futebol/portugal/liga-2/17385r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_TerceiraLiga).First().Id,
                Link = "https://br.betano.com/sport/futebol/portugal/liga-3/197549r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_2Bundesliga).First().Id,
                Link = "https://br.betano.com/sport/futebol/alemanha/2-bundesliga/217r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_3Liga).First().Id,
                Link = "https://br.betano.com/sport/futebol/alemanha/3-liga/17313r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_EersteDivisie).First().Id,
                Link = "https://br.betano.com/sport/futebol/holanda/eerste-divisie/17370/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieB).First().Id,
                Link = "https://br.betano.com/sport/futebol/italia/serie-b/10210r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieC).First().Id,
                Link = "https://br.betano.com/sport/futebol/italia/serie-c/17714r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieD).First().Id,
                Link = "https://br.betano.com/sport/futebol/italia/serie-d/15285r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraDivison).First().Id,
                Link = "https://br.betano.com/sport/futebol/argentina/liga-profesional/195785r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraNacional).First().Id,
                Link = "https://br.betano.com/sport/futebol/argentina/primera-b-nacional/17244/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Bolivia_DivisionProfesional).First().Id,
                Link = "https://br.betano.com/sport/futebol/bolivia/division-profesional/18274/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_CoupeDeFrance).First().Id,
                Link = "https://br.betano.com/sport/futebol/franca/coupe-de-france/11963/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue2).First().Id,
                Link = "https://br.betano.com/sport/futebol/franca/ligue-2/10467/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_National).First().Id,
                Link = "https://br.betano.com/sport/futebol/franca/national/11962/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga2).First().Id,
                Link = "https://br.betano.com/sport/futebol/espanha/segunda-division/10000/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_TerceraDivision).First().Id,
                Link = "https://br.betano.com/sport/futebol/espanha/tercera-division-rfef/17592/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_ALeague).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/a-league/16816/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplNSW).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-nsw-premier-league/17458/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplQueensland).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-queensland/189802/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-victoria/17360/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_WesternPremierLeague).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-western-australia/17499/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_SouthPremierLeague).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-south-australia/17318/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoriaPremierLeague2).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-2-victoria/186782/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoriaPremierLeague3).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-3-victoria/196380/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_QueenslandPreimierLeague2).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/queensland-premier-league-2/196366/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria_Female).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-victoria-f/199063/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NorthernNswPremierLeague).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-northern-nsw-premier-league/183992/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_QueenslandPremierLeague1_Sub23).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/queensland-premier-league-1-sub-23/196299/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NSWPremierLeague_Sub20).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-nsw-premier-league-sub-20/17543/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria_Sub21).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/npl-victoria-sub-21/18206/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NSWLeague1_Sub20).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/nsw-league-one-sub-20/187778/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NorthernNSWLeague1).First().Id,
                Link = "https://br.betano.com/sport/futebol/australia/northern-nsw-league-one/18394/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_Brasileirao_Sub20).First().Id,
                Link = "https://br.betano.com/sport/futebol/brasil/campeonato-brasileiro-sub-20/184051r/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_BrasileiraoSerieA).First().Id,
                Link = "https://br.betano.com/sport/futebol/brasil/brasileirao-serie-a/10016/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_AmistososFeminino).First().Id,
                Link = "https://br.betano.com/sport/futebol/competicoes/internacional/11364/",
                CasaDeAposta = "Betano"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Paraguai_PrimeraDivision).First().Id,
                Link = "https://br.betano.com/sport/futebol/competicoes/paraguai/11379/",
                CasaDeAposta = "Betano"
            });


            db.SaveChanges();
        }

        public static void Betfair()
        {
            using var db = new DatabaseContext();

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_LigaDosCampeoes).First().Id,
                Link = "https://www.betfair.com/sport/football/uefa-champions-league/228",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Inglaterra_PremierLeague).First().Id,
                Link = "https://www.betfair.com/sport/football/inglaterra-premier-league/10932509",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga).First().Id,
                Link = "https://www.betfair.com/sport/football/espanha-la-liga/117",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_Bundesliga).First().Id,
                Link = "https://www.betfair.com/sport/football/bundesliga-alem%C3%A3/59",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieA).First().Id,
                Link = "https://www.betfair.com/sport/football/it%C3%A1lia-s%C3%A9rie-a/81",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_LigaBrasileiraPaulista).First().Id,
                Link = "https://www.betfair.com/sport/football/brasil-paulista-serie-a1/2490975",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue1).First().Id,
                Link = "https://www.betfair.com/sport/football/fran%C3%A7a-ligue-1/55",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_Eredivisie).First().Id,
                Link = "https://www.betfair.com/sport/football/holanda-eredivisie/9404054",
                CasaDeAposta = "Betfair"
            });


            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_AmistososInternacionais).First().Id,
                Link = "https://www.betfair.com/sport/football/amistosos-internacionais/12205166",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Colombia_Primera_A).First().Id,
                Link = "https://www.betfair.com/sport/football/colombian-primera-a/844197",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Mexico_MX).First().Id,
                Link = "https://www.betfair.com/sport/football/mexican-liga-mx/5627174",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.EUA_MajorLeagueSoccer).First().Id,
                Link = "https://www.betfair.com/sport/football/eua-mls/141",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_Libertadores).First().Id,
                Link = "https://www.betfair.com/sport/football/conmebol-copa-libertadores/12147796",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_SulAmericana).First().Id,
                Link = "https://www.betfair.com/sport/football/conmebol-copa-sul-americana/12204604",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_DFBPokal).First().Id,
                Link = "https://www.betfair.com/sport/football/copa-da-alemanha/11458113",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_CopaDelRey).First().Id,
                Link = "https://www.betfair.com/sport/football/espanha-copa-do-rei/12801",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_CoppaItalia).First().Id,
                Link = "https://www.betfair.com/sport/football/copa-da-it%C3%A1lia/12214429",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_PrimeiraLiga).First().Id,
                Link = "https://www.betfair.com/sport/football/portugal-primeira-liga/99",
                CasaDeAposta = "Betfair"
            });




            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_SegundaLiga).First().Id,
                Link = "https://www.betfair.com/sport/football/portuguese-segunda-liga/9513",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_2Bundesliga).First().Id,
                Link = "https://www.betfair.com/sport/football/alemanha-bundesliga-2/61",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_3Liga).First().Id,
                Link = "https://www.betfair.com/sport/football/alemanha-3-liga/11591693",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_EersteDivisie).First().Id,
                Link = "https://www.betfair.com/sport/football/holanda-eerste-divisie/11",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieB).First().Id,
                Link = "https://www.betfair.com/sport/football/it%C3%A1lia-s%C3%A9rie-b/12199689",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieC).First().Id,
                Link = "https://www.betfair.com/sport/football/it%C3%A1lia-s%C3%A9rie-c/12199513",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieD).First().Id,
                Link = "https://www.betfair.com/sport/football/it%C3%A1lia-serie-d/7210007",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraDivison).First().Id,
                Link = "https://www.betfair.com/sport/football/primera-division-da-argentina/67387",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraNacional).First().Id,
                Link = "https://www.betfair.com/sport/football/divis%C3%A3o-2-da-argentina/803237",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_CoupeDeFrance).First().Id,
                Link = "https://www.betfair.com/sport/football/copa-da-fran%C3%A7a/12209560",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue2).First().Id,
                Link = "https://www.betfair.com/sport/football/fran%C3%A7a-ligue-2/57",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_National).First().Id,
                Link = "https://www.betfair.com/sport/football/fran%C3%A7a-national/1081960",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga2).First().Id,
                Link = "https://www.betfair.com/sport/football/espanha-segunda-divis%C3%A3o/12204313",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_TerceraDivision).First().Id,
                Link = "https://www.betfair.com/sport/football/espanha-tercera-division/821269",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_ALeague).First().Id,
                Link = "https://www.betfair.com/sport/football/australian-a-league-men/12117172",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplNSW).First().Id,
                Link = "https://www.betfair.com/sport/football/australian-npl-nsw/12006346",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplQueensland).First().Id,
                Link = "https://www.betfair.com/sport/football/austr%C3%A1lia-npl-queensland/12006772",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria).First().Id,
                Link = "https://www.betfair.com/sport/football/australian-npl-victoria/12006103",
                CasaDeAposta = "Betfair"
            });


            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_Brasileirao_Sub20).First().Id,
                Link = "https://www.betfair.com/sport/football/brasil-sub20/12148223",
                CasaDeAposta = "Betfair"
            });



            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_AmistososFeminino).First().Id,
                Link = "https://www.betfair.com/sport/football/amistosos-internacionais-f/12200369",
                CasaDeAposta = "Betfair"
            });


            db.SaveChanges();
        }

        public static void SportingBet()
        {
            using var db = new DatabaseContext();

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_LigaDosCampeoes).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/europa-7/liga-dos-campe%C3%B5es-0:3",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Inglaterra_PremierLeague).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/inglaterra-14/premier-league-102841",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/espanha-28/laliga-102829",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_Bundesliga).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/alemanha-17/bundesliga-102842",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieA).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/it%C3%A1lia-20/s%C3%A9rie-a-102846",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue1).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/fran%C3%A7a-16/ligue-1-102843",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_Eredivisie).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/holanda-36",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.CopaDasNacoesAfricanasEliminatorias).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/%C3%A1frica-11/copa-africana-de-na%C3%A7%C3%B5es-eliminat%C3%B3rias-103058",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_AmistososInternacionais).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/mundo-6/amistosos-internacionais-102897",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Colombia_Primera_A).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/col%C3%B4mbia-45/primera-a-apertura-102161",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Mexico_MX).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/m%C3%A9xico-43/liga-mx-clausura-102375",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.EUA_MajorLeagueSoccer).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/am%C3%A9rica-do-norte-9/major-league-soccer-102849",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_Libertadores).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/am%C3%A9rica-do-sul-42/conmebol-libertadores-102827",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_SulAmericana).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/am%C3%A9rica-do-sul-42/conmebol-sudamericana-102696",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_DFBPokal).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/alemanha-17/copa-da-alemanha-102809",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_CopaDelRey).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/espanha-28/copa-do-rei-102728",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_CoppaItalia).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/it%C3%A1lia-20/copa-da-it%C3%A1lia-102811",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_PrimeiraLiga).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/portugal-37/primeira-liga-102851",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_SegundaLiga).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/portugal-37/liga-portugal-2-102206",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_2Bundesliga).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/alemanha-17/2-bundesliga-102845",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_3Liga).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/alemanha-17/3%C2%AA-liga-102377",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_EersteDivisie).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/holanda-36/segunda-divis%C3%A3o-holanda-102254",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieB).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/it%C3%A1lia-20/s%C3%A9rie-b-102848",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraDivison).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/argentina-38/primera-divisi%C3%B3n-102540",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraNacional).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/argentina-38/primera-nacional-102234",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Bolivia_DivisionProfesional).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/bol%C3%ADvia-44/divisi%C3%B3n-profesional-102510",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_CoupeDeFrance).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/fran%C3%A7a-16/copa-da-fran%C3%A7a-102808",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue2).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/fran%C3%A7a-16/ligue-2-102376",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_National).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/fran%C3%A7a-16/national-101523",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga2).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/espanha-28/laliga-2-102830",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_ALeague).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/a-league-2068",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplNSW).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/npl-new-south-wales-101878",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplQueensland).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/queensland-npl-101879",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/victoria-npl-1-101871",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_WesternPremierLeague).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/western-australia-npl-101882",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_SouthPremierLeague).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/south-australia-npl-101881",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NorthernNswPremierLeague).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/austr%C3%A1lia-60/northern-nsw-npl-101877",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_Brasileirao_Sub20).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/brasil-33/campeonato-brasileiro-sub-20-102135",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_BrasileiraoSerieA).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/brasil-33/brasileir%C3%A3o-s%C3%A9rie-a-102838",
                CasaDeAposta = "Sporting Bet"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_AmistososFeminino).First().Id,
                Link = "https://sports.sportingbet.com/pt-br/sports/futebol-4/aposta/mundo-6/amistosos-internacionais-feminino-102932",
                CasaDeAposta = "Sporting Bet"
            });

            db.SaveChanges();
        }

        public static void SportsBetIo()
        {
            using var db = new DatabaseContext();
            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_LigaDosCampeoes).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/international-clubs/uefa-champions-league/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_Libertadores).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/international-clubs/copa-libertadores/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Inglaterra_PremierLeague).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/england/premier-league/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/spain/la-liga/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_Bundesliga).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/germany/bundesliga/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieA).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/italy/serie-a/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue1).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/france/ligue-1/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Colombia_Primera_A).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/colombia/primera-a-apertura/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Mexico_MX).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/mexico/matches/future",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.EUA_MajorLeagueSoccer).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/usa/matches/future",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_SulAmericana).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/international-clubs/copa-sudamericana/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_DFBPokal).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/germany/dfb-pokal/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_CopaDelRey).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/spain/matches/future",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_CoppaItalia).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/italy/coppa-italia/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_PrimeiraLiga).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/portugal/primeira-liga/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_Eredivisie).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/netherlands/eredivisie/matches",
                CasaDeAposta = "Sportsbet.io"
            });


            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Portugal_SegundaLiga).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/portugal/segunda-liga/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_2Bundesliga).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/germany/2nd-bundesliga/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Alemanha_3Liga).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/germany/3rd-liga/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Holanda_EersteDivisie).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/netherlands/eerste-divisie/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieB).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/italy/serie-b/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieC).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/italy/serie-c/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Italia_SerieD).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/italy/serie-d/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraDivison).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/argentina/superliga/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Argentina_PrimeraNacional).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/argentina/primera-nacional/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_CoupeDeFrance).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/france/coupe-de-france/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_Ligue2).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/france/ligue-2/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Franca_National).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/france/national/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Espanha_LaLiga2).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/spain/la-liga-2/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_ALeague).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/australia/a-league/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplNSW).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/australia/npl-new-south-wales/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplQueensland).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/australia/npl-queensland/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NplVictoria).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/australia/npl-victoria/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_WesternPremierLeague).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/australia/npl-western-australia/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_SouthPremierLeague).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/australia/npl-south-australia/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Australia_NorthernNswPremierLeague).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/australia/npl-northern-new-south/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Brasil_Brasileirao_Sub20).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/brazil/u-20-campeonato-brasileiro/matches",
                CasaDeAposta = "Sportsbet.io"
            });

            db.LinkDaLiga.Add(new LinkDaLiga
            {
                LigaId = db.Liga.Where(l => l.Nome == Ligas.Internacional_AmistososFeminino).First().Id,
                Link = "https://sportsbet.io/pt/sports/soccer/international/national-friendlies-women/matches",
                CasaDeAposta = "Sportsbet.io"
            });


            db.SaveChanges();
        }
    
        public static void Liga() {
            using var db = new DatabaseContext();            
            db.Liga.Add(new Liga{ Nome = "Italia - Série A"});
            db.Liga.Add(new Liga{ Nome = "Italia - Série B"});
            db.Liga.Add(new Liga{ Nome = "Italia - Série C"});
            db.Liga.Add(new Liga{ Nome = "Italia - Série D"});
            db.Liga.Add(new Liga{ Nome = "Italia - Coppa Italia"});
            db.Liga.Add(new Liga{ Nome = "Alemanha - Bundesliga"});
            db.Liga.Add(new Liga{ Nome = "Alemanha - DFB Pokal"});
            db.Liga.Add(new Liga{ Nome = "Alemanha - 2 Bundesliga"});
            db.Liga.Add(new Liga{ Nome = "Alemanha - 3 Liga"});
            db.Liga.Add(new Liga{ Nome = "Espanha - LaLiga"});
            db.Liga.Add(new Liga{ Nome = "Espanha - Copa Del Rey"});
            db.Liga.Add(new Liga{ Nome = "Espanha - LaLiga 2"});
            db.Liga.Add(new Liga{ Nome = "Espanha - Tercera Division"});
            db.Liga.Add(new Liga{ Nome = "Internacional - Liga dos Campeões"});
            db.Liga.Add(new Liga{ Nome = "Internacional - Libertadores"});
            db.Liga.Add(new Liga{ Nome = "Internacional - Eurocopa 2024"});
            db.Liga.Add(new Liga{ Nome = "Internacional - Amistosos internacionais"});
            db.Liga.Add(new Liga{ Nome = "Internacional - Sul Americana"});
            db.Liga.Add(new Liga{ Nome = "Internacional - Amistosos Feminino"});
            db.Liga.Add(new Liga{ Nome = "Portugal - Primeira Liga"});
            db.Liga.Add(new Liga{ Nome = "Portugal - Segunda Liga"});
            db.Liga.Add(new Liga{ Nome = "Portugal - Terceira Liga"});
            db.Liga.Add(new Liga{ Nome = "Holanda - Eredivisie"});
            db.Liga.Add(new Liga{ Nome = "Holanda - EersteDivisie"});
            db.Liga.Add(new Liga{ Nome = "Argentina - Primera Divison"});
            db.Liga.Add(new Liga{ Nome = "Argentina - Primera Nacional"});
            db.Liga.Add(new Liga{ Nome = "Bolivia - Division Profesional"});
            db.Liga.Add(new Liga{ Nome = "Franca - Coupe de France"});
            db.Liga.Add(new Liga{ Nome = "Franca - National"});
            db.Liga.Add(new Liga{ Nome = "Franca - Ligue 1"});
            db.Liga.Add(new Liga{ Nome = "Franca - Ligue 2"});
            db.Liga.Add(new Liga{ Nome = "Australia - A-League"});
            db.Liga.Add(new Liga{ Nome = "Australia - Npl NSW"});
            db.Liga.Add(new Liga{ Nome = "Australia - Npl Queensland"});
            db.Liga.Add(new Liga{ Nome = "Australia - Npl Victoria"});
            db.Liga.Add(new Liga{ Nome = "Australia - Western Premier League"});
            db.Liga.Add(new Liga{ Nome = "Australia - South Preimer League"});
            db.Liga.Add(new Liga{ Nome = "Australia - Npl Victoria Premier League 2"});
            db.Liga.Add(new Liga{ Nome = "Australia - Npl Victoria Premier League 3"});
            db.Liga.Add(new Liga{ Nome = "Australia - Queensland Preimier League 2"});
            db.Liga.Add(new Liga{ Nome = "Australia - Npl Victoria Female"});
            db.Liga.Add(new Liga{ Nome = "Australia - Northern Nsw Premier League"});
            db.Liga.Add(new Liga{ Nome = "Australia - Queensland Premier League 1 Sub23"});
            db.Liga.Add(new Liga{ Nome = "Australia - NSW Premier League Sub20"});
            db.Liga.Add(new Liga{ Nome = "Australia - Npl Victoria Sub 21"});
            db.Liga.Add(new Liga{ Nome = "Australia - NSW League 1 Sub20"});
            db.Liga.Add(new Liga{ Nome = "Australia - Northern NSW League 1"});
            db.Liga.Add(new Liga{ Nome = "Brasil - Copa do Brasil"});
            db.Liga.Add(new Liga{ Nome = "Brasil - Brasileirao Sub20"});
            db.Liga.Add(new Liga{ Nome = "Brasil - Brasileirao Serie A"});
            db.Liga.Add(new Liga{ Nome = "Inglaterra - Premier League"});
            db.Liga.Add(new Liga{ Nome = "Brasil - Liga Brasileira Paulista"});
            db.Liga.Add(new Liga{ Nome = "Copa das nacoes africanas eliminatorias"});
            db.Liga.Add(new Liga{ Nome = "Colombia Primera - Primera A"});
            db.Liga.Add(new Liga{ Nome = "Mexico - MX"});
            db.Liga.Add(new Liga{ Nome = "EUA - Major League Soccer"});
            db.Liga.Add(new Liga{ Nome = "Paraguai - Primera Division"});
            db.SaveChanges();            
        }
    }
}
