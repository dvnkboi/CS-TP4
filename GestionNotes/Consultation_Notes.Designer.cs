
namespace Consultation_des_notes
{
    partial class Consultation_des_notes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_moyenne_de_la_classe = new System.Windows.Forms.TextBox();
            this.comboBox_filiere = new System.Windows.Forms.ComboBox();
            this.comboBox_matiere = new System.Windows.Forms.ComboBox();
            this.comboBox_niveau = new System.Windows.Forms.ComboBox();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filière";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matière";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Niveau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 450);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Moyenne de la classe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // text_moyenne_de_la_classe
            // 
            this.text_moyenne_de_la_classe.Location = new System.Drawing.Point(411, 447);
            this.text_moyenne_de_la_classe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_moyenne_de_la_classe.Name = "text_moyenne_de_la_classe";
            this.text_moyenne_de_la_classe.Size = new System.Drawing.Size(171, 23);
            this.text_moyenne_de_la_classe.TabIndex = 4;
            // 
            // comboBox_filiere
            // 
            this.comboBox_filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filiere.FormattingEnabled = true;
            this.comboBox_filiere.Location = new System.Drawing.Point(160, 52);
            this.comboBox_filiere.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_filiere.Name = "comboBox_filiere";
            this.comboBox_filiere.Size = new System.Drawing.Size(140, 23);
            this.comboBox_filiere.TabIndex = 5;
            // 
            // comboBox_matiere
            // 
            this.comboBox_matiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_matiere.FormattingEnabled = true;
            this.comboBox_matiere.Location = new System.Drawing.Point(666, 52);
            this.comboBox_matiere.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_matiere.Name = "comboBox_matiere";
            this.comboBox_matiere.Size = new System.Drawing.Size(140, 23);
            this.comboBox_matiere.TabIndex = 6;
            this.comboBox_matiere.SelectedIndexChanged += new System.EventHandler(this.comboBox_matiere_SelectedIndexChanged);
            // 
            // comboBox_niveau
            // 
            this.comboBox_niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_niveau.FormattingEnabled = true;
            this.comboBox_niveau.Location = new System.Drawing.Point(411, 52);
            this.comboBox_niveau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_niveau.Name = "comboBox_niveau";
            this.comboBox_niveau.Size = new System.Drawing.Size(140, 23);
            this.comboBox_niveau.TabIndex = 7;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(387, 105);
            this.btn_rechercher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(177, 36);
            this.btn_rechercher.TabIndex = 8;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.nom,
            this.prenom,
            this.note});
            this.dataGridView1.Location = new System.Drawing.Point(14, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(905, 292);
            this.dataGridView1.TabIndex = 9;
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenom.HeaderText = "prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // note
            // 
            this.note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // Consultation_des_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.comboBox_niveau);
            this.Controls.Add(this.comboBox_matiere);
            this.Controls.Add(this.comboBox_filiere);
            this.Controls.Add(this.text_moyenne_de_la_classe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Consultation_des_notes";
            this.Text = "Consultation des notes";
            this.Load += new System.EventHandler(this.Consultation_des_notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_moyenne_de_la_classe;
        private System.Windows.Forms.ComboBox comboBox_filiere;
        private System.Windows.Forms.ComboBox comboBox_matiere;
        private System.Windows.Forms.ComboBox comboBox_niveau;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}

