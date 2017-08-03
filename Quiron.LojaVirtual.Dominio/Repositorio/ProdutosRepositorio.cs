using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        /// <summary>
        /// variavel que manipula os dados do banco acessando o DbSet
        /// </summary>
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos { get { return _context.Produtos; } }
    }
}
