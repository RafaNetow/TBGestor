using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerTool
{
    public partial class ManagerTool : Form
    {
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

       
    }
}
