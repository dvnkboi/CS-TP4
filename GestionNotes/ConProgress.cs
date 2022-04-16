using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class ConProgress : Form
    {
        public string conString = null;
        public string server = null;
        public bool migrate = false;
        public bool error = false;
        private BackgroundWorker backgroundTask;
        public ConProgress()
        {
            InitializeComponent();
        }

        private void ConProgress_Load(object sender, EventArgs e)
        {
            server = server.ToLower().Trim();
            progress_con.Maximum = 100;
            progress_con.Value = 0;
            backgroundTask = new BackgroundWorker();
            backgroundTask.WorkerReportsProgress = true;
            backgroundTask.DoWork += new DoWorkEventHandler(DbTask_Work);
            backgroundTask.ProgressChanged += new ProgressChangedEventHandler(DbTask_ProgressChanged);

            backgroundTask.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DbTask_Done);

            backgroundTask.RunWorkerAsync();
        }

        private void ConProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!error && progress_con.Value != 100)
            {
                var window = MessageBox.Show(
                    "Close the window?",
                    "Are you sure? this might result in corrupted data",
                MessageBoxButtons.YesNo);

                e.Cancel = (window == DialogResult.No);
            }

            Owner.Close();
        }

        private void DbTask_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Dictionary<string, object> state = (Dictionary<string, object>)e.UserState;
            progress_con.Value = e.ProgressPercentage;
            error = (bool)state["error"];
            label_status.Text = (string)state["text"];
            if (e.ProgressPercentage == 100 || error)
            {
                this.Close();
            }
        }

        private void DbTask_Done(object sender, RunWorkerCompletedEventArgs e)
        {
            Dictionary<string, object> state = (Dictionary<string, object>)e.UserState;
            Properties.Settings.Default["conString"] = conString;
            Properties.Settings.Default["conServer"] = server;
            Properties.Settings.Default.Save();
        }

        public void DbTask_Work(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundTask.ReportProgress(0, new Dictionary<string, object>() { { "text", "Connecting" }, { "error", false } });
                ModelApp.Connection.Close();
                ModelApp.Connection.Connect(conString, server);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not connect",
                    "Connection error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                backgroundTask.ReportProgress(0, new Dictionary<string, object>() { { "text", "Connecting" }, { "error", true } });
                return;
            }

            backgroundTask.ReportProgress(25, new Dictionary<string, object>() { { "text", "Connecting" }, { "error", false } });

            if (migrate)
            {
                try
                {
                    backgroundTask.ReportProgress(25, new Dictionary<string, object>() { { "text", "Migrating database" }, { "error", false } });
                    string Location = Path.Combine(Environment.CurrentDirectory, $@"Sql\{server}_db.sql");
                    string script = File.ReadAllText(Location);
                    ModelApp.Connection.Execute(script);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not migrate database",
                        "Migration error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    backgroundTask.ReportProgress(0, new Dictionary<string, object>() { { "text", "Migrating database" }, { "error", true } });
                    return;
                }

                backgroundTask.ReportProgress(50, new Dictionary<string, object>() { { "text", "Migrating database" }, { "error", false } });

                try
                {
                    backgroundTask.ReportProgress(50, new Dictionary<string, object>() { { "text", "Migrating procedures" }, { "error", false } });
                    string Location = Path.Combine(Environment.CurrentDirectory, $@"Sql\{server}_procedures.sql");
                    string script = File.ReadAllText(Location);
                    ModelApp.Connection.Execute(script);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not migrate procedures",
                        "Migration error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    backgroundTask.ReportProgress(0, new Dictionary<string, object>() { { "text", "Migrating procedures" }, { "error", true } });
                    return;
                }

                backgroundTask.ReportProgress(75, new Dictionary<string, object>() { { "text", "Migrating procedures" }, { "error", false } });

                try
                {
                    backgroundTask.ReportProgress(75, new Dictionary<string, object>() { { "text", "Migrating triggers" }, { "error", false } });
                    string Location = Path.Combine(Environment.CurrentDirectory, $@"Sql\{server}_triggers.sql");
                    string script = File.ReadAllText(Location);
                    ModelApp.Connection.Execute(script);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not migrate triggers",
                        "Migration error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    backgroundTask.ReportProgress(0, new Dictionary<string, object>() { { "text", "Migrating triggers" }, { "error", true } });
                    return;
                }

            }
            backgroundTask.ReportProgress(100, new Dictionary<string, object>() { { "text", "Migrating triggers" }, { "error", false } });
        }
    }
}
