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
    public partial class frmDrivers : Form
    {
        public static string Code; 
        public frmDrivers()
        {
            InitializeComponent();
        }

        //private void frmDrivers_Load(object sender, EventArgs e)
        //{
        //    SqlConnection conn = connect.Getconect();
        //    conn.Open();
        //    string sql = "select * from tblDrivers";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    sda.Fill(ds);
        //    dataGridView1.DataSource = ds.Tables[0];
        //    conn.Close();


        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            if (cboSearch.Text == "Driver by codes")
            {
                string sql = "select * from tblDrivers where Driver_code= '" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else if (cboSearch.Text == "Driver by names")
            {
                string sql = "select * from tblDrivers where Driver_name ='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else if (cboSearch.Text == "Driver by address")
            {
                string sql = "select * from tblDrivers where address='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

            else if (cboSearch.Text == "Driver by code of car which are being rented")
            {
                string sql = "select tblcar_driver.Car_code,tblDrivers.Driver_code,Driver_name,DoB,gender,Address,telephone from tblDrivers,tblcar_driver where tbldrivers.driver_code= tblCar_driver.driver_code and tblcar_driver.car_code='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }



        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmViewDriver view = new frmViewDriver();
            view.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddDriver add = new frmAddDriver();
            add.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
          //   MessageBox.Show(Code);
            frmEditDriver edit = new frmEditDriver();
            edit.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmMain view = new frmMain();
            view.Show();

        }

        private void frmDrivers_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblDrivers";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();

        }
        public void reload() {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblDrivers";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReportDriver view = new frmReportDriver();
            view.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnView.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult kq = MessageBox.Show("Are you sure delete driver with driver code:" + id + "?", "Notice", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                SqlConnection conn = connect.Getconect();
                conn.Open();
                string sql = "delete tbldrivers where driver_code='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                MessageBox.Show("Delete success");

            }
            reload();
        }
    }
}
