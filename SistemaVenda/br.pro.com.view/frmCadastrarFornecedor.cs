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
    public partial class frmCadastrarFornecedor : Form
    {
        public frmCadastrarFornecedor()
        {
            InitializeComponent();
        }

        #region Load
        private void frmCadastrarFornecedor_Load(object sender, EventArgs e)
        {
            frmConsultarFornecedor cf = new frmConsultarFornecedor();

            FornecedorDAO obj = new FornecedorDAO();
            cf.dgFornecedor.DataSource = obj.ConsultarFornecedores();
        }

        #endregion

        #region ConsultaCEP_KeyPress
        /// <summary>
        /// Evento que pesquisa o cep após o click no enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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
                    MessageBox.Show($@"O CEP digitado não foi encontrado! Por favor, digite-o manualmente!");
                }
            }
        }
        #endregion

        #region BotãoNovo
        /// <summary>
        /// Evento que limpa todos os campos da tabCadastrarFornecedores, para receber um novo fornecedor
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
        /// Evento que salva o fornecedor no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedor cf = new frmConsultarFornecedor();

            Fornecedor obj = new Fornecedor();
            obj.Nome = txtNome.Text;
            obj.CNPJ = mtbCNPJ.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = mtbTelefone.Text;
            obj.Celular = mtbCelular.Text;
            obj.CEP = mtbCEP.Text;
            obj.Logradouro = txtLogradouro.Text;
            obj.Numero = Convert.ToInt16(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbUF.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dao.CadastrarFornecedor(obj);

            cf.dgFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion

        #region BotãoEditar
        /// <summary>
        /// Evento que edita o fornecedor no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedor cf = new frmConsultarFornecedor();

            Fornecedor obj = new Fornecedor();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nome = txtNome.Text;
            obj.CNPJ = mtbCNPJ.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = mtbTelefone.Text;
            obj.Celular = mtbCelular.Text;
            obj.CEP = mtbCEP.Text;
            obj.Logradouro = txtLogradouro.Text;
            obj.Numero = Convert.ToInt32(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbUF.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dao.EditarFornecedor(obj);

            cf.dgFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion

        #region BotãoExcluir
        /// <summary>
        /// Evento que exclui o fornecedor do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedor cf = new frmConsultarFornecedor();

            Fornecedor obj = new Fornecedor();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.ExcluirFornecedor(obj);

            cf.dgFornecedor.DataSource = dao.ConsultarFornecedores();
        }
        #endregion
    }
}
