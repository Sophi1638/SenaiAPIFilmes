using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_filmes_senai.Domais
{
    [Table("Filme")]
    public class Filme
    {
        [Key]
        public Guid IdFIlme { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O titulo do filme e obrigatorio")]
        public string? Titulo { get; set; }

        /// <summary>
        /// Referencia da tabela genero 
        /// </summary>
        public Guid IdGenero { get; set; }

        [ForeignKey ("IdGenero")]
        public Genero? Genero { get; set; }
    }
}
