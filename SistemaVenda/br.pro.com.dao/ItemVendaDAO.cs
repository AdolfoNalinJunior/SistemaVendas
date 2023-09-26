using MySql.Data.MySqlClient;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.dao
{
    public class ItemVendaDAO
    {
        #region CampoConnection
        /// <summary>
        /// Campo responsável pela connexão do banco de dados
        /// </summary>
        private MySqlConnection connection;
        #endregion

        #region Construtor
        public ItemVendaDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarItemVenda
        /// <summary>
        /// Cadastra o obj na tabela itensvendas
        /// </summary>
        /// <param name="obj">obj que vão ser cadastrados</param>
        public void CadastrarItemVenda(ItemVenda obj)
        {
            try
            {
                string sql = @"insert into bdvendas.tb_itensvendas (venda_id, produto_id, qtd, subtotal)
values (@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@venda_id", obj.CodigoVenda);
                cmd.Parameters.AddWithValue("@produto_id", obj.CodigoProduto);
                cmd.Parameters.AddWithValue("@qtd", obj.Quantidade);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu eu erro do tipo {ex.Message} como o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region ListarItemVenda
        /// <summary>
        /// Função que busca os dados da venda, para passar para o data grid view
        /// </summary>
        /// <param name="id">Parametro para a pesquisa</param>
        /// <returns>DataTable</returns>
        public DataTable ListarItemVenda(int id)
        {
            try
            {
                DataTable tabListarItem = new DataTable();
                string sql = @"select i.id as ´Código,
                p.descricao as 'Descrição',
                i.qtd as 'Quantidade',
                p.preco as 'Preço', 
                i.subtotal as 'SubTotal'
                from bdvendas.tb_itensvendas as i join 
                bdvendas.tb_produtos as p on (i.produto_id = p.id)
                where venda_id = @idvenda";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@idvenda", id);

                connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DA.Fill(tabListarItem);

                connection.Close();

                return tabListarItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
        }
        #endregion
    }
}
