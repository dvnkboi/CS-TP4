
namespace Gestion_Filieres
{
    partial class Gestion_Filieres
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
            this.text_designation = new System.Windows.Forms.TextBox();
            this.text_code = new System.Windows.Forms.TextBox();
            this.check_code = new System.Windows.Forms.CheckBox();
            this.check_designation = new System.Windows.Forms.CheckBox();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.table_filiere = new System.Windows.Forms.DataGridView();
            this.label_state = new System.Windows.Forms.Label();
            this.export_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_filiere)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 61);
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
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_designation
            // 
            this.text_designation.Location = new System.Drawing.Point(73, 93);
            this.text_designation.Margin = new System.Windows.Forms.Padding(2);
            this.text_designation.Name = "text_designation";
            this.text_designation.Size = new System.Drawing.Size(157, 23);
            this.text_designation.TabIndex = 1;
            // 
            // text_code
            // 
            this.text_code.Location = new System.Drawing.Point(73, 58);
            this.text_code.Margin = new System.Windows.Forms.Padding(2);
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(157, 23);
            this.text_code.TabIndex = 2;
            this.text_code.TextChanged += new System.EventHandler(this.text_code_TextChanged);
            // 
            // check_code
            // 
            this.check_code.AutoSize = true;
            this.check_code.Location = new System.Drawing.Point(234, 62);
            this.check_code.Margin = new System.Windows.Forms.Padding(2);
            this.check_code.Name = "check_code";
            this.check_code.Size = new System.Drawing.Size(15, 14);
            this.check_code.TabIndex = 3;
            this.check_code.UseVisualStyleBackColor = true;
            this.check_code.CheckedChanged += new System.EventHandler(this.check_code_CheckedChanged);
            // 
            // check_designation
            // 
            this.check_designation.AutoSize = true;
            this.check_designation.Location = new System.Drawing.Point(234, 97);
            this.check_designation.Margin = new System.Windows.Forms.Padding(2);
            this.check_designation.Name = "check_designation";
            this.check_designation.Size = new System.Drawing.Size(15, 14);
            this.check_designation.TabIndex = 3;
            this.check_designation.UseVisualStyleBackColor = true;
            this.check_designation.CheckedChanged += new System.EventHandler(this.check_nom_CheckedChanged);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(506, 27);
            this.btn_nouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(149, 27);
            this.btn_nouveau.TabIndex = 4;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(506, 58);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(149, 27);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Sauvgarder";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(506, 89);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(149, 27);
            this.btn_supprimer.TabIndex = 7;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(506, 120);
            this.btn_rechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(149, 27);
            this.btn_rechercher.TabIndex = 8;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // table_filiere
            // 
            this.table_filiere.AllowUserToAddRows = false;
            this.table_filiere.AllowUserToDeleteRows = false;
            this.table_filiere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_filiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_filiere.Location = new System.Drawing.Point(10, 151);
            this.table_filiere.Margin = new System.Windows.Forms.Padding(2);
            this.table_filiere.Name = "table_filiere";
            this.table_filiere.ReadOnly = true;
            this.table_filiere.RowHeadersWidth = 62;
            this.table_filiere.RowTemplate.Height = 28;
            this.table_filiere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_filiere.Size = new System.Drawing.Size(668, 258);
            this.table_filiere.TabIndex = 10;
            this.table_filiere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_eleve_CellContentClick);
            this.table_filiere.SelectionChanged += new System.EventHandler(this.table_eleve_SelectionChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.label3.Size = new System.Drawing.Size(178, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gestion Des Filieres";
            // 
            // Gestion_Filieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.table_filiere);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.check_designation);
            this.Controls.Add(this.check_code);
            this.Controls.Add(this.text_code);
            this.Controls.Add(this.text_designation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(705, 481);
            this.MinimumSize = new System.Drawing.Size(705, 481);
            this.Name = "Gestion_Filieres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Filieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_filiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_designation;
        private System.Windows.Forms.TextBox text_code;
        private System.Windows.Forms.CheckBox check_code;
        private System.Windows.Forms.CheckBox check_designation;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.DataGridView table_filiere;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Label label3;
    }
}

