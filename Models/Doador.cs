using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColheitaSolidaria.Models
{
    [Table("Doador")]

    public class DoadorModel
    {
        [Key]
        public int cod_doador { get; set; } //vem de perfil
    }

}
