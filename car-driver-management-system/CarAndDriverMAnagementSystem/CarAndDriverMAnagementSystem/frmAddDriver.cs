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
    public partial class frmAddDriver : Form
    {
        public frmAddDriver()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string drivercode = txtDrivercode.Text;
            string drivername = txtDrivername.Text;
            string dob = dateTimePicker1.Text;
            string gender;
            if (rbMale.Checked == true) { gender = "1"; } else { gender = "0"; }
            string add = txtAdd.Text;
            string telephone = txtTelephone.Text;
           
            try
            {
                SqlConnection conn = connect.Getconect();
                conn.Open();

                string sql = "insert into tblDrivers values ('" + drivercode + "','" + drivername + "','" + dob + "','" + gender + "','" + add + "','" + telephone + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add successfull");
                frmDrivers frm = new frmDrivers();
                frm.Show();
                this.Dispose();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDrivers view = new frmDrivers();
            view.Show();
        }
    }
}
