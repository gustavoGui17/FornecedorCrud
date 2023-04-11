using Microsoft.EntityFrameworkCore;
using FornecedorCrud.Models;

namespace FornecedorCrud.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Fornecedor> Fornecedor { get; set; } 

        public DbSet<FornecedorCrud.Models.Produto>? Produto { get; set; }

        public DbSet<FornecedorCrud.Models.Cliente>? Cliente { get; set; }
    }
}
