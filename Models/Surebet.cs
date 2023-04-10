using System.Composition;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RoboDeApostas.Models
{
    public class Surebet2Casas
    {
        public int Id { get; set; }
        public Partida PartidaDaCasa1;
        public Partida PartidaDaCasa2;
        public DateTime Data;
        public float Prob1;
        public float Prob2;
        public float Prob3;
        public float Prob4;
        public float Lucro;
    }

    public class Surebet3Casas
    {
        public int Id { get; set; }
        public Partida PartidaDaCasa1;
        public Partida PartidaDaCasa2;
        public Partida PartidaDaCasa3;
        public DateTime Data;
        public float Prob1;
        public float Prob2;
        public float Prob3;
        public float Prob4;
        public float Prob5;
        public float Prob6;
        public float Lucro;
    }
}
