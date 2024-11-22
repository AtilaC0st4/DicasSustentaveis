using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DicasSustentaveisGS1.Models
{
    public class FrasePreferida
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("FraseId")]
        public int FraseId { get; set; }

        [Required]
        public Frase Frase { get; set; }


    }
}
