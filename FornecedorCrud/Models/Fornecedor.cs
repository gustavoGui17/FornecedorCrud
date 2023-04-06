using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FornecedorCrud.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {

        [Column("Id")]
        [Display(Name = "Codigo")]
        public int FornecedorId { get; set; }

        [Column("Fornecedor_Cnpj")]
        [Display(Name = "Cnpj")]
        public string? FornecedorCnpj { get; set; }

        [Column("Fornecedor_Email")]
        [Display(Name = "Email")]
        public string? FornecedorEmail { get; set;}

        [Column("Fornecedor_Senha")]
        [Display(Name = "Senha")]
        public string? FornecedorSenha { get; set; }

        [Column("Fornecedor_Nome")]
        [Display(Name = "Nome")]
        public string? FornecedorName { get; set;}
    }
}
