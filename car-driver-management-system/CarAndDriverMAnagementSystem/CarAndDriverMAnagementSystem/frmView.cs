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
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
            LoadDatagrid(); 
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblCars where car_code='" + frmCar.Code + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) {
                txtCarcode.Text = sdr.GetString(0);
                txtCarName.Text = sdr.GetString(1);
                txtSuplier.Text = sdr.GetString(2);
                txtCompens.Text = sdr.GetDecimal(3).ToString();
                dtpBoughtdate.Text = sdr.GetDateTime(4).ToString();
                txtUnitprice.Text = sdr.GetDecimal(5).ToString();
                txtRentprice.Text = sdr.GetDecimal(6).ToString();
                dtpLiquidation.Text = sdr.GetDateTime(7).ToString();
                txtLiquidationreason.Text = sdr.GetString(8);
            }
            conn.Close();
            
           
        }
        
        public void LoadDatagrid() {
            SqlConnection conn = connect.Getconect();
            try
            {
                conn.Open();
                string sql = "select tblDrivers.*,rent_date,return_date from tblCar_Driver,tblDrivers where tbldrivers.driver_code=tblcar_driver.driver_code and car_code='" + frmCar.Code + "'";
               // MessageBox.Show(sql);
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
                frmCar view= new frmCar();
            view.Show();
        }

    
    
    }
}
