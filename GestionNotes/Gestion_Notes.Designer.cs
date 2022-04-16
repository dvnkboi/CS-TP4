
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
            this.label1 = new System.Windows.Forms.Label();
            this.seperator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // code_eleve
            // 
            this.code_eleve.AutoSize = true;
            this.code_eleve.Location = new System.Drawing.Point(34, 55);
            this.code_eleve.Name = "code_eleve";
            this.code_eleve.Size = new System.Drawing.Size(65, 15);
            this.code_eleve.TabIndex = 0;
            this.code_eleve.Text = "Code élève";
            // 
            // matiere
            // 
            this.matiere.AutoSize = true;
            this.matiere.Location = new System.Drawing.Point(52, 84);
            this.matiere.Name = "matiere";
            this.matiere.Size = new System.Drawing.Size(47, 15);
            this.matiere.TabIndex = 1;
            this.matiere.Text = "Matière";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Location = new System.Drawing.Point(66, 141);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(33, 15);
            this.note.TabIndex = 2;
            this.note.Text = "Note";
            this.note.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_code_eleve
            // 
            this.text_code_eleve.Location = new System.Drawing.Point(105, 51);
            this.text_code_eleve.Name = "text_code_eleve";
            this.text_code_eleve.Size = new System.Drawing.Size(121, 23);
            this.text_code_eleve.TabIndex = 3;
            // 
            // text_note
            // 
            this.text_note.Location = new System.Drawing.Point(105, 138);
            this.text_note.Name = "text_note";
            this.text_note.Size = new System.Drawing.Size(121, 23);
            this.text_note.TabIndex = 5;
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(346, 51);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(141, 23);
            this.btn_nouveau.TabIndex = 6;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(346, 80);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(141, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Sauvegarder";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(346, 109);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(141, 23);
            this.btn_supprimer.TabIndex = 9;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(346, 138);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(141, 23);
            this.btn_rechercher.TabIndex = 10;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // comboBox_matiere
            // 
            this.comboBox_matiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_matiere.FormattingEnabled = true;
            this.comboBox_matiere.Location = new System.Drawing.Point(105, 80);
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
            this.label_state.Location = new System.Drawing.Point(457, 168);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(0, 15);
            this.label_state.TabIndex = 12;
            this.label_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestion Des Notes";
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.seperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seperator.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.seperator.Location = new System.Drawing.Point(111, 120);
            this.seperator.Margin = new System.Windows.Forms.Padding(0);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(110, 2);
            this.seperator.TabIndex = 14;
            this.seperator.Paint += new System.Windows.Forms.PaintEventHandler(this.seperator_Paint);
            // 
            // Gestion_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 189);
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.label1);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 228);
            this.MinimumSize = new System.Drawing.Size(518, 228);
            this.Name = "Gestion_Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestion_Notes_FormClosing);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label seperator;
    }
}

