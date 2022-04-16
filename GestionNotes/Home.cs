﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ModelApp.Connection.isConnected)
                new Gestion_Etudiants.Gestion_Etudiants().ShowDialog();
            else
            {
                MessageBox.Show(
                    "No Connection to the database was established, please connect first",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                new Connection().ShowDialog();
            }
        }
        
        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ModelApp.Connection.isConnected)
                new Gestion_Notes.Gestion_Notes() { Owner = this }.ShowDialog();
            else
            {
                MessageBox.Show(
                    "No Connection to the database was established, please connect first",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                new Connection().ShowDialog();
            }
        }

        private void billanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ModelApp.Connection.isConnected)
                new Bilan_Annuel.Bilan_Annuel().ShowDialog();
            else
            {
                MessageBox.Show(
                    "No Connection to the database was established, please connect first",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                new Connection().ShowDialog();
            }
        }

        private void filiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ModelApp.Connection.isConnected)
                new Gestion_Filieres.Gestion_Filieres().ShowDialog();
            else
            {
                MessageBox.Show(
                    "No Connection to the database was established, please connect first",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                new Connection().ShowDialog();
            }
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ModelApp.Connection.isConnected)
                new Consultation_Notes.Consultation_Notes().ShowDialog();
            else
            {
                MessageBox.Show(
                    "No Connection to the database was established, please connect first",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                new Connection().ShowDialog();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

            menuStrip1.Renderer = new MenuStripRenderer();
            Color themeColor = WinTheme.GetAccentColor();

            this.BackColor = Color.FromArgb(240, ControlPaint.Dark(themeColor, 0.7f));
            menuStrip1.BackColor = Color.FromArgb(254, themeColor);
            panel_bg.BackColor = Color.FromArgb(50, Color.Black);

            //MARGINS margins = new MARGINS();
            //margins.Top = Height;
            //margins.Left = Left;
            //Console.WriteLine("SetAero: 7 = {0}, 10 = {1}",
            //DllHelper.SetAero7(this.Handle, margins),
            //DllHelper.SetAero10(this.Handle));

            Console.WriteLine("SetAero: 10 = {0}",
            DllHelper.SetAero10(this.Handle));

            if (Debugger.IsAttached && (bool)GestionNotes.Properties.Settings.Default["reset"])
                GestionNotes.Properties.Settings.Default.Reset();
            try
            {
                ModelApp.Connection.Connect(GestionNotes.Properties.Settings.Default["conString"].ToString(), GestionNotes.Properties.Settings.Default["conServer"].ToString());
            }
            catch(Exception)
            {
                new Connection().ShowDialog();
            }

            
        }

        private void bg_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Connection().ShowDialog();
        }
    }
}
