using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Quiron.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //  Produto/   Lista produtos de todas as categoria

            routes.MapRoute(
                name: null,
                url: "Produtos",
                defaults: new { controller = "Vitrine", action = "ListarProdutos", categoria = (string)null, pagina = 1 });

            //  Produto/Pagina2			Todas as categoria da pagina2

            routes.MapRoute(
               null,
               "Produtos/Pagina{pagina}",
                new
                {
                    controller = "Vitrine",
                    action = "ListarProdutos",
                    categoria = (string)null,
                    pagina = @"\d+"
                });


            //  Produtos/Futebol            Primeira pagina da categoria futebol

            routes.MapRoute(
                null,
                "Produtos/{categoria}",
                new { controller = "Vitrine", action = "ListarProdutos" });

            //  Produtos/Futebol/Pagina2	          pagina2 da categoria futebol

            routes.MapRoute(
                null,
                "Produtos/{categoria}/Pagina{pagina}",
                new
                {
                    controller = "Vitrine",
                    action = "ListarProdutos",
                    pagina = @"\d+"
                }

                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Vitrine", action = "ListarProdutos", id = UrlParameter.Optional }
            );
        }
    }
}
