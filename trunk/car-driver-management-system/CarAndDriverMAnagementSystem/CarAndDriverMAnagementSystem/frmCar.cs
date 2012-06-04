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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchBoughtDate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblCars where Bought_date= '" + dateTimePicker1.Text+ "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

    }
}
