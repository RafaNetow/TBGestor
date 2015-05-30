using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManagerTool.Clases
{
    internal class ToolsManager
    {

        public DataTable MySqlQuery(UserManager currentUserrData, String Query)
        {
            var Table = new DataTable();
            currentUserrData.ConnectionData.conn.Open();


            MySqlCommand myCommand = new MySqlCommand(Query, currentUserrData.ConnectionData.conn);

            MySqlDataReader myReader;
            try
            {
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    
                    Table.Load(myReader);
                    currentUserrData.ConnectionData.conn.Close();
                    myReader.Close();
                   
                    return Table;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
               currentUserrData.ConnectionData.conn.Close();
            return Table;

        }
    }
}
