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
        private string CPF { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }
        
        [Required]
        private string NomeDaMae { get; set; }
        
        #region Outras entidades
            
            [Required]
            private int EnderecoId { get; set; }

            [ForeignKey(nameof(EnderecoId))]
            private Endereco Endereco { get; set; }

            [Required]
            public int PlanoId { get; set; }
            
            [ForeignKey(nameof(PlanoId))]
            private Plano Plano { get; set; }
            
            public ICollection<Exame> Exames { get; set; }
            
        #endregion
    }
}