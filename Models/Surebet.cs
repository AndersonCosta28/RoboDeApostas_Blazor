
namespace RoboDeApostas.Models
{
    public class Surebet2Casas
    {
        public int Id { get; set; }
        public Partida PartidaDaCasa1 { get; set; }
        public Partida PartidaDaCasa2 { get; set; }
        public DateTimeOffset Data { get; set; }
        public double Prob1 { get; set; }
        public double Prob2 { get; set; }
        public double Prob3 { get; set; }
        public double Prob4 { get; set; }
        public double Lucro { get; set; }
    }

    public class Surebet3Casas
    {
        public int Id { get; set; }
        public Partida PartidaDaCasa1 { get; set; }
        public Partida PartidaDaCasa2 { get; set; }
        public Partida PartidaDaCasa3 { get; set; }
        public DateTimeOffset Data { get; set; }
        public double Prob1 { get; set; }
        public double Prob2 { get; set; }
        public double Prob3 { get; set; }
        public double Prob4 { get; set; }
        public double Prob5 { get; set; }
        public double Prob6 { get; set; }
        public double Lucro { get; set; }
    }
}
