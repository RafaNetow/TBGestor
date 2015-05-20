using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManagerTool.Clases
{
   public class UserManager
    {

        public HandlerConnection ConnectionData;

        public UserManager(HandlerConnection connectionData )
        {
            this.ConnectionData = connectionData;

        }



       public  void GetColumn()
       {
           string mySelectQuery = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'user'";
           
          
           MySqlCommand myCommand = new MySqlCommand(mySelectQuery, ConnectionData.conn);
           ConnectionData.conn.Open();
           MySqlDataReader myReader;
           try
           {
                myReader = myCommand.ExecuteReader();
               if (myReader.HasRows)
               {
                   MessageBox.Show("Alla van tus tablas vo");

               }
               else
               {
                   MessageBox.Show("No encontramos nada Vo");
               }
               ;
               // Always call Read before accessing data. 
               while (myReader.Read())
               {
                   Console.WriteLine(myReader.GetInt32(0) + "," + myReader.GetString(myReader.GetOrdinal("DName")));
               }

               // always call Close when done reading. 
               myReader.Close();

               // Close the connection when done with it. 
           }
           finally
           {
               ConnectionData.conn.Close();
           }



       } 
       
       
       public DataTable GetColumns(string tableName)
        {
           
            var dataTable = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "'";
            cmd.CommandType = CommandType.Text;
            
            cmd.Connection = ConnectionData.conn;

            MySqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            MessageBox.Show("Este e tu connectionString"+ConnectionData.connectionString);
            if (reader.HasRows)
            {
                MessageBox.Show("Alla van tus tablas vo");
                return dataTable;
            }
            MessageBox.Show("No encontramos nada Vo");
            return null;
        }
        public void ReadMyData(string myConnString)
        {
            string mySelectQuery = "SELECT DeptNo, DName FROM Test.Dept";
            MySqlConnection myConnection = new MySqlConnection(myConnString);
            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);
            myConnection.Open();
            try
            {
                MySqlDataReader myReader = myCommand.ExecuteReader();

                // Always call Read before accessing data. 
                while (myReader.Read())
                {
                    Console.WriteLine(myReader.GetInt32(0) + ", " + myReader.GetString(myReader.GetOrdinal("DName")));
                }

                // always call Close when done reading. 
                myReader.Close();

                // Close the connection when done with it. 
            }
            finally
            {
                myConnection.Close();
            }
        }     
    
    }
}
