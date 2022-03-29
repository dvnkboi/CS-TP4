using GestionNotes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Etudiants
{
    public partial class Gestion_Etudiants : Form
    {
        List<dynamic> elvs = null;
        List<dynamic> fil = null;
        List<dynamic> niv = null;
        public Gestion_Etudiants()
        {
            elvs = Eleve.All<Eleve>();
            fil = Filiere.All<Filiere>();
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_filiere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gestion_Etudiants_Load(object sender, EventArgs e)
        {
            table_eleve.DataSource = elvs;
            text_filiere.Items.AddRange(fil.Select(fil => fil.code).ToArray());

            text_code.Enabled = false;
            text_filiere.Enabled = false;
            text_niveau.Enabled = false;
            text_nom.Enabled = false;
            text_prenom.Enabled = false;

        }

        private void table_eleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void check_code_CheckedChanged(object sender, EventArgs e)
        {
            text_code.Enabled = !text_code.Enabled;
        }

        private void check_nom_CheckedChanged(object sender, EventArgs e)
        {
            text_nom.Enabled = !text_nom.Enabled;
        }

        private void check_prenom_CheckedChanged(object sender, EventArgs e)
        {
            text_prenom.Enabled = !text_prenom.Enabled;
        }

        private void check_filiere_CheckedChanged(object sender, EventArgs e)
        {
            text_filiere.Enabled = !text_filiere.Enabled;
        }

        private void check_niveau_CheckedChanged(object sender, EventArgs e)
        {
            text_niveau.Enabled = !text_niveau.Enabled;
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            text_code.Text = "";
            text_nom.Text = "";
            text_prenom.Text = "";
            text_filiere.Text = "";
            text_niveau.Text = "";
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (text_code.Text == "" || text_filiere.Text == "") return;

            int nextInt = (from Eleve a in elvs
                           orderby a.id descending
                           select a.id).FirstOrDefault<int>() + 1;

            Eleve existanceCheck = (from Eleve a in elvs
                                    where a.code == text_code.Text
                                    select a).FirstOrDefault<Eleve>();

            Eleve elv = new Eleve
            {
                id = existanceCheck != null ? existanceCheck.id : nextInt,
                code = text_code.Text,
                nom = text_nom.Text,
                prenom = text_prenom.Text,
                code_fil = text_filiere.Text,
                niveau = text_niveau.Text
            };
            elv.save();
            elvs = Eleve.All<Eleve>();
            table_eleve.DataSource = null;
            table_eleve.DataSource = elvs;
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            Eleve elv = (Eleve)Eleve.select<Eleve>(GenCriteria()).First();
            if (elv != null)
            {
                elv.delete();
                elvs = Eleve.All<Eleve>();
                table_eleve.DataSource = null;
                table_eleve.DataSource = elvs;
            }
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            Eleve elv = (Eleve)Eleve.select<Eleve>(GenCriteria()).First();
            setInputs(elv.code, elv.nom, elv.prenom, elv.code_fil, elv.niveau);
        }

        private Dictionary<string, object> GenCriteria()
        {
            Dictionary<string, object> criteria = new Dictionary<string, object>();
            if (text_code.Enabled == true) criteria.Add("code", text_code.Text);
            if (text_nom.Enabled == true) criteria.Add("nom", text_nom.Text);
            if (text_prenom.Enabled == true) criteria.Add("prenom", text_prenom.Text);
            if (text_niveau.Enabled == true) criteria.Add("niveau", text_niveau.Text);
            if (text_filiere.Enabled == true) criteria.Add("code_fil", text_filiere.Text);
            return criteria;
        }

        private void setInputs(string cod, string nom, string pre, string fil, string niv)
        {
            text_code.Text = cod;
            text_nom.Text = nom;
            text_prenom.Text = pre;
            text_filiere.Text = fil;
            text_niveau.Text = niv;
        }

        private void table_eleve_SelectionChanged(object sender, EventArgs e)
        {
            Eleve elv = (Eleve)table_eleve.Rows?[table_eleve.SelectedCells.Count > 0 ? table_eleve.SelectedCells[0].RowIndex : 0].DataBoundItem;
            setInputs(elv.code, elv.nom, elv.prenom, elv.code_fil, elv.niveau);
        }

        private void btn_gestionNotes_Click(object sender, EventArgs e)
        {
            Gestion_des_notes.Gestion_Notes gn = new Gestion_des_notes.Gestion_Notes();
            gn.text_code_eleve.Text = ((Eleve)table_eleve.Rows?[table_eleve.SelectedCells.Count > 0 ? table_eleve.SelectedCells[0].RowIndex : 0].DataBoundItem).code;
            gn.ShowDialog();
        }
    }
}
