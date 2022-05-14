using System.ComponentModel.DataAnnotations;

namespace ProjetoUnimed.Models
{
    public class Exame
    {
        [Required]
        public DateTime Data { get; set; }

        [Required]
        public string Responsavel { get; set; }
        
        [Required]
        public string Nome { get; set; }

        public string Procedimento { get; set; }
    }
}