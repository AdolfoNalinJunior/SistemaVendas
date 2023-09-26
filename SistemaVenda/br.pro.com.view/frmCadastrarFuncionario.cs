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
    public partial class frmCadastrarFuncionario : Form
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        #region Load
        private void frmCadastarFuncionario_Load(object sender, EventArgs e)
        {
            frmConsultarFuncionario cf = new frmConsultarFuncionario();
            FuncionarioDAO obj = new FuncionarioDAO();
            cf.dgFuncionario.DataSource = obj.ConsultarFuncionario();
        }
        #endregion

        #region BotãoNovo
        /// <summary>
        /// Evento que limpa o tabCadastrarFuncionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
        #endregion

        #region BotãoSalvar
        /// <summary>
        /// Evento Salvar obj no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario cf = new frmConsultarFuncionario();
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = txtNome.Text;
            funcionario.RG = mtbRG.Text;
            funcionario.CPF = mtbCPF.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Cargo = cbCargo.Text;
            funcionario.NivelAcesso = cbNivelAcesso.Text;
            funcionario.Telefone = mtbTelefone.Text;
            funcionario.Celular = mtbCelular.Text;
            funcionario.CEP = mtbCEP.Text;
            funcionario.Logradouro = txtLogradouro.Text;
            funcionario.Numero = Convert.ToInt32(txtNumero.Text);
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Estado = cbUF.Text;

            FuncionarioDAO objDao = new FuncionarioDAO();
            objDao.CadastrarFuncionario(funcionario);

            cf.dgFuncionario.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        #region BotãoExcluir
        /// <summary>
        /// Evento que exclui o obj do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario cf = new frmConsultarFuncionario();
            Funcionario obj = new Funcionario();
            obj.Codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO objDao = new FuncionarioDAO();
            objDao.ExcluirFuncionario(obj);

            cf.dgFuncionario.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        #region BotãoEditar
        /// <summary>
        /// Evento que edita um obj no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario cf = new frmConsultarFuncionario();
            Funcionario funcionario = new Funcionario();

            funcionario.Codigo = int.Parse(txtCodigo.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.RG = mtbRG.Text;
            funcionario.CPF = mtbCPF.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Cargo = cbCargo.Text;
            funcionario.NivelAcesso = cbNivelAcesso.Text;
            funcionario.Telefone = mtbTelefone.Text;
            funcionario.Celular = mtbCelular.Text;
            funcionario.CEP = mtbCEP.Text;
            funcionario.Logradouro = txtLogradouro.Text;
            funcionario.Numero = Convert.ToInt32(txtNumero.Text);
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Estado = cbUF.Text;

            FuncionarioDAO objDao = new FuncionarioDAO();
            objDao.EditarFuncionario(funcionario);

            cf.dgFuncionario.DataSource = objDao.ConsultarFuncionario();
        }
        #endregion

        #region CEP_KeyPress
        /// <summary>
        /// Evento que atualiza o DataGrid de acordo com o que o usuário digita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                try
                {
                    string cep = mtbCEP.Text;
                    string xmlUrl = "https://viacep.com.br/ws/" + cep + "/xml";
                    DataSet dado = new DataSet();
                    dado.ReadXml(xmlUrl);

                    txtLogradouro.Text = dado.Tables[0].Rows[0]["logradouro"].ToString();
                    txtBairro.Text = dado.Tables[0].Rows[0]["bairro"].ToString();
                    txtCidade.Text = dado.Tables[0].Rows[0]["localidade"].ToString();
                    txtComplemento.Text = dado.Tables[0].Rows[0]["complemento"].ToString();
                    cbUF.Text = dado.Tables[0].Rows[0]["uf"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Endereço não encontrado. Por favor digite manualmente!");
                }
            }
        }
        #endregion

        private void mtbCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}   
