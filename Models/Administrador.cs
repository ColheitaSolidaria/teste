using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColheitaSolidaria.Models
{
    [Table("Administrador")]

    public class AdministradorModel
    {
        [Key] // tipo chave
        public int cod_adm { get; set; }

        [MaxLength(14)]
        public string CNPJ { get; set; }

        [MaxLength(50)]
        public string Senha { get; set; }

    }

}
