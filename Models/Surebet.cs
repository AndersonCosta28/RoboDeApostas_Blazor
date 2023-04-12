using System.Composition;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RoboDeApostas.Models
{
    public class Surebet2Casas
    {
        public int Id { get; set; }
        public Partida PartidaDaCasa1;
        public Partida PartidaDaCasa2;
        public DateTimeOffset Data;
        public double Prob1;
        public double Prob2;
        public double Prob3;
        public double Prob4;
        public double Lucro;
    }

    public class Surebet3Casas
    {
        public int Id { get; set; }
        public Partida PartidaDaCasa1;
        public Partida PartidaDaCasa2;
        public Partida PartidaDaCasa3;
        public DateTimeOffset Data;
        public double Prob1;
        public double Prob2;
        public double Prob3;
        public double Prob4;
        public double Prob5;
        public double Prob6;
        public double Lucro;
    }
}
