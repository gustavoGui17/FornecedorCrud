using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FornecedorCrud.Models
{
    [Table("Cliente")]
    public class Cliente
    {

        [Column("Id")]
        [Display(Name = "Codigo")]
        public int id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Column("Documento")]
        [Display(Name = "Docomento")]
        public string documento { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string senha { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public String? telefone { get; set; }

    }
}
