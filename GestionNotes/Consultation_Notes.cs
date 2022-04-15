using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionNotes.Models;
using ModelApp;

namespace Consultation_Notes
{
    public partial class Consultation_Notes : Form
    {
        private List<dynamic> filieres;
        private List<dynamic> matieres;
        private List<dynamic> niveaus;
        private List<dynamic> bilan;
        private Matiere selectedMat;
        private Filiere selectedFil;
        private int? selectedNiveau;

        public Consultation_Notes()
        {
            filieres = new List<dynamic>();
            matieres = new List<dynamic>();
            niveaus = new List<dynamic>();
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Consultation_Notes_Load(object sender, EventArgs e)
        {
            filieres = Filiere.All<Filiere>();

            string[] filCodes = (from Filiere fil in filieres
                                 select fil.code).ToArray();

            comboBox_filiere.Items.AddRange(filCodes);

            comboBox_matiere.Enabled = false;
            comboBox_niveau.Enabled = false;

        }

        private void comboBox_filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFil = (from Filiere fil in filieres
                           where fil.code == comboBox_filiere.Text
                           select fil).FirstOrDefault();

            comboBox_niveau.Items.Clear();

            niveaus = (from m in Module.@select<Module>(new Dictionary<string, object>() { { "code_fil", selectedFil.code } })
                       select m.niveau).Distinct().ToList();
            comboBox_niveau.Items.AddRange(niveaus.ToArray());

            comboBox_niveau.Enabled = true;
        }

        private void comboBox_matiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMat = (from Matiere mat in matieres
                           where mat.code == comboBox_matiere.Text
                           select mat).FirstOrDefault();

        }

        private void comboBox_niveau_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedNiveau = int.Parse(comboBox_niveau.Text);

            matieres.Clear();
            comboBox_matiere.Items.Clear();

            List<dynamic> modules = (from mod in Module.@select<Module>(new Dictionary<string, object>() { { "code_fil", selectedFil.code }, { "niveau", selectedNiveau } })
                                     select mod).ToList();

            if (modules == null) return;

            foreach (Module mod in modules)
            {
                matieres.AddRange((from Matiere mat in Matiere.@select<Matiere>(new Dictionary<string, object>() { { "code_mod", mod.code } })
                                   select mat
                                          ).ToList<Matiere>());
            }

            if (matieres == null) return;

            comboBox_matiere.Items.AddRange(matieres.Select(mat => mat.code).ToArray());
            comboBox_matiere.Enabled = true;
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            if (selectedFil == null || selectedMat == null || selectedNiveau == null) return;

            bilan = new List<dynamic>();
            List<dynamic> eleves = Eleve.select<Eleve>(new Dictionary<string, object>()
            {
                {"code_fil", comboBox_filiere.Text },
                {"niveau", comboBox_niveau.Text }
            });

            if (eleves.Count == 0) return;
            if (matieres.Count == 0) return;


            Note noteTmp;


            foreach (Eleve elv in eleves)
            {
                noteTmp = Note.select<Note>(new Dictionary<string, object>() { { "code_mat", selectedMat.code }, { "code_elv", elv.code } }).FirstOrDefault();
                if (noteTmp != null)
                {
                    bilan.Add(new Bilan()
                    {
                        code = elv.code,
                        nom = elv.nom,
                        prenom = elv.prenom,
                        note = noteTmp.note
                    });
                }
            }

            if (bilan.Count == 0) return;

            text_moyenne_annuelle.Text = (from Bilan bil in bilan
                                          select bil.note).Average().ToString();

            table_consutation.DataSource = null;
            table_consutation.DataSource = bilan;


        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"consultation_{comboBox_niveau.Text}_{comboBox_matiere.Text}.xlsx");
                ConvEngine.CreateXLS<Bilan>((from Bilan b in bilan select b).ToList<Bilan>(), docPath);

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

    public class Bilan
    {
        public string code { get; set; }

        public string nom { get; set; }

        public string prenom { get; set; }

        public double note { get; set; }
    }
}