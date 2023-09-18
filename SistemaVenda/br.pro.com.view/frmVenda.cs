using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.veiw
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        #region Variaveis da classe
        /// <summary>
        /// Variáveis de manipulação
        /// </summary>
        int quantidade = 0;
        int quantidadeTotal = 0;
        decimal preco = 0;
        decimal subtotal = 0;
        decimal total = 0;
        #endregion

        #region Objs
        ///// <summary>
        ///// Obj de manipulação
        ///// </summary>
        //Clientes clientes = new Clientes();
        //ClienteDAO cDao = new ClienteDAO();
        //DataTable carrinho = new DataTable();
        #endregion

        private void frmVenda_Load(object sender, EventArgs e)
        {
            //double num = 0.00;
            //txtSubtotal.Text = String.Format("{0:0.00}", num);
            //txtTotal.Text = String.Format("{0:0.00}", num);

            //carrinho.Columns.Add("Código", typeof(int));
            //carrinho.Columns.Add("Produto", typeof(string));
            //carrinho.Columns.Add("Quantidade", typeof(int));
            //carrinho.Columns.Add("Preço", typeof(decimal));
            //carrinho.Columns.Add("SubTotal", typeof(decimal));

            //dgVendas.DataSource = carrinho;

            //// Configuração da data
            ////mtbData.Text = String.Format(DateTime.Now.ToShortDateString(), "dd/mm/yyyy") ;
            //mtbHora.Text = DateTime.Now.ToShortTimeString();

            //mtbCPF.Focus();
        }

       
    }
}
