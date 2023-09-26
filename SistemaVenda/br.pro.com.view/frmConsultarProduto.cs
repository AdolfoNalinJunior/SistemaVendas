using SistemaVenda.br.pro.com.dao;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmConsultarProduto : Form
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
        }

        #region Campos
        
        #endregion

        #region dgProduto_KeyPress
        /// <summary>
        /// Evento que pega os dados do obj e passa para o tabCadastrarProduto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgProduto_DoubleClick(object sender, EventArgs e)
        {
            frmCadastrarProduto cp = new frmCadastrarProduto();

            cp.txtCodigo.Text = dgProduto.CurrentRow.Cells[0].Value.ToString();
            cp.txtDescricaoResumida.Text = dgProduto.CurrentRow.Cells[1].Value.ToString();
            cp.mtbPrecoVista.Text = dgProduto.CurrentRow.Cells[2].Value.ToString();
            cp.mtbPrecoPrazo.Text = dgProduto.CurrentRow.Cells[3].Value.ToString();
            cp.txtQuantidade.Text = dgProduto.CurrentRow.Cells[4].Value.ToString();
            cp.cbFornecedor.Text = dgProduto.CurrentRow.Cells[5].Value.ToString();
            
            cp.ShowDialog();
        }
        #endregion

        #region txtNome_KeyPress
        /// <summary>
        /// Evento que atualiza os dados que são digitados pelo usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            string descricao = "%" + txtNome.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();
            dgProduto.DataSource = dao.ListarProdutoNome(descricao);

            if (dgProduto.Rows.Count == 0 || txtNome.Text == String.Empty)
            {
                dgProduto.DataSource = dao.ConsultarProdutos();
            }
        }
        #endregion

        private void frmConsultarProduto_Load(object sender, EventArgs e)
        {

        }

        
    }
}
