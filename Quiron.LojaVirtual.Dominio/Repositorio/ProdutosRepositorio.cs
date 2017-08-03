using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    /// <summary>
    /// Classe como se Fosse a Camada BLL com inteligencia de negocio 
    /// </summary>
    public class ProdutosRepositorio
    {
        /// <summary>
        /// variavel que manipula os dados do banco acessando o DbSet
        /// </summary>
        private readonly EfDbContext _context = new EfDbContext();

        /// <summary>
        /// Propriedade da classe ProdutosRepositorio que Lista todos os produtos
        /// </summary>
        public IEnumerable<Produto> Produtos { get { return _context.Produtos; } }
    }
}
