using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColheitaSolidaria.Models
{
    [Table("Recebedor")]

    public class RecebedorModel
    {
        [Key]
        public int cod_recebedor { get; set; } //vem de perfil

        public int n_familiar { get; set; }

    }

}
