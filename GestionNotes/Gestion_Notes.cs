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

namespace Gestion_des_notes
{
    public partial class Gestion_Notes : Form
    {
        private List<Matiere> matieres;
        private Matiere selectedMat;
        private Eleve selectedElv;
        private Note selectedNote;

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
            int unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            Note note = new Note { id = unixTimestamp, code_mat = selectedMat.code, code_elv = selectedElv.code, note = text_note.Text != "" ? float.Parse(text_note.Text) : 0 };
            note.save();
        }

        private void comboBox_matiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMat = (from Matiere m in matieres
                           where comboBox_matiere.Text == m.code
                           select m).FirstOrDefault();

            selectedNote = (Note)Note.select<Note>(new Dictionary<string, object> { { "code_mat", selectedMat.code }, { "code_elv", selectedElv.code } }).FirstOrDefault();

            text_note.Text = selectedNote?.note.ToString();
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> criteria = new Dictionary<string, object>();
            criteria.Add("code", text_code_eleve.Text);
            selectedElv = (Eleve)Eleve.select<Eleve>(criteria).FirstOrDefault();
            if (selectedElv == null) return;

            matieres.Clear();
            comboBox_matiere.Items.Clear();

            string code_fil = selectedElv.code_fil;

            criteria.Clear();
            criteria.Add("code_fil", code_fil);

            List<dynamic> modules = Module.select<Module>(criteria);

            foreach (Module mod in modules)
            {
                List<dynamic> mats = Matiere.select<Matiere>(new Dictionary<string, object> { { "code_mod", mod.code } });
                foreach (Matiere mat in mats)
                {
                    matieres.Add(mat);
                }
            }

            comboBox_matiere.Items.AddRange(matieres.Select(mat => mat.code).ToArray());
            comboBox_matiere.SelectedIndex = 0;

            comboBox_matiere_SelectedIndexChanged(sender, e);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            selectedNote.delete();
            text_note.Text = "";
        }
    }
}
