using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiron.LojaVirtual.Web.Models
{
    public class ProdutoViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }

        public Paginacao Paginacao { get; set; }

        public string Categoria { get; set; }
    }
}