using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class LikeDLL : DataAccess
    {
        private SqlCommand _sqlCommand;

        public int CountLikesByStatusId(Guid StatusId)
        {
            _sqlCommand = CreateSqlCommand();
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.CommandText = "[dbo].[Proc_CountLikesByStatusId]";
            _sqlCommand.Parameters.AddWithValue("@StatusId", StatusId);
            int result = (int)_sqlCommand.ExecuteScalar();
            return result;
        }
    }
}
