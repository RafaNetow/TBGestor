using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerTool.Clases;
using ManagerTool.Entidad;

namespace ManagerTool
{
    public partial class ManagerTool : Form
    {
        public UserManager UserData;
        private ToolsManager Tools = new ToolsManager();

        public HandlerConnection ConnectionData;
        public ManagerTool()
        {
            InitializeComponent();
        }

        private void ManagerTool_Load(object sender, EventArgs e)
        {
            
            String myConnectionString = "SERVER=127.0.0.1;UID=root;" +
           "PASSWORD=;database=gestor;";
            ConnectionData = new HandlerConnection(myConnectionString);
            var data = ConnectionData.ConfirmationOfConnection();
            MessageBox.Show(data.message);
            UserData = new UserManager(ConnectionData);
            var table = UserData.GetTables();
             
            var treeTableNode = UserData.GeTreeNode(table, "TABLE_NAME", "Table");
            treeView1.Nodes.Add(treeTableNode);
            foreach (TreeNode child in treeTableNode.Nodes)
            {

                var childname = child.Text;

                var childcolum = UserData.GetColumnOfTable(childname);

                var  columname = childcolum.Select("COLUMN_NAME <> ''");

                var arrayCols = columname.Select(row => new TreeNode((string)row["COLUMN_NAME"])).ToArray(); //

                child.Nodes.Add(new TreeNode("Columnas", arrayCols));

            }
            var procedure = UserData.GetProcedure();
            var TreeProcedureNode = UserData.GeTreeNode(procedure, "SPECIFIC_NAME", "procedimientos");
            treeView1.Nodes.Add(TreeProcedureNode);
        
            
           

           
           
                //treeNode = new TreeNode("Procedimientos", x);

                //               treeView1.Nodes.Add(treeNode);
            

            this.dataGridView1.DataSource = procedure;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

          

            

        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
            richTextBoxSQL.Clear();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
              
            this.dataGridView1.DataSource = UserData.GetTables();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
               ConnectionData.conn.Close();
        }

       
    }
}
