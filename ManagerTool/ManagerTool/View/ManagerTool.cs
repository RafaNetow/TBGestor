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

        public HandlerConnection ConnectionData;
        public ManagerTool()
        {
            InitializeComponent();
        }

        private void ManagerTool_Load(object sender, EventArgs e)
        {

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
           String myConnectionString = "SERVER=127.0.0.1;UID=root;" +
                "PASSWORD=;database=gestor;";
            ConnectionData = new HandlerConnection(myConnectionString);
          var data = ConnectionData.ConfirmationOfConnection();
            MessageBox.Show(data.message);
            UserData = new UserManager(ConnectionData);
            //this.dataGridView1.DataSource = 
                UserData.GetColumn();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
               ConnectionData.conn.Close();
        }

       
    }
}
