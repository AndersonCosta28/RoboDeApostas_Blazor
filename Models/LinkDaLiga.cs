using System.ComponentModel.DataAnnotations;

namespace RoboDeApostas.Models
{
    public class LinkDaLiga
    {
        public int Id { get; set; }
        public int LigaId { get; set; }
        public Liga? Liga { get; set; } = null;
        [Required]
        public string CasaDeAposta { get; set; } = string.Empty;
        [Required]
        public string Link { get; set; } = string.Empty;
    }
}
