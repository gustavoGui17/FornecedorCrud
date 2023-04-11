using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FornecedorCrud.Models
{
    [Table("Produto")]
    public class Produto
    {

        [Column("Id")]
        [Display(Name = "Codigo")]
        public int id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Column("Valor")]
        [Display(Name = "Valor")]
        public int valor { get; set; }

    }
}
