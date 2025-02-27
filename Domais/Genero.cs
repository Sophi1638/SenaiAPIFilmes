using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_filmes_senai.Domais
{
    public class Genero

    {
        [Key]
    
        public Guid IdGenero { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "Nomde do genro é obrigatorio!")]
        public string? Nome { get; set; }
    }
}
