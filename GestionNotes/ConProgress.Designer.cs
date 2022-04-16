
namespace GestionNotes
{
    partial class ConProgress
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
            this.label_status = new System.Windows.Forms.Label();
            this.progress_con = new System.Windows.Forms.ProgressBar();
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
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 33);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(69, 15);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Connecting";
            // 
            // progress_con
            // 
            this.progress_con.Location = new System.Drawing.Point(12, 58);
            this.progress_con.Name = "progress_con";
            this.progress_con.Size = new System.Drawing.Size(410, 23);
            this.progress_con.TabIndex = 3;
            // 
            // ConProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 93);
            this.Controls.Add(this.progress_con);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 132);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 132);
            this.Name = "ConProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConProgress_FormClosing);
            this.Load += new System.EventHandler(this.ConProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ProgressBar progress_con;
    }
}