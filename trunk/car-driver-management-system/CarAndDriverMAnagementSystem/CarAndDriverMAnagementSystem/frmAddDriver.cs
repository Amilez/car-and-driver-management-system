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
            DateTime dt1 = dtpRentDate.Value;
            DateTime dt2 = dtpIntendedDate.Value;
            DateTime dt3 = dtpReturnDate.Value;
            if (txtDrivercode.Text != "" && txtDrivername.Text != "" && txtAdd.Text != "" && txtTelephone.Text != "" && txtCarCode.Text != "" && txtCarName.Text != "" && txtUnitPrice.Text != "" && txtRentPrice.Text != "")
            {
                if (DateTime.Compare(dt1, dt2) < 0 && DateTime.Compare(dt1, dt3) < 0)
                {

                    try
                    {
                        SqlConnection conn = connect.Getconect();
                        conn.Open();

                        string sql = "insert into tblDrivers values ('" + drivercode + "','" + drivername + "','" + dob + "','" + gender + "','" + add + "','" + telephone + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        SqlConnection conn1 = connect.Getconect();
                        conn1.Open();
                        string sql1 = "insert into tblCar_Driver values ('" + txtCarCode.Text + "','" + drivercode + "','" + dtpRentDate.Text + "','" + dtpIntendedDate.Text + "','" + dtpReturnDate.Text + "',null,null,null)";
                        SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                        cmd1.ExecuteNonQuery();
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


                else { MessageBox.Show("Intend date or Return date must greater than Rent date!"); }
            }
            else { MessageBox.Show("You must enter full information!"); }

          
        } 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDrivers view = new frmDrivers();
            view.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAdd.Text = "";
            txtDrivercode.Text = "";
            txtDrivername.Text = "";
            txtTelephone.Text = "";
            txtCarName.Text = "";
            txtCarCode.Text = "";
            txtRentPrice.Text = "";
            txtUnitPrice.Text = "";
           
        }

        private void frmAddDriver_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select car_code,car_name,UnitPrice,RentPrice from tblCars";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select car_code,car_name,UnitPrice,RentPrice from tblCars where car_code='" + code + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) {
                txtCarCode.Text = sdr.GetString(0);
                txtCarName.Text = sdr.GetString(1);
                txtUnitPrice.Text = sdr.GetDecimal(2).ToString();
                txtRentPrice.Text = sdr.GetDecimal(3).ToString();

            }
        }

   
    
     
    }
}
