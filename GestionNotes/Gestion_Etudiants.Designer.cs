
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
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.btn_gestionNotes = new System.Windows.Forms.Button();
            this.table_eleve = new System.Windows.Forms.DataGridView();
            this.text_filiere = new System.Windows.Forms.ComboBox();
            this.text_niveau = new System.Windows.Forms.ComboBox();
            this.label_state = new System.Windows.Forms.Label();
            this.export_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.seperator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_eleve)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
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
            this.label2.Location = new System.Drawing.Point(42, 89);
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
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filière";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Niveau";
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(80, 86);
            this.text_nom.Margin = new System.Windows.Forms.Padding(2);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(157, 23);
            this.text_nom.TabIndex = 1;
            // 
            // text_code
            // 
            this.text_code.Location = new System.Drawing.Point(80, 51);
            this.text_code.Margin = new System.Windows.Forms.Padding(2);
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(157, 23);
            this.text_code.TabIndex = 2;
            this.text_code.TextChanged += new System.EventHandler(this.text_code_TextChanged);
            // 
            // text_prenom
            // 
            this.text_prenom.Location = new System.Drawing.Point(80, 118);
            this.text_prenom.Margin = new System.Windows.Forms.Padding(2);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(157, 23);
            this.text_prenom.TabIndex = 1;
            // 
            // check_code
            // 
            this.check_code.AutoSize = true;
            this.check_code.Location = new System.Drawing.Point(241, 55);
            this.check_code.Margin = new System.Windows.Forms.Padding(2);
            this.check_code.Name = "check_code";
            this.check_code.Size = new System.Drawing.Size(15, 14);
            this.check_code.TabIndex = 3;
            this.check_code.UseVisualStyleBackColor = true;
            this.check_code.CheckedChanged += new System.EventHandler(this.check_code_CheckedChanged);
            // 
            // check_nom
            // 
            this.check_nom.AutoSize = true;
            this.check_nom.Location = new System.Drawing.Point(241, 90);
            this.check_nom.Margin = new System.Windows.Forms.Padding(2);
            this.check_nom.Name = "check_nom";
            this.check_nom.Size = new System.Drawing.Size(15, 14);
            this.check_nom.TabIndex = 3;
            this.check_nom.UseVisualStyleBackColor = true;
            this.check_nom.CheckedChanged += new System.EventHandler(this.check_nom_CheckedChanged);
            // 
            // check_prenom
            // 
            this.check_prenom.AutoSize = true;
            this.check_prenom.Location = new System.Drawing.Point(241, 122);
            this.check_prenom.Margin = new System.Windows.Forms.Padding(2);
            this.check_prenom.Name = "check_prenom";
            this.check_prenom.Size = new System.Drawing.Size(15, 14);
            this.check_prenom.TabIndex = 3;
            this.check_prenom.UseVisualStyleBackColor = true;
            this.check_prenom.CheckedChanged += new System.EventHandler(this.check_prenom_CheckedChanged);
            // 
            // check_filiere
            // 
            this.check_filiere.AutoSize = true;
            this.check_filiere.Location = new System.Drawing.Point(241, 152);
            this.check_filiere.Margin = new System.Windows.Forms.Padding(2);
            this.check_filiere.Name = "check_filiere";
            this.check_filiere.Size = new System.Drawing.Size(15, 14);
            this.check_filiere.TabIndex = 3;
            this.check_filiere.UseVisualStyleBackColor = true;
            this.check_filiere.CheckedChanged += new System.EventHandler(this.check_filiere_CheckedChanged);
            // 
            // check_niveau
            // 
            this.check_niveau.AutoSize = true;
            this.check_niveau.Location = new System.Drawing.Point(241, 182);
            this.check_niveau.Margin = new System.Windows.Forms.Padding(2);
            this.check_niveau.Name = "check_niveau";
            this.check_niveau.Size = new System.Drawing.Size(15, 14);
            this.check_niveau.TabIndex = 3;
            this.check_niveau.UseVisualStyleBackColor = true;
            this.check_niveau.CheckedChanged += new System.EventHandler(this.check_niveau_CheckedChanged);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(506, 51);
            this.btn_nouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(149, 28);
            this.btn_nouveau.TabIndex = 4;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(506, 82);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(149, 28);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Sauvgarder";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(506, 113);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(149, 28);
            this.btn_supprimer.TabIndex = 7;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(506, 144);
            this.btn_rechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(149, 28);
            this.btn_rechercher.TabIndex = 8;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // btn_gestionNotes
            // 
            this.btn_gestionNotes.Location = new System.Drawing.Point(506, 201);
            this.btn_gestionNotes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gestionNotes.Name = "btn_gestionNotes";
            this.btn_gestionNotes.Size = new System.Drawing.Size(149, 27);
            this.btn_gestionNotes.TabIndex = 9;
            this.btn_gestionNotes.Text = "Gestion des notes";
            this.btn_gestionNotes.UseVisualStyleBackColor = true;
            this.btn_gestionNotes.Click += new System.EventHandler(this.btn_gestionNotes_Click);
            // 
            // table_eleve
            // 
            this.table_eleve.AllowUserToAddRows = false;
            this.table_eleve.AllowUserToDeleteRows = false;
            this.table_eleve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_eleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_eleve.Location = new System.Drawing.Point(10, 232);
            this.table_eleve.Margin = new System.Windows.Forms.Padding(2);
            this.table_eleve.Name = "table_eleve";
            this.table_eleve.ReadOnly = true;
            this.table_eleve.RowHeadersWidth = 62;
            this.table_eleve.RowTemplate.Height = 28;
            this.table_eleve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_eleve.Size = new System.Drawing.Size(668, 177);
            this.table_eleve.TabIndex = 10;
            this.table_eleve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_eleve_CellContentClick);
            this.table_eleve.SelectionChanged += new System.EventHandler(this.table_eleve_SelectionChanged);
            // 
            // text_filiere
            // 
            this.text_filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_filiere.FormattingEnabled = true;
            this.text_filiere.Location = new System.Drawing.Point(80, 148);
            this.text_filiere.Margin = new System.Windows.Forms.Padding(2);
            this.text_filiere.Name = "text_filiere";
            this.text_filiere.Size = new System.Drawing.Size(157, 23);
            this.text_filiere.TabIndex = 11;
            this.text_filiere.SelectedIndexChanged += new System.EventHandler(this.text_filiere_SelectedIndexChanged);
            // 
            // text_niveau
            // 
            this.text_niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_niveau.FormattingEnabled = true;
            this.text_niveau.Location = new System.Drawing.Point(80, 178);
            this.text_niveau.Margin = new System.Windows.Forms.Padding(2);
            this.text_niveau.Name = "text_niveau";
            this.text_niveau.Size = new System.Drawing.Size(157, 23);
            this.text_niveau.TabIndex = 11;
            // 
            // label_state
            // 
            this.label_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(642, 418);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(0, 15);
            this.label_state.TabIndex = 13;
            this.label_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(10, 414);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(75, 23);
            this.export_btn.TabIndex = 14;
            this.export_btn.Text = "export";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.label6.Size = new System.Drawing.Size(196, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gestion Des Etudiants";
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.seperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seperator.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.seperator.Location = new System.Drawing.Point(526, 188);
            this.seperator.Margin = new System.Windows.Forms.Padding(0);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(110, 2);
            this.seperator.TabIndex = 16;
            // 
            // Gestion_Etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 442);
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.text_niveau);
            this.Controls.Add(this.text_filiere);
            this.Controls.Add(this.table_eleve);
            this.Controls.Add(this.btn_gestionNotes);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.btn_supprimer);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(705, 481);
            this.MinimumSize = new System.Drawing.Size(705, 481);
            this.Name = "Gestion_Etudiants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.Gestion_Etudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_eleve)).EndInit();
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
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_gestionNotes;
        private System.Windows.Forms.DataGridView table_eleve;
        private System.Windows.Forms.ComboBox text_filiere;
        private System.Windows.Forms.ComboBox text_niveau;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label seperator;
    }
}

