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
    public partial class frmViewDriver : Form
    {
        public frmViewDriver()
        {
            InitializeComponent();
            LoadDatagrid();
        }

        private void frmViewDriver_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblDrivers where driver_code='" + frmDrivers.Code + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtDrivercode.Text = sdr.GetString(0);
                txtDrivername.Text = sdr.GetString(1);
                dateTimePicker1.Text = sdr.GetDateTime(2).ToShortDateString();
                if (sdr.GetBoolean(3).ToString() == "True") { rbMale.Checked = true; } else { rbFemale.Checked = true; }
                txtAdd.Text = sdr.GetString(4);
                txtTelephone.Text = sdr.GetString(5);
               
            }
            conn.Close();
            
        }

        public void LoadDatagrid()
        {
            SqlConnection conn = connect.Getconect();
            try
            {
                conn.Open();
                string sql = "select tblCars.car_name,tblCars.rentPrice from tblCars,tblCar_Driver where tblCar_driver.car_code=tblCars.car_code and tblCar_Driver.driver_code='" + frmDrivers.Code + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDrivers view = new frmDrivers();
            view.Show();
        }
    }
}
