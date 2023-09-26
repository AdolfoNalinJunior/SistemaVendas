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
    public partial class frmConsultarFuncionario : Form
    {
        public frmConsultarFuncionario()
        {
            InitializeComponent();
        }

        #region Campo
        frmCadastrarFuncionario cf = new frmCadastrarFuncionario();
        #endregion

        #region DataGridFuncionario
        /// <summary>
        /// Transfere todos os recursos para a dgFuncionario, para mostar todos os campos para o usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgFuncionario_DoubleClick(object sender, EventArgs e)
        {
            cf.txtCodigo.Text = dgFuncionario.CurrentRow.Cells[0].Value.ToString();
            cf.txtNome.Text = dgFuncionario.CurrentRow.Cells[1].Value.ToString();
            cf.mtbRG.Text = dgFuncionario.CurrentRow.Cells[2].Value.ToString();
            cf.mtbCPF.Text = dgFuncionario.CurrentRow.Cells[3].Value.ToString();
            cf.txtEmail.Text = dgFuncionario.CurrentRow.Cells[4].Value.ToString();
            cf.txtSenha.Text = dgFuncionario.CurrentRow.Cells[5].Value.ToString();
            cf.cbCargo.Text = dgFuncionario.CurrentRow.Cells[6].Value.ToString();
            cf.cbNivelAcesso.Text = dgFuncionario.CurrentRow.Cells[7].Value.ToString();
            cf.mtbTelefone.Text = dgFuncionario.CurrentRow.Cells[8].Value.ToString();
            cf.mtbCelular.Text = dgFuncionario.CurrentRow.Cells[9].Value.ToString();
            cf.mtbCEP.Text = dgFuncionario.CurrentRow.Cells[10].Value.ToString();
            cf.txtLogradouro.Text = dgFuncionario.CurrentRow.Cells[11].Value.ToString();
            cf.txtNumero.Text = dgFuncionario.CurrentRow.Cells[12].Value.ToString();
            cf.txtComplemento.Text = dgFuncionario.CurrentRow.Cells[13].Value.ToString();
            cf.txtBairro.Text = dgFuncionario.CurrentRow.Cells[14].Value.ToString();
            cf.txtCidade.Text = dgFuncionario.CurrentRow.Cells[15].Value.ToString();
            cf.cbUF.Text = dgFuncionario.CurrentRow.Cells[16].Value.ToString();

            cf.ShowDialog();
        }
        #endregion

        #region Nome
        /// <summary>
        /// Permite carregar os em tempo real os funcionários filtrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string nome = '%' + txtNome.Text + '%';

                FuncionarioDAO dao = new FuncionarioDAO();

                dgFuncionario.DataSource = dao.BuscarFuncionarioNome(nome);

                if (dgFuncionario.Rows.Count == 0 || txtNome.Text == String.Empty)
                {
                    MessageBox.Show("Funcionário não encontrado! Certifique-se se o nome do Funcionário está cadastrado ou se está escrito corretamente!");
                    dgFuncionario.DataSource = dao.ConsultarFuncionario();
                }
            }
        }
        #endregion

        private void dgFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultarFuncionario_Load(object sender, EventArgs e)
        {

        }

        
    }
}
