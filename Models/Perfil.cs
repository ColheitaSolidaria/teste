using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColheitaSolidaria.Models
{
    [Table("Perfil")]

    public class PerfilModel
    {
        [Key] // tipo chave
        public int cod { get; set; }

        [MaxLength(11)]
        public string CPF { get; set; }

        public DateTime data_nasc { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string telefone { get; set; }

        [MaxLength(225)]
        public string endereco { get; set; }


        [MaxLength(50)]
        public string Senha { get; set; }

    }


}
