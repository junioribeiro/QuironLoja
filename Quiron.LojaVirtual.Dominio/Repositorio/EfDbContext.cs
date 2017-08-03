using Quiron.LojaVirtual.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    /// <summary>
    /// Classe como se Fosse a camada DAL de Acesso Direto ao Banco
    /// </summary>
    public class EfDbContext : DbContext
    {
        /// <summary>
        /// Propriedade que retorna um lista de todos produtos na base
        /// </summary>
        public DbSet<Produto> Produtos { get; set; }

        /// <summary>
        /// Alterando o Padrão de Nomeclatura do Entity
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //tirando a conversão de nomes padrão do banco EX: produtoes
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //informando ao bamco o padrão de nome da nova tabela
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
