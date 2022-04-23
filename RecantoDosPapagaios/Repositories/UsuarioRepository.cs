using RecantoDosPapagaios.Entities;
using System.Data;
using System.Data.SqlClient;

namespace RecantoDosPapagaios.Repositories
{
    public class UsuarioRepository
    {
        private readonly SqlConnection _sqlConnection;

        private readonly Retorno _retorno;

        public UsuarioRepository()
        {
            _sqlConnection = new SqlConnection("Data Source=DESKTOP-8J62RD3\\SQLEXPRESS;Initial Catalog=RECPAPAGAIOS;Integrated Security=True;Connect Timeout=30");

            _retorno = new Retorno();
        }

        public Retorno FazerLogin(Usuario usuario)
        {
            var dataTable = new DataTable();

            var procedure = @"[RECPAPAGAIOS].[dbo].[uspFazerLogin]";

            SqlCommand sqlCommand = new SqlCommand(procedure, _sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add("@NomeUsuario", SqlDbType.NVarChar).Value = usuario.NomeUsuario;
            sqlCommand.Parameters.Add("@Senha", SqlDbType.NVarChar).Value = usuario.SenhaUsuario;

            try
            {
                _sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);

                _retorno.Id = (int)dataTable.Rows[0]["Codigo"];
                _retorno.Mensagem = dataTable.Rows[0]["Mensagem"].ToString();
            }
            catch (SqlException ex)
            {
                _retorno.Id = ex.ErrorCode;
                _retorno.Mensagem = ex.Message;
            }
            finally
            {
                _sqlConnection.Close();
            }

            return _retorno;
        }

        public Retorno EncontrarConta(string cpf)
        {
            var dataTable = new DataTable();

            var procedure = @"[RECPAPAGAIOS].[dbo].[uspEsqueciMinhaSenha_EncontrarConta]";

            SqlCommand sqlCommand = new SqlCommand(procedure, _sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add("@Cpf", SqlDbType.NVarChar).Value = cpf;

            try
            {
                _sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);

                _retorno.Id = (int)dataTable.Rows[0]["Codigo"];
                _retorno.Mensagem = dataTable.Rows[0]["Mensagem"].ToString();
            }
            catch (SqlException ex)
            {
                _retorno.Id = ex.ErrorCode;
                _retorno.Mensagem = ex.Message;
            }
            finally
            {
                _sqlConnection.Close();
            }

            return _retorno;
        }

        public string CarregarPerguntaDeSeguranca(string cpf)
        {
            string perguntaSeguranca = null;
            
            var query = @"  SELECT		P.PERG_SEG_PERGUNTA_STR
                            FROM		USUARIO				AS U
                            INNER JOIN	FUNCIONARIO			AS F ON U.USU_ID_INT = F.FUNC_USU_ID_INT
                            INNER JOIN	PERGUNTA_SEGURANCA	AS P ON U.USU_ID_INT = P.PERG_SEG_USU_ID_INT
                            WHERE		F.FUNC_CPF_CHAR = " + cpf;

            SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection);

            sqlCommand.CommandType = CommandType.Text;

            _sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                perguntaSeguranca = (string)sqlDataReader["PERG_SEG_PERGUNTA_STR"];
            }

            _sqlConnection.Close();

            return perguntaSeguranca;
        }

        public Retorno PerguntaDeSeguranca(string cpf, string resposta)
        {
            var dataTable = new DataTable();
            
            var procedure = @"[RECPAPAGAIOS].[dbo].[uspPerguntaDeSeguranca]";

            SqlCommand sqlCommand = new SqlCommand(procedure, _sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add("@Cpf", SqlDbType.NChar).Value = cpf;
            sqlCommand.Parameters.Add("@Reposta", SqlDbType.NVarChar).Value = resposta;

            try
            {
                _sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);

                _retorno.Id = (int)dataTable.Rows[0]["Codigo"];
                _retorno.Mensagem = dataTable.Rows[0]["Mensagem"].ToString();
            }
            catch (SqlException ex)
            {
                _retorno.Id = ex.ErrorCode;
                _retorno.Mensagem = ex.Message;
            }
            finally
            {
                _sqlConnection.Close();
            }

            return _retorno;
        }

        public Retorno DefinirNovaSenha(string cpf, string novaSenha, string repeticaoSenha)
        {
            var dataTable = new DataTable();

            var procedure = @"[RECPAPAGAIOS].[dbo].[uspDefinirNovaSenha]";

            SqlCommand sqlCommand = new SqlCommand(procedure, _sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add("@Cpf", SqlDbType.NChar).Value = cpf;
            sqlCommand.Parameters.Add("@NovaSenha", SqlDbType.NVarChar).Value = novaSenha;
            sqlCommand.Parameters.Add("@RepeticaoSenha", SqlDbType.NVarChar).Value = repeticaoSenha;

            try
            {
                _sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);

                _retorno.Id = (int)dataTable.Rows[0]["Codigo"];
                _retorno.Mensagem = dataTable.Rows[0]["Mensagem"].ToString();
            }
            catch (SqlException ex)
            {
                _retorno.Id = ex.ErrorCode;
                _retorno.Mensagem = ex.Message;
            }
            finally
            {
                _sqlConnection.Close();
            }

            return _retorno;
        }
    }
}
