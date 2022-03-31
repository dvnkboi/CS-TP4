using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionNotes;


namespace Home
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
            new Gestion_Notes.Gestion_Notes().ShowDialog();
        }

        private void billanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bilan_Annuel.Bilan_Annuel().ShowDialog();
        }

        private void filiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Gestion_Filieres.Gestion_Filieres().ShowDialog();
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Consultation_Notes.Consultation_Notes().ShowDialog();
        }
    }
}
