using SistemaVenda.br.pro.com.dao;
using SistemaVenda.br.pro.com.veiw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedor cf = new frmConsultarFornecedor();
            cf.dgFornecedor.DataSource = new FornecedorDAO().ConsultarFornecedores();
            cf.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastrarFornecedor cf = new frmCadastrarFornecedor();
            cf.ShowDialog();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmConsultarProduto cp = new frmConsultarProduto();
            cp.dgProduto.DataSource = new ProdutoDAO().ConsultarProdutos();
            cp.Show();
        }

        private void cadatrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto cp = new frmCadastrarProduto();
            cp.ShowDialog();
        }

        private void consultarFuncionario_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario cf = new frmConsultarFuncionario();
            cf.dgFuncionario.DataSource = new FuncionarioDAO().ConsultarFuncionario();
            cf.ShowDialog();
        }

        private void cadastrarFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario cf = new frmCadastrarFuncionario();
            cf.ShowDialog();
        }

        private void históricoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoricoVenda hv = new frmHistoricoVenda();
            hv.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCliente cc = new frmConsultarCliente();
            cc.dgCliente.DataSource = new ClienteDAO().ConsultarClientes();
            cc.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente cc = new frmCadastrarCliente();
            cc.ShowDialog();
        }

        private void produrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda venda= new frmVenda();
            venda.ShowDialog();
        }
    }
}