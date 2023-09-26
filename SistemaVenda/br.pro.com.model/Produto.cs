using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Produto
    {
        #region Campos
        /// <summary>
        /// Campos da classe Produtos
        /// </summary>
        public int Codigo { get; set; }
        public string DescricaoResumida { get; set; }
        public string DescricaoCompleta { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal PrecoVista { get; set; }
        public decimal PrecoPrazo { get; set; }
        public int CodigoFornecedor { get; set; }
        public string UniMedida{ get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public byte Imagem { get; set; }
        public string NumeroNFe { get; set; }
        #endregion
    }
}
