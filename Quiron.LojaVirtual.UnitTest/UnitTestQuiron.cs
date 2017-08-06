using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.Models;
using Quiron.LojaVirtual.Web.HtmlHelpers;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void testarSeAPaginaEstaSendoGeradoCorretamente()
        {
            //Arrange preparacao das variaveis que serao usadas
            // Preparação, seja de ambiente, variáveis, banco de dados, etc.

            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                ItensTotal = 30,
                ItensPorPagina = 10,
                PaginaAtual = 2
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            //Act representa ação que o teste ira realizar
            // Momento onde estimulamos o sistema sendo testado

            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            //Assert representa a verificação dos resultados
            // Verificarmos se os resultados obtidos batem com os resultados esperados

            Assert.AreEqual(

                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>",
                resultado.ToString());

        }
    }
}
