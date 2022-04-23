using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RecantoDosPapagaios.Repository
{
    public class RelatorioRepository
    {
        private readonly SqlConnection _sqlConnection;

        public RelatorioRepository()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RecPapagaios"].ConnectionString);
        }

        public DataTable RelatorioFaturamentoChaleMensal(DateTime dataInicio, DateTime dataFim)
        {
            #region SQL

            var dataTable = new DataTable();

            var procedure = @"[RECPAPAGAIOS].[dbo].[uspRelatorioFaturamentoChaleMensal]";

            SqlCommand sqlCommand = new SqlCommand(procedure, _sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add("@DataInicio", SqlDbType.DateTime).Value = dataInicio;
            sqlCommand.Parameters.Add("@DataFim", SqlDbType.DateTime).Value = dataFim;

            try
            {
                _sqlConnection.Open();

                var adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }

            return dataTable;

            #endregion SQL
        }

        public DataTable RelatorioPerformanceFuncionarios()
        {
            #region SQL

            var dataTable = new DataTable();

            var procedure = "[RECPAPAGAIOS].[dbo].[uspRelatorioPerformanceFuncionarios]";

            SqlCommand sqlCommand = new SqlCommand(procedure, _sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                _sqlConnection.Open();

                var adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }

            return dataTable;

            #endregion SQL
        }

        public DataTable RelatorioVisaoGeralMensal(DateTime dataInicio, DateTime dataFim)
        {
            #region SQL

            var dataTable = new DataTable();

            var procedure = @"[RECPAPAGAIOS].[dbo].[uspRelatorioVisaoGeralMensal]";

            SqlCommand sqlCommand = new SqlCommand(procedure, _sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add("@DataInicio", SqlDbType.DateTime).Value = dataInicio;
            sqlCommand.Parameters.Add("@DataFim", SqlDbType.DateTime).Value = dataFim;

            try
            {
                _sqlConnection.Open();

                var adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }

            return dataTable;

            #endregion SQL
        }
    }
}
