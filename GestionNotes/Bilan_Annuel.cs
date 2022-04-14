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

namespace Bilan_Annuel
{
    public partial class Bilan_Annuel : Form
    {
        private List<dynamic> filieres;
        private List<dynamic> eleves;
        private List<dynamic> niveaus;
        private List<dynamic> bilan;
        private Eleve selectedElv;
        private Filiere selectedFil;
        private int? selectedNiveau;

        public Bilan_Annuel()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Bilan_Annuel_Load(object sender, EventArgs e)
        {
            filieres = Filiere.All<Filiere>();

            string[] filCodes = (from Filiere fil in filieres
                                 select fil.code).ToArray();

            comboBox_filiere.Items.AddRange(filCodes);

            comboBox_etudiant.Enabled = false;
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

        private void comboBox_etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedElv = (from Eleve elv in eleves
                           where elv.nom == comboBox_etudiant.Text.Split(" - ")[0] && elv.prenom == comboBox_etudiant.Text.Split(" - ")[1]
                           select elv).FirstOrDefault();

        }

        private void comboBox_niveau_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedNiveau = int.Parse(comboBox_niveau.Text);

            comboBox_etudiant.Items.Clear();

            eleves = (from elv in Eleve.@select<Eleve>(new Dictionary<string, object>() { { "code_fil", selectedFil.code }, { "niveau", selectedNiveau } })
                      select elv).ToList();

            string[] eleveNames = (from Eleve elv in eleves
                                   select $"{elv.nom} - {elv.prenom}").ToArray();

            comboBox_etudiant.Items.AddRange(eleveNames);
            comboBox_etudiant.Enabled = true;
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            if (selectedElv == null || selectedFil == null || selectedNiveau == null) return;

            List<Module> modules = (from Module mod in Module.@select<Module>(new Dictionary<string, object>() { { "code_fil", selectedFil.code } })
                                    select mod
                             ).ToList();

            Dictionary<string, List<Matiere>> matieres = new Dictionary<string, List<Matiere>>();
            bilan = new List<dynamic>();

            if (modules.Count == 0) return;

            foreach (Module mod in modules)
            {
                matieres.Add(mod.semestre, (from Matiere mat in Matiere.@select<Matiere>(new Dictionary<string, object>() { { "code_mod", mod.code } })
                                            select mat
                                          ).ToList<Matiere>());
            }

            if (matieres.Count == 0) return;

            Note noteTmp;


            foreach (KeyValuePair<string, List<Matiere>> matObj in matieres)
            {
                foreach (Matiere mat in matObj.Value)
                {
                    noteTmp = Note.@select<Note>(new Dictionary<string, object>() { { "code_mat", mat.code }, { "code_elv", selectedElv.code } }).FirstOrDefault();
                    if (noteTmp != null)
                    {
                        bilan.Add(new Bilan()
                        {
                            code_mat = mat.code,
                            designation = mat.designation,
                            semestre = matObj.Key,
                            note = noteTmp.note
                        });
                    }

                }
            }

            if (bilan.Count == 0) return;

            text_moyenne_annuelle.Text = (from Bilan bil in bilan
                                          select bil.note).Average().ToString();

            table_bilan.DataSource = null;
            table_bilan.DataSource = bilan;


        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"bilan_{comboBox_niveau.Text}_{comboBox_etudiant.Text}.xlsx");
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

        private void table_bilan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class Bilan
    {
        public string code_mat { get; set; }
        public string designation { get; set; }
        public string semestre { get; set; }
        public double note { get; set; }

    }
}

