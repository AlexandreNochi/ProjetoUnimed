using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoUnimed.Models
{
    public class Plano
    {
        [Key, DatabaseGenerated (DatabaseGeneratedOption.Identity) ]
        public int Id { get; set; }
        
        [Required]
        public string NumeroCarterinha { get; set; }

        [Required]
        public string NomeDoPlano { get; set; }
    }
}