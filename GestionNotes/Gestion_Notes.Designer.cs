
namespace Gestion_Notes
{
    partial class Gestion_Notes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.code_eleve = new System.Windows.Forms.Label();
            this.matiere = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.text_code_eleve = new System.Windows.Forms.TextBox();
            this.text_note = new System.Windows.Forms.TextBox();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.comboBox_matiere = new System.Windows.Forms.ComboBox();
            this.label_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // code_eleve
            // 
            this.code_eleve.AutoSize = true;
            this.code_eleve.Location = new System.Drawing.Point(98, 79);
            this.code_eleve.Name = "code_eleve";
            this.code_eleve.Size = new System.Drawing.Size(65, 15);
            this.code_eleve.TabIndex = 0;
            this.code_eleve.Text = "Code élève";
            // 
            // matiere
            // 
            this.matiere.AutoSize = true;
            this.matiere.Location = new System.Drawing.Point(98, 155);
            this.matiere.Name = "matiere";
            this.matiere.Size = new System.Drawing.Size(47, 15);
            this.matiere.TabIndex = 1;
            this.matiere.Text = "Matière";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Location = new System.Drawing.Point(98, 231);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(33, 15);
            this.note.TabIndex = 2;
            this.note.Text = "Note";
            this.note.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_code_eleve
            // 
            this.text_code_eleve.Location = new System.Drawing.Point(272, 79);
            this.text_code_eleve.Name = "text_code_eleve";
            this.text_code_eleve.Size = new System.Drawing.Size(121, 23);
            this.text_code_eleve.TabIndex = 3;
            // 
            // text_note
            // 
            this.text_note.Location = new System.Drawing.Point(272, 231);
            this.text_note.Name = "text_note";
            this.text_note.Size = new System.Drawing.Size(121, 23);
            this.text_note.TabIndex = 5;
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(544, 79);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(141, 23);
            this.btn_nouveau.TabIndex = 6;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(544, 151);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(141, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Sauvegarder";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(729, 79);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(132, 23);
            this.btn_supprimer.TabIndex = 9;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(729, 151);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(132, 23);
            this.btn_rechercher.TabIndex = 10;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // comboBox_matiere
            // 
            this.comboBox_matiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_matiere.FormattingEnabled = true;
            this.comboBox_matiere.Location = new System.Drawing.Point(272, 147);
            this.comboBox_matiere.Name = "comboBox_matiere";
            this.comboBox_matiere.Size = new System.Drawing.Size(121, 23);
            this.comboBox_matiere.TabIndex = 11;
            this.comboBox_matiere.SelectedIndexChanged += new System.EventHandler(this.comboBox_matiere_SelectedIndexChanged);
            // 
            // label_state
            // 
            this.label_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_state.AutoSize = true;
            this.label_state.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_state.Location = new System.Drawing.Point(892, 262);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(0, 15);
            this.label_state.TabIndex = 12;
            this.label_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Gestion_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 290);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.comboBox_matiere);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.text_note);
            this.Controls.Add(this.text_code_eleve);
            this.Controls.Add(this.note);
            this.Controls.Add(this.matiere);
            this.Controls.Add(this.code_eleve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(962, 329);
            this.MinimumSize = new System.Drawing.Size(962, 329);
            this.Name = "Gestion_Notes";
            this.Text = "Gestion des notes";
            this.Load += new System.EventHandler(this.Gestion_Notes_Load);
            this.Shown += new System.EventHandler(this.Gestion_Notes_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label code_eleve;
        private System.Windows.Forms.Label matiere;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.ComboBox comboBox_matiere;
        public System.Windows.Forms.TextBox text_code_eleve;
        public System.Windows.Forms.TextBox text_note;
        private System.Windows.Forms.Label label_state;
    }
}

