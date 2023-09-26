using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Venda
    {
        #region Campos da classe
        /// <summary>
        /// Campos da calsse
        /// </summary>
        public int Codigo { get; set; }
        public int CodigoCliente { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public decimal TotalVenda { get; set; }
        public string Observacao { get; set; }
        #endregion
    }
}
