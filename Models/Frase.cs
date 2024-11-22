using System.ComponentModel.DataAnnotations;

namespace DicasSustentaveisGS1.Models
{
    public class Frase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Conteudo { get; set; }
    }
}
