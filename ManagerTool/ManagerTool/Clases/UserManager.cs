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


        public DataTable GetFunctions()
        {


             var dataTable = new DataTable();
             ConnectionData.conn.Open();
             MySqlCommand myCommand = new MySqlCommand("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE='FUNCTION'", ConnectionData.conn);

             MySqlDataReader myReader;
            try
            {
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    MessageBox.Show("Alla va tu select vo");
                    dataTable.Load(myReader);
                    ConnectionData.conn.Close();
                    myReader.Close();

                    return dataTable;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            ConnectionData.conn.Close();
            return dataTable;
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
            ConnectionData.conn.Open();
            MySqlCommand myCommand = new MySqlCommand("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE='PROCEDURE'", ConnectionData.conn);

            MySqlDataReader myReader;
            try
            {
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    MessageBox.Show("Alla va tu select vo");
                    dataTable.Load(myReader);
                    ConnectionData.conn.Close();
                    myReader.Close();

                    return dataTable;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            ConnectionData.conn.Close();
            return dataTable;
        }

        public DataTable GetTrigger()
        {



            var dataTable = new DataTable();


            try
            {

                ConnectionData.conn.Open();


                dataTable = ConnectionData.conn.GetSchema("Triggers");
                ConnectionData.conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public DataTable GetView()
        {

            var dataTable = new DataTable();


            try
            {

                ConnectionData.conn.Open();


                dataTable = ConnectionData.conn.GetSchema("Views");
                ConnectionData.conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
            
        }

        public DataTable GetTableSpace()
        {


            return new DataTable();
        }
    
    }
}
