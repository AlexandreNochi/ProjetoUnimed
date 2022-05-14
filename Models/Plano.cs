using System.ComponentModel.DataAnnotations;

namespace ProjetoUnimed.Models
{
    public class Plano
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public string NumeroCarterinha { get; set; }

        [Required]
        public string NomeDoPlano { get; set; }

        public List<Exame> Exames { get; set; }
    }
}