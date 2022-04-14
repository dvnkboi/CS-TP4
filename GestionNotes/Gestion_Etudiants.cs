using GestionNotes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GestionNotes.utils;
using System.IO;
using ModelApp;

namespace Gestion_Etudiants
{
    public partial class Gestion_Etudiants : Form
    {
        List<dynamic> elvs = null;
        List<dynamic> fil = null;
        List<dynamic> niv = null;
        private Eleve selectedElv;
        private bool tableSet;

        public Gestion_Etudiants()
        {
            elvs = Eleve.All<Eleve>();
            fil = Filiere.All<Filiere>();
            niv = (from m in Module.All<Module>()
                   select m.niveau).Distinct().ToList();
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
            text_niveau.Items.AddRange(niv.ToArray());

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
            opDone("");
            if (text_code.Text == "" || text_filiere.Text == "") return;

            Eleve existanceCheck = (from Eleve a in elvs
                                    where a.code == text_code.Text
                                    select a).FirstOrDefault<Eleve>();

            selectedElv = new Eleve
            {
                id = existanceCheck != null ? existanceCheck.id : Generator.generateID(),
                code = text_code.Text,
                nom = text_nom.Text,
                prenom = text_prenom.Text,
                code_fil = text_filiere.Text,
                niveau = int.Parse(text_niveau.Text)
            };

            selectedElv.save();

            resetTable();
            selectCurrent();
            opDone("Saved");
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            opDone("");
            selectedElv.delete();
            resetTable();
            opDone("Deleted");
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> criteria = GenCriteria();

            if (criteria.Count == 0)
            {
                MessageBox.Show(
                    "No search criteria was given",
                    "Empty criteria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            selectedElv = (Eleve)Eleve.select<Eleve>(criteria).FirstOrDefault();

            if (selectedElv == null)
            {
                MessageBox.Show(
                    "No Student found with the given criteria",
                    "No result found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            setInputs(selectedElv.code, selectedElv.nom, selectedElv.prenom, selectedElv.code_fil, selectedElv.niveau.ToString());
            selectCurrent();
        }

        private Dictionary<string, object> GenCriteria()
        {
            Dictionary<string, object> criteria = new Dictionary<string, object>();
            if (text_code.Enabled == true && text_code.Text != "")
            {
                criteria.Add("code", text_code.Text);
                return criteria;
            };
            if (text_nom.Enabled == true && text_nom.Text != "") criteria.Add("nom", text_nom.Text);
            if (text_prenom.Enabled == true && text_prenom.Text != "") criteria.Add("prenom", text_prenom.Text);
            if (text_niveau.Enabled == true && text_niveau.Text != "") criteria.Add("niveau", text_niveau.Text);
            if (text_filiere.Enabled == true && text_filiere.Text != "") criteria.Add("code_fil", text_filiere.Text);
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
            if (tableSet) return;
            selectedElv = (Eleve)table_eleve.Rows?[table_eleve.SelectedCells.Count > 0 ? table_eleve.SelectedCells[0].RowIndex : 0].DataBoundItem;
            setInputs(selectedElv.code, selectedElv.nom, selectedElv.prenom, selectedElv.code_fil, selectedElv.niveau.ToString());
        }

        private void btn_gestionNotes_Click(object sender, EventArgs e)
        {
            Gestion_Notes.Gestion_Notes gn = new Gestion_Notes.Gestion_Notes() { Owner = this };
            gn.text_code_eleve.Text = selectedElv.code;
            gn.ShowDialog();
        }

        public void resetTable()
        {
            elvs = Eleve.All<Eleve>();
            table_eleve.DataSource = null;
            table_eleve.DataSource = elvs;
        }

        private void selectCurrent()
        {
            tableSet = true;
            table_eleve.ClearSelection();
            table_eleve.Rows
                .OfType<DataGridViewRow>()
                 .Where(elv => (string)elv.Cells["code"].Value == selectedElv.code)
                 .ToArray<DataGridViewRow>()[0]
                 .Selected = true;
            tableSet = false;
        }

        private void opDone(string msg = "Done")
        {
            label_state.Text = msg;
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"etudiants.xlsx");
                ConvEngine.CreateXLS<Eleve>((from Eleve el in elvs select el).ToList<Eleve>(), docPath);

                MessageBox.Show(
                        $"Exported excel sheet at {docPath}",
                        "Export",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                    );
            }
            catch (Exception)
            {
                MessageBox.Show(
                        $"Export failed, check path or provided data",
                        "Export error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }
    }
}
