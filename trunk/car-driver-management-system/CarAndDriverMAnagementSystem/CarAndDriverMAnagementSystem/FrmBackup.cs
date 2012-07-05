using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarAndDriverMAnagementSystem
{
    public partial class frmBackup : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnSelectfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogopen = new OpenFileDialog();
            dialogopen.Filter = "bak files (*.bak)|*.bak|All files (*.*)|*.*";
            dialogopen.ShowDialog();
            //if (dialogopen.ShowDialog() == DialogResult.OK)
            //{
            txtPath.Text = dialogopen.FileName;
            //}
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string disk = @"E:\";
            string luu = "CarDriver.bak";
            string gach = "_";
            string tenfile="";
            tenfile += DateTime.Now.Hour.ToString() + gach;
            tenfile += DateTime.Now.Minute.ToString() + gach;
            tenfile += DateTime.Now.Second.ToString() + gach;
            tenfile += DateTime.Now.Day.ToString() +gach;
            tenfile += DateTime.Now.Month.ToString() + gach;
            tenfile += DateTime.Now.Year.ToString() + gach;
            tenfile += luu;
            disk += tenfile;
            try
            {
                string sqlBackup = "BACKUP DATABASE [systemlibrary] TO DISK='" + tenfile + "'";
                conn = connect.Getconect();
                conn.Open();
                cmd = new SqlCommand(sqlBackup, conn);
                MessageBox.Show(sqlBackup);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("BackUp database successfull with Path:'"+disk+"'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Backup Database");
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain frmback = new frmMain();
            frmback.Show();
            this.Hide();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtPath.Text;
                string sqlRestore = "Use master Restore Database [CarDriver] from disk='" + path + "'";
                conn = connect.Getconect();
                conn.Open();
                cmd = new SqlCommand(sqlRestore, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Restore Database Successfull ");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Restore Database");
            }
        }
    
    }
}
