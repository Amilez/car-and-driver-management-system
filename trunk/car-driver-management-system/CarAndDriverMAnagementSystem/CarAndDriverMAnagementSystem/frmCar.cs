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
    public partial class frmCar : Form
    {
        public static string Code; 
        public frmCar()
        {
            InitializeComponent();
        }

        private void frmCar_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblCars";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();


        }

        private void btnSearchBoughtDate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblCars where Bought_date= '" + dateTimePicker1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            if (cboSearch.Text == "Car by codes")
            {
                string sql = "select * from tblCars where Car_code= '" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else if (cboSearch.Text == "Car by names")
            {
                string sql = "select * from tblCars where Car_name ='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else if (cboSearch.Text == "Car by code of driver who is renting the car")
            {
                string sql = "select Driver_code,tblCars.Car_code,Car_name,Suplier,Compens_amout,Bought_date,UnitPrice,RentPrice,Liquidation_date,Liquidation_reason from tblCars,tblcar_driver where tblCars.car_code= tblCar_driver.car_code and driver_code='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }



        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCar add = new frmAddCar();
            add.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           // MessageBox.Show(Code);
            frmEdit edit = new frmEdit();
            edit.Show();
            this.Hide();
        }
    }
}
