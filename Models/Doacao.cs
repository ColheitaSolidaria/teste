using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColheitaSolidaria.Models
{
    [Table("Doacao")]

    public class DoacaoModel
    {
        [Key] // tipo chave
        public int cod_doacao { get; set; }

        // tipo chave
        public int cod_recebedor { get; set; }

        // tipo chave
        public int cod_doador { get; set; }

        [MaxLength(50)]
        public string tipo { get; set; }

        public DateTime data_validade { get; set; }

        [MaxLength(100)]
        public string descricao { get; set; }

    }
}
