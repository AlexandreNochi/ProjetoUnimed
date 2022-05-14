using System.ComponentModel.DataAnnotations;

namespace ProjetoUnimed.Models
{
    public class Pessoa
    {
        [Required, Key]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required]
        private string CPF { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [Required]
        private string NomeDaMae { get; set; }

        [Required]
        private Endereco Endereco { get; set; }
    }
}