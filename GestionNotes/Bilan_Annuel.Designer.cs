
namespace Bilan_Annuel
{
    partial class Bilan_Annuel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.table_bilan = new System.Windows.Forms.DataGridView();
            this.comboBox_filiere = new System.Windows.Forms.ComboBox();
            this.comboBox_niveau = new System.Windows.Forms.ComboBox();
            this.comboBox_etudiant = new System.Windows.Forms.ComboBox();
            this.text_moyenne_annuelle = new System.Windows.Forms.TextBox();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_bilan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filière";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niveau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Etudiant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Moyenne annuelle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // table_bilan
            // 
            this.table_bilan.AllowUserToAddRows = false;
            this.table_bilan.AllowUserToDeleteRows = false;
            this.table_bilan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_bilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_bilan.Location = new System.Drawing.Point(14, 143);
            this.table_bilan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.table_bilan.Name = "table_bilan";
            this.table_bilan.ReadOnly = true;
            this.table_bilan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.table_bilan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_bilan.Size = new System.Drawing.Size(905, 271);
            this.table_bilan.TabIndex = 4;
            this.table_bilan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_bilan_CellContentClick);
            // 
            // comboBox_filiere
            // 
            this.comboBox_filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filiere.FormattingEnabled = true;
            this.comboBox_filiere.Location = new System.Drawing.Point(151, 49);
            this.comboBox_filiere.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_filiere.Name = "comboBox_filiere";
            this.comboBox_filiere.Size = new System.Drawing.Size(140, 23);
            this.comboBox_filiere.TabIndex = 6;
            this.comboBox_filiere.SelectedIndexChanged += new System.EventHandler(this.comboBox_filiere_SelectedIndexChanged);
            // 
            // comboBox_niveau
            // 
            this.comboBox_niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_niveau.FormattingEnabled = true;
            this.comboBox_niveau.Location = new System.Drawing.Point(413, 49);
            this.comboBox_niveau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_niveau.Name = "comboBox_niveau";
            this.comboBox_niveau.Size = new System.Drawing.Size(140, 23);
            this.comboBox_niveau.TabIndex = 7;
            this.comboBox_niveau.SelectedIndexChanged += new System.EventHandler(this.comboBox_niveau_SelectedIndexChanged);
            // 
            // comboBox_etudiant
            // 
            this.comboBox_etudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_etudiant.FormattingEnabled = true;
            this.comboBox_etudiant.Location = new System.Drawing.Point(687, 49);
            this.comboBox_etudiant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_etudiant.Name = "comboBox_etudiant";
            this.comboBox_etudiant.Size = new System.Drawing.Size(140, 23);
            this.comboBox_etudiant.TabIndex = 8;
            this.comboBox_etudiant.SelectedIndexChanged += new System.EventHandler(this.comboBox_etudiant_SelectedIndexChanged);
            // 
            // text_moyenne_annuelle
            // 
            this.text_moyenne_annuelle.Enabled = false;
            this.text_moyenne_annuelle.Location = new System.Drawing.Point(420, 420);
            this.text_moyenne_annuelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_moyenne_annuelle.Name = "text_moyenne_annuelle";
            this.text_moyenne_annuelle.Size = new System.Drawing.Size(144, 23);
            this.text_moyenne_annuelle.TabIndex = 9;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(387, 101);
            this.btn_rechercher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(177, 36);
            this.btn_rechercher.TabIndex = 10;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(14, 420);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(75, 23);
            this.export_btn.TabIndex = 11;
            this.export_btn.Text = "export";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.label5.Size = new System.Drawing.Size(128, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bilan Annuel";
            // 
            // Bilan_Annuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.text_moyenne_annuelle);
            this.Controls.Add(this.comboBox_etudiant);
            this.Controls.Add(this.comboBox_niveau);
            this.Controls.Add(this.comboBox_filiere);
            this.Controls.Add(this.table_bilan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(949, 494);
            this.MinimumSize = new System.Drawing.Size(949, 494);
            this.Name = "Bilan_Annuel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilan";
            this.Load += new System.EventHandler(this.Bilan_Annuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_bilan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_filiere;
        private System.Windows.Forms.ComboBox comboBox_niveau;
        private System.Windows.Forms.ComboBox comboBox_etudiant;
        private System.Windows.Forms.TextBox text_moyenne_annuelle;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.DataGridView table_bilan;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Label label5;
    }
}