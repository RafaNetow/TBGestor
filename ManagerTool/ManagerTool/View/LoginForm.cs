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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BotonLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Complete");
            ManagerTool mt = new ManagerTool();
            this.Hide();
            mt.Show();







        }
    }
}

