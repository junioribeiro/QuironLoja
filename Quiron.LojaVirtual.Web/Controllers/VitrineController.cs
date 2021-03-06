﻿using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        private int produtoPorPagina = 3;
        // GET: Produto
        public ViewResult ListarProdutos(string categoria, int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

            ProdutoViewModel model = new ProdutoViewModel
            {
                Produtos = _repositorio.Produtos
                .Where(p => p.Categoria == null || p.Categoria == categoria)
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * produtoPorPagina)
                .Take(produtoPorPagina),
                Paginacao = new Paginacao
                {
                    ItensPorPagina = produtoPorPagina,
                    PaginaAtual = pagina,
                    ItensTotal = _repositorio.Produtos.Count()
                },
                Categoria = categoria

            };

            return View(model);
        }
    }
}