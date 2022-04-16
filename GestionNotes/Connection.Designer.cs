
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
            this.text_user = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.check_migrate = new System.Windows.Forms.CheckBox();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_db = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_opt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_host = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.comboBox_server.Location = new System.Drawing.Point(115, 65);
            this.comboBox_server.Name = "comboBox_server";
            this.comboBox_server.Size = new System.Drawing.Size(175, 23);
            this.comboBox_server.TabIndex = 0;
            // 
            // label_conErr
            // 
            this.label_conErr.AutoSize = true;
            this.label_conErr.Location = new System.Drawing.Point(12, 33);
            this.label_conErr.Name = "label_conErr";
            this.label_conErr.Size = new System.Drawing.Size(175, 15);
            this.label_conErr.TabIndex = 2;
            this.label_conErr.Text = "Connection was not established";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Server*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(115, 125);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(175, 23);
            this.text_user.TabIndex = 2;
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_connect.Location = new System.Drawing.Point(137, 397);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(90, 33);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // check_migrate
            // 
            this.check_migrate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.check_migrate.AutoSize = true;
            this.check_migrate.Location = new System.Drawing.Point(94, 372);
            this.check_migrate.Name = "check_migrate";
            this.check_migrate.Size = new System.Drawing.Size(178, 19);
            this.check_migrate.TabIndex = 6;
            this.check_migrate.Text = "Migrate and use sample data";
            this.check_migrate.UseVisualStyleBackColor = true;
            this.check_migrate.CheckedChanged += new System.EventHandler(this.check_migrate_CheckedChanged);
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(115, 156);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(175, 23);
            this.text_pass.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // text_db
            // 
            this.text_db.Location = new System.Drawing.Point(115, 187);
            this.text_db.Name = "text_db";
            this.text_db.Size = new System.Drawing.Size(175, 23);
            this.text_db.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Database";
            // 
            // text_opt
            // 
            this.text_opt.Location = new System.Drawing.Point(115, 235);
            this.text_opt.Multiline = true;
            this.text_opt.Name = "text_opt";
            this.text_opt.Size = new System.Drawing.Size(175, 93);
            this.text_opt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Options";
            // 
            // text_host
            // 
            this.text_host.Location = new System.Drawing.Point(115, 96);
            this.text_host.Name = "text_host";
            this.text_host.Size = new System.Drawing.Size(175, 23);
            this.text_host.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Host*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(115, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "if none given default will be used";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(115, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "one per line";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 438);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_host);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_opt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_db);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.check_migrate);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_conErr);
            this.Controls.Add(this.comboBox_server);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 477);
            this.MinimumSize = new System.Drawing.Size(364, 477);
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
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.CheckBox check_migrate;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_db;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_opt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_host;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}