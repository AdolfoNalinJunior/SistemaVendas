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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region BotãoAvançar
        /// <summary>
        /// Evento que executa a função logar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            string email = txtNome.Text;
            string senha = txtSenha.Text;
            string nome = txtNome.Text;

            FuncionarioDAO objDao = new FuncionarioDAO();

            if (objDao.LogarNome(nome, senha))
            {
                Hide();
            }
            else
            {
                txtNome.Text = String.Empty;
                txtSenha.Text = String.Empty;

                txtNome.Focus();
            }
        }
        #endregion

        #region BotãoCancelar_Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}
