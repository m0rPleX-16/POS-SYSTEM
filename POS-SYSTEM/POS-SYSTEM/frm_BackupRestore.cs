﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class frm_BackupRestore : Form
    {

        private readonly Employee _currentEmployee;
        public frm_BackupRestore(Employee currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
        }
        public void BackupDatabase()
        {
            try
            {
                string server = "localhost";
                string port = "3306";
                string username = "root";
                string password = "";
                string database = "posresto_db";
                string backupFilePath = @"C:\Users\glenn\source\repos\POS-SYSTEM\POS-SYSTEM\POS-SYSTEM\database\posresto_db.sql";

                string backupCommand = $@"C:\xampp\mysql\bin\mysqldump --host={server} --port={port} --user={username} --password={password} --databases {database} --routines --events --triggers > ""{backupFilePath}""";

                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + backupCommand;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                MessageBox.Show("Backup completed successfully, including tables and attributes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RestoreDatabase()
        {
            try
            {
                string server = "localhost";
                string port = "3306";
                string username = "root";
                string password = "";
                string database = "posresto_db";
                string backupFilePath = @"C:\Users\glenn\source\repos\POS-SYSTEM\POS-SYSTEM\POS-SYSTEM\database\posresto_db.sql";

                string restoreCommand = $@"C:\xampp\mysql\bin\mysql --host={server} --port={port} --user={username} --password={password} {database} < ""{backupFilePath}""";

                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + restoreCommand;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                MessageBox.Show("Restore completed successfully, including tables and attributes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Restore failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_backup_Click_1(object sender, EventArgs e)
        {
            BackupDatabase();
        }
        private void btn_restore_Click_1(object sender, EventArgs e)
        {
            RestoreDatabase();
        }
    }
}