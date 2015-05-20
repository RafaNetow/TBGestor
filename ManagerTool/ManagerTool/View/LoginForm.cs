using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerTool.Clases;

namespace ManagerTool
{
    public partial class LoginForm : Form
    {

        HandlerConnection _handleConn;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BotonLogin_Click(object sender, EventArgs e)
        {
            
            string conect = "SERVER=127.0.0.1" + ";UID=" + this.TexBoxUser.Text + ";PASSWORD=;database=" + this.textBoxDatabase.Text + ";";
            _handleConn = new HandlerConnection(conect);
            _handleConn.InformationUser(this.textBoxDatabase.Text,this.TexBoxUser.Text,this.textBoxLocalHost.Text);
            MessageBox.Show(_handleConn.userInfo.user + _handleConn.userInfo.Server, _handleConn.userInfo.database);
            var dataConnection = _handleConn.ConfirmationOfConnection();
            MessageBox.Show(dataConnection.message);
            if (dataConnection.Confirmation)
            {
                MessageBox.Show("Bienvenido" + this.TexBoxUser.Text);
                ManagerTool mt = new ManagerTool();
                MessageBox.Show(_handleConn.connectionString);
                this.Hide();
                mt.Show(this);
            }
            /*
            try
            {
              
                //MySql.Data.MySqlClient.MySqlCommand SelectCommand = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM gest.user where user_name ='" + this.TexBoxUser.Text + "' and user_password ='" + this.TextBoxPassword.Text+"';",conn);
                MySql.Data.MySqlClient.MySqlDataReader myReader;
                
               
                //myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                   
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
              

            
            }


             */



        }

        private void TexBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

