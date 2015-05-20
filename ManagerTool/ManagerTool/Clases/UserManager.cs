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

        public UserManager(HandlerConnection connectionData)
        {
            this.ConnectionData = connectionData;

        }



        public DataTable GetColumn(String user)
        {
            var Table = new DataTable();
            string mySelectQuery =
                "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'user'";


            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, ConnectionData.conn);
            ConnectionData.conn.Open();
            MySqlDataReader myReader;
            try
            {
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    MessageBox.Show("Alla van tus tablas vo");
                    Table.Load(myReader);
                    ConnectionData.conn.Close();
                    myReader.Close();
                    return Table;
                }
                else
                {
                    MessageBox.Show("No encontramos nada Vo");

                }
                ;
                // Always call Read before accessing data. 


                // always call Close when done reading. 
                myReader.Close();

                // Close the connection when done with it. 
            }
            finally
            {
                ConnectionData.conn.Close();
            }

            return null;


        }




    }
}
