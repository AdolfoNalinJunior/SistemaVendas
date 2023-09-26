using SistemaVenda.br.pro.com.dao;
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
    public partial class frmConsultarFornecedor : Form
    {
        public frmConsultarFornecedor()
        {
            InitializeComponent();
        }

        #region Campos
        frmCadastrarFornecedor cf = new frmCadastrarFornecedor();
        #endregion

        #region dgFornecedor_KeyPress
        /// <summary>
        /// Evento que tranfere os dados do dgListarFornecedor para o tabCadastrarForcedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgFornecedor_DoubleClick(object sender, EventArgs e)
        {
            cf.txtCodigo.Text = dgFornecedor.CurrentRow.Cells[0].Value.ToString();
            cf.txtNome.Text = dgFornecedor.CurrentRow.Cells[1].Value.ToString();
            cf.mtbCNPJ.Text = dgFornecedor.CurrentRow.Cells[2].Value.ToString();
            cf.txtEmail.Text = dgFornecedor.CurrentRow.Cells[3].Value.ToString();
            cf.mtbTelefone.Text = dgFornecedor.CurrentRow.Cells[4].Value.ToString();
            cf.mtbCelular.Text = dgFornecedor.CurrentRow.Cells[5].Value.ToString();
            cf.mtbCEP.Text = dgFornecedor.CurrentRow.Cells[6].Value.ToString();
            cf.txtLogradouro.Text = dgFornecedor.CurrentRow.Cells[7].Value.ToString();
            cf.txtNumero.Text = dgFornecedor.CurrentRow.Cells[8].Value.ToString();
            cf.txtComplemento.Text = dgFornecedor.CurrentRow.Cells[9].Value.ToString();
            cf.txtBairro.Text = dgFornecedor.CurrentRow.Cells[10].Value.ToString();
            cf.txtCidade.Text = dgFornecedor.CurrentRow.Cells[11].Value.ToString();
            cf.cbUF.Text = dgFornecedor.CurrentRow.Cells[12].Value.ToString();

            cf.ShowDialog();
        }
        #endregion

        #region BotãoPesquisar_KeyPress
        /// <summary>
        /// Evento que pesquisa o fornecedor de acordo com a digitação do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = '%' + txtNome.Text + '%';

            FornecedorDAO obj = new FornecedorDAO();
            dgFornecedor.DataSource = obj.ListarFornecedoresNome(nome);

            if (dgFornecedor.Rows.Count == 0 || txtNome.Text == String.Empty)
            {
                dgFornecedor.DataSource = obj.ConsultarFornecedores();
            }
        }
        #endregion

        private void frmConsultarFornecedor_Load(object sender, EventArgs e)
        {

        }

        
    }
}
