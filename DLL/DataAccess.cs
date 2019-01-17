using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DataAccess
    {
        //Chuỗi kết nối:
        private const string _connectionString = @"data source=webmisa.mssql.somee.com;initial catalog=webmisa;persist security info=True;user id=webmisa;password=webmisa123;multipleactiveresultsets=True;";
        // Sql Connection:
        SqlConnection _sqlConnection;
        // Sql Command:
        
        public DataAccess()
        {
            _sqlConnection = new SqlConnection(_connectionString);
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }

        public SqlCommand CreateSqlCommand()
        {
            return _sqlConnection.CreateCommand();
        }
    }
}
