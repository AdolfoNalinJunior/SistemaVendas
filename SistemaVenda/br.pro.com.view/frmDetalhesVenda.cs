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
    public partial class frmDetalhesVenda : Form
    {
        int idVenda;

        public frmDetalhesVenda(int id)
        {
             idVenda = id;
            InitializeComponent();
        }

        private void frmDetalhesVenda_Load(object sender, EventArgs e)
        {
            ItemVendaDAO objDao = new ItemVendaDAO();
            dgVenda.DataSource = objDao.ListarItemVenda(idVenda);
        }

        private void dgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
