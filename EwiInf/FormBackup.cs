using EwiInf.EwidencjaDataSetTableAdapters;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwiInf
{
    public partial class FormBackup : Form
    {
        string sInstance = "";
        string sServerName = "";
        string sUser = "";
        string sPassword = "";
        string sDatabaseName = "";
        string sConnectionString = "";

        public FormBackup()
        {
            InitializeComponent();
        }

        public FormBackup(string sServerName, string sInstance, string sUser, string sPassword, string sDatabaseName, string sConnectionString)
        {
            InitializeComponent();
            this.sServerName = sServerName;
            this.sInstance = sInstance;
            this.sUser = sUser;
            this.sPassword = sPassword;
            this.sDatabaseName = sDatabaseName;
            this.sConnectionString = sConnectionString;
        }

        string SelectBackupFile(string sStartingPath)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = sStartingPath;
                openFileDialog.Filter = "bak files (*.bak)|*.bak";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            return filePath;
        }

        private void EwiInf_Load(object sender, EventArgs e)
        {
            DirectoryInfo path;
            using (var connection = new SqlConnection(sConnectionString))
            {
                var serverConnection = new ServerConnection(connection);
                var server = new Server(serverConnection);
                var defaultDataPath = string.IsNullOrEmpty(server.Settings.DefaultFile) ? server.MasterDBPath : server.Settings.DefaultFile;
                var defaultLogPath = string.IsNullOrEmpty(server.Settings.DefaultLog) ? server.MasterDBLogPath : server.Settings.DefaultLog;
                path = Directory.GetParent(Directory.GetParent(defaultDataPath).ToString());
            }

            progressBar1.Value = 0;

            try
            {
                Server dbServer = new Server(new ServerConnection((sServerName + "\\" + sInstance), sUser, sPassword));
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = sDatabaseName };
                string sElseName = "Ewi" + DateTime.Now.ToShortDateString() + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;
                dbBackup.Devices.AddDevice(path + "\\" + "Backup" + "\\" + sElseName + ".bak", DeviceType.File);
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error!=null)
            {
                labelStatus.Invoke((MethodInvoker)delegate
                {
                    labelStatus.Text = "Status: "+e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });
            labelProgres.Invoke((MethodInvoker)delegate
            {
                labelProgres.Text = $"{e.Percent} %";
            });
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal class EwidencjaDataSetTableAdapters
        {
            internal class EwiTableAdapter : EwiInf.EwidencjaDataSetTableAdapters.EwiTableAdapter
            {
            }
        }

        internal class EwidencjaDataSet : EwiInf.EwidencjaDataSet
        {
        }
    }
}
