using System.ComponentModel.DataAnnotations;

namespace RoboDeApostas.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public string NomeTimeDaCasa { get; set; } = "";
        public string NomeTimeVisitante { get; set; } = "";
        public string LinkDaPartida { get; set; } = "";
        public string Liga { get; set; } = "";
        public float ODD_Vitoria_TimeDaCasa { get; set; }
        public float ODD_Vitoria_TimeVisitante { get; set; }
        public float ODD_Empate_Ambos { get; set; }
        public float ODD_VitoriaOuEmpate_TimeCasa { get; set; }
        public float ODD_VitoriaOuEmpate_TimeVisitante { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DataCompleta { get; set; }
        public string Data { get {
                string dia = DataCompleta.Day < 10 ? "0" + DataCompleta.Day : DataCompleta.Day.ToString();
                string mes = DataCompleta.Month < 10 ? "0" + DataCompleta.Month : DataCompleta.Month.ToString();
                return $"{dia}/{mes}/{DataCompleta.Year}";
            } }
        public string Horario { get => $"{DataCompleta.Hour}:{DataCompleta.Minute}"; }
        public string NomeDaCasaDeAposta { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Criado_em => DateTime.Now;
        public Partida(string linkDaPartida, string liga, string nomeDaCasaDeAposta)
        {
            this.LinkDaPartida = linkDaPartida;
            this.ODD_Vitoria_TimeDaCasa = 0f;
            this.ODD_Vitoria_TimeVisitante = 0f;
            this.ODD_VitoriaOuEmpate_TimeCasa = 0f;
            this.ODD_VitoriaOuEmpate_TimeVisitante = 0f;
            this.ODD_Empate_Ambos = 0f;
            this.Liga = liga;
            this.NomeDaCasaDeAposta = nomeDaCasaDeAposta;
        }
        public Partida()
        {
            
        }
    }
}
