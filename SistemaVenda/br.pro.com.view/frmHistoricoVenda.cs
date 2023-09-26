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
    public partial class frmHistoricoVenda : Form
    {
        public frmHistoricoVenda()
        {
            InitializeComponent();
        }

        #region Botão Pesquisar
        /// <summary>
        /// Evento que realiza a pesquisa das vendas baseadas na data fim e na data inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio, dataFim;

            dataInicio = Convert.ToDateTime(dtpInicio.Value.ToString("yyyy-M-d"));
            dataFim = Convert.ToDateTime(dtpFim.Value.ToString("yyyy-M-d"));

            VendaDAO objDao = new VendaDAO();
            dgHistorico.DataSource = objDao.ListarHistoricoVenda(dataInicio, dataFim);
        }
        #endregion

        #region Load
        /// <summary>
        /// Tela de inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHistoricoVenda_Load(object sender, EventArgs e)
        {
            VendaDAO objDao = new VendaDAO();
            dgHistorico.DataSource = objDao.ConsultarVenda();
            dgHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }
        #endregion

        #region dgHistorico_CellClick
        /// <summary>
        /// Evento que traz outro formulário, para trazer os detalhes da venda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idVenda = int.Parse(dgHistorico.CurrentRow.Cells[0].Value.ToString());
            frmDetalhesVenda tela = new frmDetalhesVenda(idVenda);

            DateTime dataVenda = Convert.ToDateTime(dgHistorico.CurrentRow.Cells[1].Value.ToString());

            tela.txtCodigoVenda.Text = dgHistorico.CurrentRow.Cells[0].Value.ToString();
            tela.txtNome.Text = dgHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.mtbData.Text = dataVenda.ToString("d/M/yyyy");
            tela.txtValorTotal.Text = dgHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtObs.Text = dgHistorico.CurrentRow.Cells[4].Value.ToString();

            tela.ShowDialog();
        }
        #endregion
    }
}
