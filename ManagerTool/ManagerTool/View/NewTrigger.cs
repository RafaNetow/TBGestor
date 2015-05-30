using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerTool.View
{
    public partial class NewTrigger : Form
    {

        private ManagerTool managerTool;
        public NewTrigger(ManagerTool managerTool)
        {
            InitializeComponent();
            this.managerTool = managerTool;
        }

        private void NewTrigger_Load(object sender, EventArgs e)
        {

        }

        private void buttonCrearTrigger_Click(object sender, EventArgs e)
        {
            var Query =
                "CREATE TRIGGER"+this.textBoxTabla+this.listBoxEventos.GetSelected(0)+ " {UPDATE|INSERT|DELETE}ON nombre_de_la_tabla]FOR EACH ROW";

            string evento;
            string Accion;
            MessageBox.Show(Query);
            foreach (string s in listBoxEventos.Items)
            {
                
                //do stuff with (s);
                
            }
        }
    }
}
