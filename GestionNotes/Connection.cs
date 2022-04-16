using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string cstr = ModelApp.Connection.concatStr(text_host.Text,comboBox_server.Text,text_user.Text,text_pass.Text,text_db.Text,text_opt.Lines);

            ConProgress progress = new ConProgress() { Owner = this };
            progress.conString = cstr;
            progress.migrate = check_migrate.Checked;
            progress.server = comboBox_server.Text;

            progress.ShowDialog();
        }

        private void check_migrate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
