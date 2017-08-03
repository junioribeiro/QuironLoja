using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        /// <summary>
        /// Representa a quantidade de itens no banco
        /// </summary>
        public int ItensTotal { get; set; }

        /// <summary>
        /// Representa quantos itens eu quero por pagina
        /// </summary>
        public int ItensPorPagina { get; set; }

        /// <summary>
        /// Sinaliza a pagina atual para manipular css booststrap
        /// </summary>
        public int PaginaAtual { get; set; }

        /// <summary>
        /// Representa quantas paginas terá o grid *ceiling aredonda a divisão pra mais
        /// </summary>
        public int TotalPagina { get { return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina); } }
    }
}