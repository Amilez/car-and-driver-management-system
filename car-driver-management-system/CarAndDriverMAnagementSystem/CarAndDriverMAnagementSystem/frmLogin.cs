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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPassword.Text;
            try
            {
                SqlConnection conn = connect.Getconect();
                conn.Open();

                string sql = "select * from TblUser where username='" + name + "' and password='" + pass + "'";
                 SqlCommand cmd;
                cmd= new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
             
                        MessageBox.Show("Welcome " + name + " Login successfull!");
                        frmMain main = new frmMain();
                        main.Show();
                        this.Hide();
                    }
          
                else{
                    MessageBox.Show("Login error");
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
