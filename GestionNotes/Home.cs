using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Gestion_Etudiants.Gestion_Etudiants().ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Gestion_des_notes.Gestion_Notes().ShowDialog();
        }
    }
}
