using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionNotes.Models;
using GestionNotes.utils;

namespace Gestion_Notes
{
    public partial class Gestion_Notes : Form
    {
        private List<Matiere> matieres;
        private Matiere selectedMat;
        private Eleve selectedElv;
        private Note selectedNote;
        private int init;

        public Gestion_Notes()
        {
            InitializeComponent();
            matieres = new List<Matiere>();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_Notes_Shown(object sender, EventArgs e)
        {

        }

        private void Gestion_Notes_Load(object sender, EventArgs e)
        {
            btn_rechercher_Click(sender, e);
            init++;
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            comboBox_matiere.Items.Clear();
            text_code_eleve.Text = "";
            text_note.Text = "";
            comboBox_matiere.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            opDone("");
            int unixTimestamp = selectedNote == null ? Generator.generateID() : selectedNote.id;

            try
            {
                if (float.Parse(text_note.Text) < 0 || float.Parse(text_note.Text) > 20)
                {
                    MessageBox.Show(
                        "Note cannot be above 20 or bellow 0",
                        "invalid note",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Note has to be a number",
                    "invalid note",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            selectedNote = new Note { id = unixTimestamp, code_mat = selectedMat.code, code_elv = selectedElv.code, note = text_note.Text != "" ? float.Parse(text_note.Text) : 0 };
            selectedNote.save();

            //List<dynamic> notesEtudiant = ModelApp.Model.select<Note>(new Dictionary<string, object>() { { "code_elv", selectedElv.code } });

            //if (notesEtudiant.Count == matieres.Count)
            //{
            //    double moyenne = (from Note n in notesEtudiant
            //                      select n.note).Average();



            //    Moyenne moy = new Moyenne() { code_elv = selectedElv.code, code_fil = selectedElv.code_fil, id = Generator.generateID(), moyenne = moyenne, niveau = selectedElv.niveau };

            //    moy.save();

            //    if (moyenne >= 12)
            //    {
            //        selectedElv.niveau++;
            //        selectedElv.save();
            //    }
            //}

            opDone("Saved");
        }

        private void comboBox_matiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMat = (from Matiere m in matieres
                           where comboBox_matiere.Text == m.code
                           select m).FirstOrDefault();

            selectedNote = (Note)ModelApp.Model.select<Note>(new Dictionary<string, object> { { "code_mat", selectedMat.code }, { "code_elv", selectedElv.code } }).FirstOrDefault();

            text_note.Text = selectedNote?.note.ToString();
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            if (text_code_eleve.Text == "" && init > 0)
            {
                MessageBox.Show(
                    "Student ID can't be empty",
                    "Empty criteria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            if (text_code_eleve.Text == "") return;

            Dictionary<string, object> criteria = new Dictionary<string, object>();
            criteria.Add("code", text_code_eleve.Text);
            selectedElv = (Eleve)ModelApp.Model.select<Eleve>(criteria).FirstOrDefault();
            if (selectedElv == null && init > 0)
            {
                MessageBox.Show(
                    "No Student found with this student ID",
                    "No result found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            if (selectedElv == null) return;

            matieres.Clear();
            comboBox_matiere.Items.Clear();

            string code_fil = selectedElv.code_fil;

            criteria.Clear();
            criteria.Add("code_fil", code_fil);
            criteria.Add("niveau", selectedElv.niveau);

            List<dynamic> modules = ModelApp.Model.select<Module>(criteria);

            foreach (Module mod in modules)
            {
                List<dynamic> mats = ModelApp.Model.select<Matiere>(new Dictionary<string, object> { { "code_mod", mod.code } });
                foreach (Matiere mat in mats)
                {
                    matieres.Add(mat);
                }
            }

            comboBox_matiere.Items.AddRange(matieres.Select(mat => mat.code).ToArray());
            if(comboBox_matiere.Items.Count != 0) comboBox_matiere.SelectedIndex = 0;

            comboBox_matiere_SelectedIndexChanged(sender, e);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            opDone("");
            selectedNote.delete();
            text_note.Text = "";
            opDone("Deleted");
        }

        private void opDone(string msg = "Done")
        {
            label_state.Text = msg;
        }

        private void Gestion_Notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner is Home.Home) return;
            var parent = (Gestion_Etudiants.Gestion_Etudiants) Owner;
            parent.resetTable(); 
        }

        private void seperator_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
}
