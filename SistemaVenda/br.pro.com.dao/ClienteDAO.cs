using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.connection;

namespace SistemaVenda.br.pro.com.dao
{
    /// <summary>
    /// Classe que tem conexão com a tabela Cliente no banco de dados
    /// </summary>
    public class ClienteDAO
    {
        #region connetion
        /// <summary>
        /// Atributo MySqlCoonction 
        /// </summary>
        private MySqlConnection connection;
        #endregion

        #region ClienteDAO  
        /// <summary>
        /// Contrutor com a conecxão da classe ConnetionFactory
        /// </summary>
        public ClienteDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarCliente
        /// <summary>
        /// Cadastro do <paramref name="obj"/> no banco de dados
        /// </summary>
        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                // 1 passo - define the cmd sql = insert into
                string cmdSql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
values(@nome,@rg,@cpf,@email,@telefone,@celular,@cep,@logradouro,@numero,@complemento,@bairro,@cidade,@estado)";

                //2 passo - Transcribe the commands of SQL to CSharp
                MySqlCommand sqlCmd = new MySqlCommand(cmdSql, connection);
                sqlCmd.Parameters.AddWithValue("@nome", obj.Nome);
                sqlCmd.Parameters.AddWithValue("@rg", obj.RG);
                sqlCmd.Parameters.AddWithValue("@cpf", obj.CPF);
                sqlCmd.Parameters.AddWithValue("@email", obj.Email);
                sqlCmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                sqlCmd.Parameters.AddWithValue("@celular", obj.Celular);
                sqlCmd.Parameters.AddWithValue("@cep", obj.CEP);
                sqlCmd.Parameters.AddWithValue("@logradouro", obj.Logradouro);
                sqlCmd.Parameters.AddWithValue("@numero", obj.Numero);
                sqlCmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                sqlCmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                sqlCmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                sqlCmd.Parameters.AddWithValue("@estado", obj.Estado);

                // 3 passo - Opening the connection and execulte the command SQL
                this.connection.Open();

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show($"O cliente {obj.Nome} foi cadastrado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro! Erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ConsultarClientes
        /// <summary>
        /// Consulta do banco de dados, para listar os clientes cadastrado nele
        /// </summary>
        /// <returns>Retorna a  lista de clientes que está no banco de dados </returns>
        public DataTable ConsultarClientes()
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_clientes;";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql, connection);

                // 3 passo - Abertura da connection
                connection.Open();
                cmdSql.ExecuteNonQuery();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabelaCliente);

                // 4 passo - Fechar a conexão
                connection.Close();
                return tabelaCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace} Com a seguinte mesagem: {ex.Message}");
                return null;
            }
        }
        #endregion

        #region EditarCliente
        /// <summary>
        /// Realiza a edição dos dados do cliente
        /// </summary>
        /// <param name="cliente">Parametro do tipo cliente</param>
        public void EditarCliente(Cliente cliente)
        {
            try
            {

                string sqlcmd = @"update bdvendas.tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@logradouro,numero=@numero,
complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
where id=@id";
                MySqlCommand cmdSql = new MySqlCommand(sqlcmd, connection);
                cmdSql.Parameters.AddWithValue("@nome", cliente.Nome);
                cmdSql.Parameters.AddWithValue("@rg", cliente.RG);
                cmdSql.Parameters.AddWithValue("@cpf", cliente.CPF);
                cmdSql.Parameters.AddWithValue("@email", cliente.Email);
                cmdSql.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmdSql.Parameters.AddWithValue("@celular", cliente.Celular);
                cmdSql.Parameters.AddWithValue("@cep", cliente.CEP);
                cmdSql.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
                cmdSql.Parameters.AddWithValue("@numero", cliente.Numero);
                cmdSql.Parameters.AddWithValue("@complemento", cliente.Complemento);
                cmdSql.Parameters.AddWithValue("@bairro", cliente.Bairro);
                cmdSql.Parameters.AddWithValue("@cidade", cliente.Cidade);
                cmdSql.Parameters.AddWithValue("@estado", cliente.Estado);
                cmdSql.Parameters.AddWithValue("@id", cliente.Codigo);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"O Cliente {cliente.Nome} foi editado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O cliente {cliente.Nome} não foi editado com sucesso!: Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region ExcluirClientes
        /// <summary>
        /// Método responsável pela exclusão do <paramref name="cliente"/> pelo id
        /// </summary>
        /// <param name="cliente">Parametro do tipo <paramref name="cliente" \/></param>
        public void ExcluirClientes(Cliente cliente)
        {
            try
            {
                string cmdSql = "delete from bdvendas.tb_clientes where id=@id";

                MySqlCommand sqlCmd = new MySqlCommand(cmdSql, connection);
                sqlCmd.Parameters.AddWithValue("@id", cliente.Codigo);

                connection.Open();
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show($"O cliente {cliente.Nome} foi excluido com sucesso");

                // Fachando a conxão com o banco de dados
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A exclusão do cliente {cliente.Nome} não foi bem sucedida, mensagem de erro: {ex.Message}, Caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region BuscarClienteNome
        /// <summary>
        /// Busca o cliente por nome devidamente CORRETO
        /// </summary>
        /// <param name="nome">Nome do Cliente que vai ser pesquisado</param>
        /// <returns>Todos os valores com o parametro desejado</returns>
        public DataTable BuscarClienteNome(string nome)
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_clientes where nome = @nome";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql, connection);

                cmdSql.Parameters.AddWithValue("@nome", nome);

                // 3 passo - Abertura da connection
                connection.Open();
                cmdSql.ExecuteNonQuery();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabelaCliente);

                connection.Close();
                return tabelaCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace} {ex.Message}");
                return null;
            }
        }
        #endregion

        #region ListarClienteNome
        /// <summary>
        /// Lista os clientes de acordo que o usuário digita
        /// </summary>
        /// <param name="nome">Nome do cliente desajado</param>
        /// <returns>Os nomes encontrados com os valores digitados</returns>
        public DataTable ListarClienteNome(string nome)
        {
            try
            {
                // 1 passo - Cirar oDataTable e o comando SQL
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_clientes where nome like @nome";

                //2 passo - Organizar o comando e executar
                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@nome", nome);

                // 3 passo - Abertura da connection
                connection.Open();
                cmdSql.ExecuteNonQuery();

                // 4 passo - Criar uma  MySqlDataApter para preencher os datos no DataTable
                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabelaCliente);

                connection.Close();
                return tabelaCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro: {ex.StackTrace} {ex.Message}");
                return null;
            }
        }
        #endregion

        #region BuscarClienteVendas
        /// <summary>
        /// Função que trás os dados do cliente para o load venda
        /// </summary>
        /// <param name="cpf">Parametro de busca CPF</param>
        /// <returns></returns>
        public Cliente BuscarClienteVendas(string cpf)
        {
            try
            {
                Cliente obj = new Cliente();
                string sql = "select * from bdvendas.tb_clientes where cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                connection.Open();

                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    obj.Codigo = rs.GetInt32("id");
                    obj.Nome = rs.GetString("nome");
                    obj.Logradouro = rs.GetString("endereco");
                    obj.Numero = rs.GetInt32("numero");
                    obj.Bairro = rs.GetString("bairro");
                    obj.Complemento = rs.GetString("complemento");

                    connection.Close();
                    return obj;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado, por favor digite um CPF válido!");
                    connection.Close();
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
        }
        #endregion
    }
}

