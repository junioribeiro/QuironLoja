using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private ProdutosRepositorio _repositorio;

        public PartialViewResult Menu(string categoria = null)
        {
            _repositorio = new ProdutosRepositorio();

            IEnumerable<string> categorias = _repositorio.Produtos
                .Select(c => c.Categoria)
                .Distinct()
                .OrderBy(c => c);
            ViewBag.CategoriaSelecionada = categoria;
            return PartialView(categorias);
        }
    }
}