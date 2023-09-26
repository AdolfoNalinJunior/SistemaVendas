using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class ItemVenda
    {
        #region Campos
        public int Codigo { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
        public decimal Subtotal { get; set; }
        public int Quantidade { get; set; }
        #endregion
    }
}
