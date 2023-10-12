using Microsoft.Data.SqlClient;
using System.Data;

namespace AutomobileLibrary.DataAccess
{
    public class StockDataProvider
    {
        private string? ConnectionString { get; set; } = null;
        public StockDataProvider()
        {
        }

        public StockDataProvider(string connectionString) 
            => this.ConnectionString = connectionString;

        public void CloseConnection(SqlConnection connection)
            => connection.Close();

        public SqlParameter CreateParameter(
                string name, 
                int size, 
                object value,
                DbType dbType,
                ParameterDirection direction = ParameterDirection.Input)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Size = size,
                Value = value,
                DbType = dbType,
                Direction = direction
            };
        }

        public IDataReader GetDataReader(string commandText, CommandType type,
            out SqlConnection connection, params SqlParameter[] parameters)
        {
            IDataReader dataReader = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command = new SqlCommand(commandText, connection);
                command.CommandType = type;
                if (parameters != null)
                {
                    foreach (var para in parameters)
                    {
                        command.Parameters.Add(para);
                    }
                }
                dataReader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataReader;
        }

        public void Delete(string commandText, CommandType cmdType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = cmdType;
                if (parameters != null)
                    foreach (var para in parameters)
                        command.Parameters.Add(para);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Data Provider:Delete Method", ex.InnerException);
            }
        }

        public void Insert(string commandText, 
            CommandType type, 
            params SqlParameter[] parameters) 
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = type;
                if (parameters != null)
                    foreach (var para in parameters)
                        command.Parameters.Add(para);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(string commandText,
            CommandType type,
            params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = type;
                if (parameters != null)
                    foreach (var para in parameters)
                        command.Parameters.Add(para);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
