﻿using MySql.Data.MySqlClient;
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
    public class FornecedorDAO
    {
        #region Connection
        /// <summary>
        /// Variável de conexão
        /// </summary>
        private MySqlConnection connection;
        #endregion

        #region FornecedorDAO
        /// <summary>
        /// Construtor que inicia a conexão com a classe connectionFactory, usando o função GetConnection()
        /// </summary>
        public FornecedorDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }
        #endregion

        #region CadastrarFonecedor
        /// <summary>
        /// Cadastra o fornecedor desejado no banco de dados
        /// </summary>
        /// <param name="obj">Fornecedor que deseja ser casdastrado</param>
        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                // 1 passo - define the cmd sql = insert into
                string sql = @"insert into tb_fornecedores (nome,cnpj,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
values(@nome,@cnpj,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                //2 passo - Transcribe the commands of SQL to CSharp
                MySqlCommand sqlCmd = new MySqlCommand(sql, connection);
                sqlCmd.Parameters.AddWithValue("@nome", obj.Nome);
                sqlCmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                sqlCmd.Parameters.AddWithValue("@email", obj.Email);
                sqlCmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                sqlCmd.Parameters.AddWithValue("@celular", obj.Celular);
                sqlCmd.Parameters.AddWithValue("@cep", obj.CEP);
                sqlCmd.Parameters.AddWithValue("@endereco", obj.Logradouro);
                sqlCmd.Parameters.AddWithValue("@numero", obj.Numero);
                sqlCmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                sqlCmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                sqlCmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                sqlCmd.Parameters.AddWithValue("@estado", obj.Estado);

                // 3 passo - Opening the connection and execulte the command SQL
                this.connection.Open();
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show($"O fornecedor {obj.Nome} foi cadastrado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro! Erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ConsultarFornecedores
        /// <summary>
        /// Realiza um consulta no banco de dados
        /// </summary>
        /// <returns>Os resultados para um DataTable</returns>
        public DataTable ConsultarFornecedores()
        {
            try
            {
                DataTable tabFornecedores = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_fornecedores";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabFornecedores);

                connection.Close();
                return tabFornecedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A conteceu um erro de tipo: {ex.Message} com o caminho de {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region EditarFornecedores
        /// <summary>
        /// Edita os dados dos fonecedores
        /// </summary>
        /// <param name="obj">Fornecedores que deseja ser editado</param>
        public void EditarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"update bdvendas.tb_fornecedores set nome=@nome,cnpj=@cnpj,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,
complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@nome", obj.Nome);
                cmdSql.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                cmdSql.Parameters.AddWithValue("@email", obj.Email);
                cmdSql.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmdSql.Parameters.AddWithValue("@celular", obj.Celular);
                cmdSql.Parameters.AddWithValue("@cep", obj.CEP);
                cmdSql.Parameters.AddWithValue("@endereco", obj.Logradouro);
                cmdSql.Parameters.AddWithValue("@numero", obj.Numero);
                cmdSql.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmdSql.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmdSql.Parameters.AddWithValue("@cidade", obj.Cidade);
                cmdSql.Parameters.AddWithValue("@estado", obj.Estado);
                cmdSql.Parameters.AddWithValue("@id", obj.Codigo);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"O fornecedor {obj.Nome} for editado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo: {ex.Message} com o caminho: {ex.StackTrace}");
            }
        }
        #endregion

        #region ExcluirFornecedor
        /// <summary>
        /// Exclui os fornecedores do banco de dados
        /// </summary>
        /// <param name="obj">Forncedor que deseja ser excluido</param>
        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = "delete from tb_fornecedores where id=@id";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@id", obj.Codigo);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MessageBox.Show($"O fornecedor {obj.Nome} foi deletado com sucesso!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo: {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region BusacarFornecedoresNome (txtNomeConsultar)
        /// <summary>
        /// Busca os fornecedores pelo nome correto
        /// </summary>
        /// <param name="nome">Fornecedores que vai ser perquisado</param>
        /// <returns></returns>
        public DataTable BuscarFornecedores(string nome)
        {
            try
            {
                DataTable tabFornecedores = new DataTable();
                string sql = "select * from bdvendas.tb_fornecedores where nome = @nome";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@nome", nome);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabFornecedores);

                connection.Close();
                return tabFornecedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um Erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region ListarFornecedoresNome
        /// <summary>
        /// Listar os fornecedores de acordo com o que o usuários digita
        /// </summary>
        /// <param name="nome">Nome do fornecedor</param>
        /// <returns></returns>
        public DataTable ListarFornecedoresNome(string nome)
        {
            try
            {
                DataTable tabForncedores = new DataTable();
                string sql = "SELECT * FROM bdvendas.tb_fornecedores where nome like @nome;";

                MySqlCommand cmdSql = new MySqlCommand(sql, connection);
                cmdSql.Parameters.AddWithValue("@nome", nome);

                connection.Open();
                cmdSql.ExecuteNonQuery();

                MySqlDataAdapter DA = new MySqlDataAdapter(cmdSql);
                DA.Fill(tabForncedores);

                connection.Close();
                return tabForncedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }

        }
        #endregion
    }
}
