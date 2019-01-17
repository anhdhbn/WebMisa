using Entity;
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
    public class CommentDLL : DataAccess
    {
        private SqlCommand _sqlCommand;

        public Comment GetCommentById(Guid statusId)
        {
            _sqlCommand = CreateSqlCommand();
            _sqlCommand.CommandType = CommandType.StoredProcedure;

            _sqlCommand.CommandText = "[dbo].[Proc_GetCommentById]";
            _sqlCommand.Parameters.AddWithValue("@Id", statusId);
            SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();

            var comment = new Comment();
            for (int i = 0; i < sqlDataReader.FieldCount; i++)
            {
                string fieldName = sqlDataReader.GetName(i);
                PropertyInfo property = comment.GetType().GetProperty(fieldName);
                if (property != null && sqlDataReader[fieldName] != DBNull.Value)
                {
                    property.SetValue(comment, sqlDataReader[fieldName], null);
                }
            }
            return comment;
        }

        public ICollection<Status> GetListCommentByStatusId(Guid StatusId)
        {
            List<Status> listStatus = new List<Status>();
            _sqlCommand = CreateSqlCommand();
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.CommandText = "[dbo].[Proc_GetListCommentByStatusId]";
            _sqlCommand.Parameters.AddWithValue("@StatusId", StatusId);
            SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                var status = new Status();
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    string fieldName = sqlDataReader.GetName(i);

                    PropertyInfo property = status.GetType().GetProperty(fieldName);
                    if (property != null && sqlDataReader[fieldName] != DBNull.Value)
                    {
                        property.SetValue(status, sqlDataReader[fieldName], null);
                    }
                }
                listStatus.Add(status);
            }
            return listStatus;
        }
    }
}
