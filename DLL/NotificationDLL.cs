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
    public class NotificationDLL : DataAccess
    {
        private SqlCommand _sqlCommand;
        public ICollection<Notification> GetAllNotificationByUserId(Guid UserId)
        {
            List<Notification> notifications = new List<Notification>();
            _sqlCommand = CreateSqlCommand();
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.CommandText = "[dbo].[Proc_GetAllNotifyByUserId]";
            _sqlCommand.Parameters.AddWithValue("@UserId", UserId);
            SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                var notification = new Notification();
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    string fieldName = sqlDataReader.GetName(i);

                    PropertyInfo property = notification.GetType().GetProperty(fieldName);
                    if (property != null && sqlDataReader[fieldName] != DBNull.Value)
                    {
                        property.SetValue(notification, sqlDataReader[fieldName], null);
                    }
                }
                notifications.Add(notification);
            }
            return notifications;
        }

        public ICollection<Notification> GetAllNotificationSystem(Guid UserId)
        {
            List<Notification> notifications = new List<Notification>();
            _sqlCommand = CreateSqlCommand();
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.CommandText = "[dbo].[Proc_GetAllNotifySystem]";
            SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                var notification = new Notification();
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    string fieldName = sqlDataReader.GetName(i);

                    PropertyInfo property = notification.GetType().GetProperty(fieldName);
                    if (property != null && sqlDataReader[fieldName] != DBNull.Value)
                    {
                        property.SetValue(notification, sqlDataReader[fieldName], null);
                    }
                }
                notifications.Add(notification);
            }
            return notifications;
        }
    }
}
