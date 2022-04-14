using GestionNotes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GestionNotes.utils;
using ModelApp;
using System.IO;

namespace Gestion_Filieres
{
    public partial class Gestion_Filieres : Form
    {
        private List<dynamic> filieres;
        private Filiere selectedFil;
        private bool tableSet;


        public Gestion_Filieres()
        {
            filieres = Filiere.All<Filiere>();
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

        private void Gestion_Filieres_Load(object sender, EventArgs e)
        {
            table_filiere.DataSource = filieres;

            text_code.Enabled = false;
            text_designation.Enabled = false;
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
            text_designation.Enabled = !text_designation.Enabled;
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            text_code.Text = "";
            text_designation.Text = "";
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            opDone("");
            if (text_code.Text == "") return;

            Filiere existanceCheck = (from Filiere fil in Filiere.All<Filiere>()
                                      where fil.code == text_code.Text
                                      select fil).FirstOrDefault<Filiere>();

            selectedFil = new Filiere
            {
                id = existanceCheck != null ? existanceCheck.id : Generator.generateID(),
                code = text_code.Text,
                designation = text_designation.Text,
            };

            selectedFil.save();

            resetTable();
            selectCurrent();
            opDone("Saved");
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            opDone("");
            selectedFil.delete();
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

            selectedFil = (Filiere)Filiere.select<Filiere>(criteria).FirstOrDefault();

            if (selectedFil == null)
            {
                MessageBox.Show(
                    "No Student found with the given criteria",
                    "No result found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            setInputs(selectedFil.code, selectedFil.designation);
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
            if (text_designation.Enabled == true && text_designation.Text != "") criteria.Add("designation", text_designation.Text);
            return criteria;
        }

        private void setInputs(string cod, string des)
        {
            text_code.Text = cod;
            text_designation.Text = des;
        }

        private void table_eleve_SelectionChanged(object sender, EventArgs e)
        {
            if (tableSet) return;
            selectedFil = (Filiere)table_filiere.Rows?[table_filiere.SelectedCells.Count > 0 ? table_filiere.SelectedCells[0].RowIndex : 0].DataBoundItem;
            setInputs(selectedFil.code, selectedFil.designation);
        }

        private void resetTable()
        {
            filieres = Filiere.All<Filiere>();
            table_filiere.DataSource = null;
            table_filiere.DataSource = filieres;
        }

        private void selectCurrent()
        {
            tableSet = true;
            table_filiere.ClearSelection();
            table_filiere.Rows
                .OfType<DataGridViewRow>()
                 .Where(elv => (string)elv.Cells["code"].Value == selectedFil.code)
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
                string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "filieres.xlsx");
                ConvEngine.CreateXLS<Filiere>((from Filiere f in filieres select f).ToList<Filiere>(), docPath);

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
