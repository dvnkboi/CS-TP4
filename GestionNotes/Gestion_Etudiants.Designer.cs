﻿
namespace Gestion_Etudiants
{
    partial class Gestion_Etudiants
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
            this.label5 = new System.Windows.Forms.Label();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_code = new System.Windows.Forms.TextBox();
            this.text_prenom = new System.Windows.Forms.TextBox();
            this.check_code = new System.Windows.Forms.CheckBox();
            this.check_nom = new System.Windows.Forms.CheckBox();
            this.check_prenom = new System.Windows.Forms.CheckBox();
            this.check_filiere = new System.Windows.Forms.CheckBox();
            this.check_niveau = new System.Windows.Forms.CheckBox();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.btn_gestionNotes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodeElev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_Fil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text_filiere = new System.Windows.Forms.ComboBox();
            this.text_niveau = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filière";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Niveau";
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(103, 62);
            this.text_nom.Margin = new System.Windows.Forms.Padding(2);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(157, 23);
            this.text_nom.TabIndex = 1;
            // 
            // text_code
            // 
            this.text_code.Location = new System.Drawing.Point(103, 27);
            this.text_code.Margin = new System.Windows.Forms.Padding(2);
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(157, 23);
            this.text_code.TabIndex = 2;
            this.text_code.TextChanged += new System.EventHandler(this.text_code_TextChanged);
            // 
            // text_prenom
            // 
            this.text_prenom.Location = new System.Drawing.Point(103, 94);
            this.text_prenom.Margin = new System.Windows.Forms.Padding(2);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(157, 23);
            this.text_prenom.TabIndex = 1;
            // 
            // check_code
            // 
            this.check_code.AutoSize = true;
            this.check_code.Location = new System.Drawing.Point(286, 28);
            this.check_code.Margin = new System.Windows.Forms.Padding(2);
            this.check_code.Name = "check_code";
            this.check_code.Size = new System.Drawing.Size(15, 14);
            this.check_code.TabIndex = 3;
            this.check_code.UseVisualStyleBackColor = true;
            // 
            // check_nom
            // 
            this.check_nom.AutoSize = true;
            this.check_nom.Location = new System.Drawing.Point(286, 63);
            this.check_nom.Margin = new System.Windows.Forms.Padding(2);
            this.check_nom.Name = "check_nom";
            this.check_nom.Size = new System.Drawing.Size(15, 14);
            this.check_nom.TabIndex = 3;
            this.check_nom.UseVisualStyleBackColor = true;
            // 
            // check_prenom
            // 
            this.check_prenom.AutoSize = true;
            this.check_prenom.Location = new System.Drawing.Point(286, 95);
            this.check_prenom.Margin = new System.Windows.Forms.Padding(2);
            this.check_prenom.Name = "check_prenom";
            this.check_prenom.Size = new System.Drawing.Size(15, 14);
            this.check_prenom.TabIndex = 3;
            this.check_prenom.UseVisualStyleBackColor = true;
            // 
            // check_filiere
            // 
            this.check_filiere.AutoSize = true;
            this.check_filiere.Location = new System.Drawing.Point(286, 126);
            this.check_filiere.Margin = new System.Windows.Forms.Padding(2);
            this.check_filiere.Name = "check_filiere";
            this.check_filiere.Size = new System.Drawing.Size(15, 14);
            this.check_filiere.TabIndex = 3;
            this.check_filiere.UseVisualStyleBackColor = true;
            // 
            // check_niveau
            // 
            this.check_niveau.AutoSize = true;
            this.check_niveau.Location = new System.Drawing.Point(286, 157);
            this.check_niveau.Margin = new System.Windows.Forms.Padding(2);
            this.check_niveau.Name = "check_niveau";
            this.check_niveau.Size = new System.Drawing.Size(15, 14);
            this.check_niveau.TabIndex = 3;
            this.check_niveau.UseVisualStyleBackColor = true;
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(366, 25);
            this.btn_nouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(149, 22);
            this.btn_nouveau.TabIndex = 4;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(366, 59);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(149, 22);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(366, 94);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(149, 20);
            this.btn_modifier.TabIndex = 6;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(366, 121);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(149, 20);
            this.btn_supprimer.TabIndex = 7;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(366, 151);
            this.btn_rechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(149, 22);
            this.btn_rechercher.TabIndex = 8;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            // 
            // btn_gestionNotes
            // 
            this.btn_gestionNotes.Location = new System.Drawing.Point(366, 181);
            this.btn_gestionNotes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gestionNotes.Name = "btn_gestionNotes";
            this.btn_gestionNotes.Size = new System.Drawing.Size(202, 22);
            this.btn_gestionNotes.TabIndex = 9;
            this.btn_gestionNotes.Text = "Gestion des notes";
            this.btn_gestionNotes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeElev,
            this.nom,
            this.prenom,
            this.niveau,
            this.code_Fil});
            this.dataGridView1.Location = new System.Drawing.Point(10, 232);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(645, 184);
            this.dataGridView1.TabIndex = 10;
            // 
            // CodeElev
            // 
            this.CodeElev.HeaderText = "CodeElev";
            this.CodeElev.MinimumWidth = 8;
            this.CodeElev.Name = "CodeElev";
            this.CodeElev.Width = 150;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            this.nom.Width = 150;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.MinimumWidth = 8;
            this.prenom.Name = "prenom";
            this.prenom.Width = 150;
            // 
            // niveau
            // 
            this.niveau.HeaderText = "niveau";
            this.niveau.MinimumWidth = 8;
            this.niveau.Name = "niveau";
            this.niveau.Width = 150;
            // 
            // code_Fil
            // 
            this.code_Fil.HeaderText = "code_fil";
            this.code_Fil.MinimumWidth = 8;
            this.code_Fil.Name = "code_Fil";
            this.code_Fil.Width = 150;
            // 
            // text_filiere
            // 
            this.text_filiere.FormattingEnabled = true;
            this.text_filiere.Location = new System.Drawing.Point(103, 124);
            this.text_filiere.Margin = new System.Windows.Forms.Padding(2);
            this.text_filiere.Name = "text_filiere";
            this.text_filiere.Size = new System.Drawing.Size(157, 23);
            this.text_filiere.TabIndex = 11;
            // 
            // text_niveau
            // 
            this.text_niveau.FormattingEnabled = true;
            this.text_niveau.Location = new System.Drawing.Point(103, 154);
            this.text_niveau.Margin = new System.Windows.Forms.Padding(2);
            this.text_niveau.Name = "text_niveau";
            this.text_niveau.Size = new System.Drawing.Size(157, 23);
            this.text_niveau.TabIndex = 11;
            // 
            // Gestion_Etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 425);
            this.Controls.Add(this.text_niveau);
            this.Controls.Add(this.text_filiere);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_gestionNotes);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.check_niveau);
            this.Controls.Add(this.check_filiere);
            this.Controls.Add(this.check_prenom);
            this.Controls.Add(this.check_nom);
            this.Controls.Add(this.check_code);
            this.Controls.Add(this.text_code);
            this.Controls.Add(this.text_prenom);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_Etudiants";
            this.Text = "Gestion des étudiants";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_code;
        private System.Windows.Forms.TextBox text_prenom;
        private System.Windows.Forms.CheckBox check_code;
        private System.Windows.Forms.CheckBox check_nom;
        private System.Windows.Forms.CheckBox check_prenom;
        private System.Windows.Forms.CheckBox check_filiere;
        private System.Windows.Forms.CheckBox check_niveau;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_gestionNotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeElev;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_Fil;
        private System.Windows.Forms.ComboBox text_filiere;
        private System.Windows.Forms.ComboBox text_niveau;
    }
}
