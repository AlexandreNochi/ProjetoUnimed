using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoUnimed.Models
{
    public class Exame
    {
        [Key, DatabaseGenerated (DatabaseGeneratedOption.Identity) ]
        public int Id { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public string Responsavel { get; set; } 

        [Required]
        public string Nome { get; set; }
        
        [Required]
        public string Procedimento { get; set; }
    }
}