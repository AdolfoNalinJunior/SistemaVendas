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
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        frmConsultarProduto cp = new frmConsultarProduto();

        #region Load
        /// <summary>
        /// Evento Load que capitura os dados do fornecedor e passa para o ComboBox Fornecedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbFornecedor.DataSource = f_dao.ConsultarFornecedores();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";
            ProdutoDAO obj = new ProdutoDAO();

            cp.dgProduto.DataSource = obj.ConsultarProdutos();
        }
        #endregion

        #region BotãoSalvar
        /// <summary>
        /// Evento que salva o obj no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.DescricaoCompleta = txtDescricaoCompleta.Text;
            obj.DescricaoResumida = txtDescricaoResumida.Text;
            obj.PrecoPrazo = decimal.Parse(mtbPrecoPrazo.Text);
            obj.PrecoVista = decimal.Parse(mtbPrecoVista.Text);
            obj.ValorEntrada = decimal.Parse(mtbValorEntrada.Text);
            obj.ValorTotal= decimal.Parse(mtbValorTotal.Text);
            obj.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            obj.CodigoFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue.ToString());
            obj.UniMedida = cbUnidadeMedida.Text;
            obj.Data = Convert.ToDateTime(mtbData.Text);
            obj.Hora = Convert.ToDateTime(mtbHora.Text);
            obj.Imagem = Convert.ToByte(pbProduto.Image);
            obj.NumeroNFe = mtbNumeroNota.Text;

            ProdutoDAO dao = new ProdutoDAO();
            dao.CadastrarProdutos(obj);

            cp.dgProduto.DataSource = dao.ConsultarProdutos();

            new Helpers().LimparTela(this);
        }
        #endregion

        #region BotãoNovo
        /// <summary>
        /// Evento que limpa os elementos da tabCadastrarProdutos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        #endregion


        #region BotãoEditar
        /// <summary>
        /// Evento que edita os dados do obj no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.DescricaoCompleta = txtDescricaoCompleta.Text;
            obj.DescricaoResumida = txtDescricaoResumida.Text;
            obj.PrecoPrazo = decimal.Parse(mtbPrecoPrazo.Text);
            obj.PrecoVista = decimal.Parse(mtbPrecoVista.Text);
            obj.ValorEntrada = decimal.Parse(mtbValorEntrada.Text);
            obj.ValorTotal = decimal.Parse(mtbValorTotal.Text);
            obj.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            obj.CodigoFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue.ToString());
            obj.UniMedida = cbUnidadeMedida.Text;
            obj.Data = Convert.ToDateTime(mtbData.Text);
            obj.Hora = Convert.ToDateTime(mtbHora.Text);
            obj.Imagem = Convert.ToByte(pbProduto.Image);
            obj.NumeroNFe = mtbNumeroNota.Text;

            ProdutoDAO dao = new ProdutoDAO();
            dao.EditarProduto(obj);

            cp.dgProduto.DataSource = dao.ConsultarProdutos();
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
            Produto obj = new Produto();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.ExcluirProduto(obj);

            cp.dgProduto.DataSource = dao.ConsultarProdutos();
        }
        #endregion


    }
}
