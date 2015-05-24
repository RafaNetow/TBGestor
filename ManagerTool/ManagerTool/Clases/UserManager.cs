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





        public  DataTable GetTables()
        {
            var dataTable = new DataTable();
          

            try
            {

                ConnectionData.conn.Open();


                dataTable = ConnectionData.conn.GetSchema("Tables");
                ConnectionData.conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }
        
        
        
        
        
        
        public DataTable GetColumnOfTable(String tableName)
        {

            var dataTable = new DataTable();


            try
            {

                ConnectionData.conn.Open();


                
                dataTable = ConnectionData.conn.GetSchema("Columns", new[] { null, null, tableName });
                ConnectionData.conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }


        public DataTable getProcedureInformation()
        {

            var dataTable = new DataTable();


            try
            {

                ConnectionData.conn.Open();



                dataTable = ConnectionData.conn.GetSchema("Tables", new string[] {null, null, null, 
                              "TABLE"});
                ConnectionData.conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public TreeNode GeTreeNode(DataTable TableSchema, string NameRow,string TreeNodeName)
        {

            var rowTable = TableSchema.Select(NameRow+" <> ''");
            var arrayTablas = rowTable.Select(row => new TreeNode((string)row[NameRow])).ToArray(); //

            var treeNode = new TreeNode(TreeNodeName, arrayTablas);
            return treeNode;
        }

        public DataTable GetProcedure()
        {

            var dataTable = new DataTable();


            try
            {

                ConnectionData.conn.Open();


                dataTable = ConnectionData.conn.GetSchema("Procedures");
                ConnectionData.conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ConnectionData.conn.Close();
            return dataTable;
        }


    }
}
