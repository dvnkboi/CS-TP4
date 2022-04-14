using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using GestionNotes;
using GestionNotes.utils;

namespace Home
{
    public partial class Home : Form
    {
        public Home()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
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
            new Gestion_Notes.Gestion_Notes() { Owner = this }.ShowDialog();
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

        private void Home_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MenuStripRenderer();

            this.BackColor = Color.FromArgb(220, Color.Black);
            menuStrip1.BackColor = Color.FromArgb(254, 16,16,16);

            MARGINS margins = new MARGINS();
            margins.Top = Height;
            margins.Left = Left;
            Console.WriteLine("SetAero: 7 = {0}, 10 = {1}",
            DllHelper.SetAero7(this.Handle, margins),
            DllHelper.SetAero10(this.Handle));
        }

        private void bg_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
