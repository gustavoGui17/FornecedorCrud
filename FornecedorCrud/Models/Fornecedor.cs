﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FornecedorCrud.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {

        [Column("Id")]
        [Display(Name = "Codigo")]
        public int id { get; set; }

        [Column("Documento")]
        [Display(Name = "Docomento")]
        public string documento { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string email { get; set;}

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string senha { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string nome { get; set;}

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public String telefone { get; set; }
    }
}
