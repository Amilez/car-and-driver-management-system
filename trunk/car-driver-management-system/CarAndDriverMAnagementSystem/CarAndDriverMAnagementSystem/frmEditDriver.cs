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
    public partial class frmEditDriver : Form
    {
        public frmEditDriver()
        {
            InitializeComponent();
        }
        string gender;
        private void frmEditDriver_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblDrivers where driver_code='" + frmDrivers.Code + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) {
                txtDrivercode.Text = sdr.GetString(0);
                txtDrivername.Text = sdr.GetString(1);
                dateTimePicker1.Text = sdr.GetDateTime(2).ToString();
                if (sdr.GetBoolean(3).ToString() == "true")
                {
                    rbMale.Checked = true;
                }
                else { rbFemale.Checked = true; }
                txtAdd.Text = sdr.GetString(4);
                txtTelephone.Text = sdr.GetString(5);
            }

 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
        //if(txtAdd.Text=="" || txtDrivercode.Text=="" || txtDrivername.Text==""||txtTelephone.Text=="") {
        //MessageBox.Show("You must enter full information");}
        //else{
            if(rbMale.Checked==true){gender="true";}
            //if(txtAdd.Text=="" || txtDrivercode.Text=="" || txtDrivername.Text==""||txtTelephone.Text=="") {
            //MessageBox.Show("You must enter full information");}
            //else{
            string sql = "update tblDrivers set Driver_name='" + txtDrivername.Text + "',DoB='" + dateTimePicker1.Text + "',gender='"+gender+"',address='"+txtAdd.Text+"',telephone='"+txtTelephone.Text+"' where driver_code='" + frmDrivers.Code+ "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                MessageBox.Show("Update successfull");
                frmDrivers view = new frmDrivers();
                view.Show();
                 this.Dispose();
             //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDrivers view = new frmDrivers();
            view.Show();
        }
           
            }
        }
    
