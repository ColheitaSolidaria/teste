using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColheitaSolidaria.Models
{
    [Table("Aprovacao")]

    public class AprovacaoModel
    {
        [Key] // tipo chave
        public int cod_doacao { get; set; }

         // tipo chave
        public int cod_adm { get; set; }
        public DateTime data_aprovacao { get; set; }

    }
}
