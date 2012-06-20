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
    public partial class frmEditCar : Form
    {
        public frmEditCar()
        {
            InitializeComponent();
        }

        private void frmEditCar_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblCars where Car_code='" + frmCar.Code + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) {
                txtCarcode.Text = sdr.GetString(0);
                txtCarname.Text = sdr.GetString(1);
                txtSuplier.Text = sdr.GetString(2);
                txtCompensAmout.Text = sdr.GetDecimal(3).ToString();
                dtpBoughtDate.Text = sdr.GetDateTime(4).ToString();
                txtUnitPrice.Text = sdr.GetDecimal(5).ToString();
                txtRentPrice.Text = sdr.GetDecimal(6).ToString();
                dtpLiquidationDate.Text = sdr.GetDateTime(7).ToString();
                txtLiquidationreason.Text = sdr.GetString(8);
                 
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            if (dtpLiquidationDate.Enabled == true)
            {
                string sql = "update tblCars set Car_name='" + txtCarname.Text + "',suplier='" + txtSuplier.Text + "',Compens_amout='" + txtCompensAmout.Text + "',Bought_Date='" + dtpBoughtDate.Text + "',UnitPrice='" + txtUnitPrice.Text + "',RentPrice='" + txtRentPrice.Text + "',Liquidation_date='" + dtpLiquidationDate
                    + "',liqidation_reason='" + txtLiquidationreason + "' where car_code='" + frmCar.Code + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                MessageBox.Show("Update successfull");
                frmCar view = new frmCar();
                view.Show();
                this.Dispose();
            }
            else {
                string sql = "update tblCars set Car_name='" + txtCarname.Text + "',suplier='" + txtSuplier.Text + "',Compens_amout='" + txtCompensAmout.Text + "',Bought_Date='" + dtpBoughtDate.Text + "',UnitPrice='" + txtUnitPrice.Text + "',RentPrice='" + txtRentPrice.Text + "'where car_code='" + frmCar.Code + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                MessageBox.Show("Update successfull");
                frmCar view = new frmCar();
                view.Show();
                this.Dispose();
            }


        }

        private void txtLiquidationreason_TextChanged(object sender, EventArgs e)
        {
         dtpLiquidationDate.Enabled=true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

     
    }
}
