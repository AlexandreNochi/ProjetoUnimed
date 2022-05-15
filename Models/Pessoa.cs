using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoUnimed.Models
{
    public class Pessoa
    {
        [Key, DatabaseGenerated (DatabaseGeneratedOption.Identity) ]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required, StringLength(maximumLength: 11, MinimumLength = 11)]
        public string CPF { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }
        
        [Required]
        public string NomeDaMae { get; set; }
        
        #region Outras entidades
            
            [Required]
            public int EnderecoId { get; set; }

            [ForeignKey(nameof(EnderecoId))]
            public Endereco Endereco { get; set; }

            [Required]
            public int PlanoId { get; set; }
            
            [ForeignKey(nameof(PlanoId))]
            public Plano Plano { get; set; }
            
            public ICollection<Exame> Exames { get; set; }
            
        #endregion
    }
}