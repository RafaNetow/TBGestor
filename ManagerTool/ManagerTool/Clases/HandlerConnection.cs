using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ManagerTool.Entidad;
using MySql.Data.MySqlClient;

namespace ManagerTool.Clases
{
    public class HandlerConnection
    {
        public User userInfo;
        public string connectionString;
        public MySqlConnection conn;
        public HandlerConnection(String connectionString)
        {
            this.userInfo = new User();
            
            this.connectionString = connectionString;
        }

        public void InformationUser(string database,string username, string server)
        {
            userInfo.user = username;
            userInfo.Server = server;
            userInfo.database = database;
        }
        public ConnectionString ConfirmationOfConnection()
        {
            var Data = new ConnectionString();
            Data.Connection = connectionString;
            try
            {
                conn = new MySqlConnection(connectionString);


                conn.Open();
                Data.message = "Conexion Confirmada";
                Data.Confirmation = true;




            }
            catch (MySqlException ex)
            {
                Data.message = ex.Message;
                Data.Confirmation = false;
            }

            
            conn.Close();
            return Data;


        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public void OpenConnection()
        {
            conn.Open();
        }

    }
}