
namespace GestionNotes
{
    partial class Connection
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
            this.comboBox_server = new System.Windows.Forms.ComboBox();
            this.label_conErr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_conStr = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.check_migrate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // comboBox_server
            // 
            this.comboBox_server.FormattingEnabled = true;
            this.comboBox_server.Items.AddRange(new object[] {
            "MySql",
            "MsSql"});
            this.comboBox_server.Location = new System.Drawing.Point(120, 69);
            this.comboBox_server.Name = "comboBox_server";
            this.comboBox_server.Size = new System.Drawing.Size(121, 23);
            this.comboBox_server.TabIndex = 1;
            // 
            // label_conErr
            // 
            this.label_conErr.AutoSize = true;
            this.label_conErr.Location = new System.Drawing.Point(12, 33);
            this.label_conErr.Name = "label_conErr";
            this.label_conErr.Size = new System.Drawing.Size(208, 15);
            this.label_conErr.TabIndex = 2;
            this.label_conErr.Text = "No connection to database was found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connection string";
            // 
            // text_conStr
            // 
            this.text_conStr.Location = new System.Drawing.Point(120, 101);
            this.text_conStr.Name = "text_conStr";
            this.text_conStr.Size = new System.Drawing.Size(441, 23);
            this.text_conStr.TabIndex = 6;
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_connect.Location = new System.Drawing.Point(252, 148);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(90, 32);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // check_migrate
            // 
            this.check_migrate.AutoSize = true;
            this.check_migrate.Location = new System.Drawing.Point(252, 71);
            this.check_migrate.Name = "check_migrate";
            this.check_migrate.Size = new System.Drawing.Size(178, 19);
            this.check_migrate.TabIndex = 8;
            this.check_migrate.Text = "Migrate and use sample data";
            this.check_migrate.UseVisualStyleBackColor = true;
            this.check_migrate.CheckedChanged += new System.EventHandler(this.check_migrate_CheckedChanged);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 192);
            this.Controls.Add(this.check_migrate);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.text_conStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_conErr);
            this.Controls.Add(this.comboBox_server);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(594, 231);
            this.MinimumSize = new System.Drawing.Size(594, 231);
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_server;
        private System.Windows.Forms.Label label_conErr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_conStr;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.CheckBox check_migrate;
    }
}