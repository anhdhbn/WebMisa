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
    public class UserDLL : DataAccess
    {
        private SqlCommand _sqlCommand;
        public bool CheckUserInfo(string userName, string password)
        {
            _sqlCommand = CreateSqlCommand();
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.CommandText = "[dbo].[Proc_CheckLogin]";
            _sqlCommand.Parameters.AddWithValue("@Username", userName);
            _sqlCommand.Parameters.AddWithValue("@Password", password);
            bool result = (bool)_sqlCommand.ExecuteScalar();
            return result;
        }

        public User GetUserById(Guid id)
        {
            // Khởi tạo Sql Command để thao tác với dữ liệu:
            _sqlCommand = CreateSqlCommand();

            // Chọn loại truy vấn để thao tác với dữ liệu:
            _sqlCommand.CommandType = CommandType.StoredProcedure;

            _sqlCommand.CommandText = "[dbo].[Proc_GetInfo]";
            _sqlCommand.Parameters.AddWithValue("@Id", id);
            // Khởi tạo đối tượng SqlDataReader để hứng dữ liệu trả về từ Store:
            SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();

            var user = new User();
            // Thực hiện đọc dữ liệu từng dòng->cột-> cell:
            for (int i = 0; i < sqlDataReader.FieldCount; i++)
            {
                // Tên cột
                string fieldName = sqlDataReader.GetName(i);

                PropertyInfo property = user.GetType().GetProperty(fieldName);
                // Nếu tên cột trùng với tên propery thì gán giá trị tương ứng:
                if (property != null && sqlDataReader[fieldName] != DBNull.Value)
                {
                    property.SetValue(user, sqlDataReader[fieldName], null);
                }
            }

            return user;
        }
    }
}
