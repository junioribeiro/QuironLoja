using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutosRepositorio _repositorio;
        private int produtoPorPagina = 3;
        // GET: Produto
        public ActionResult Index(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * produtoPorPagina)
                .Take(produtoPorPagina);       

            return View(produtos);
        }
    }
}