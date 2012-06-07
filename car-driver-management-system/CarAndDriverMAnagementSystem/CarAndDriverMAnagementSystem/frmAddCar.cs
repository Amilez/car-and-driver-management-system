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
    public partial class frmAddCar : Form
    {
        public frmAddCar()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
          frmCar car= new frmCar() ;
            car.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string carcode = txtCarcode.Text;
            string carname = txtCarname.Text;
            string suplier = txtSuplier.Text;
            string compens = txtCompens.Text;
            string boughtdate = boughtDate.Text;
            string Unitprice = txtUnitprice.Text;
            string rentprice = txtRentprice.Text;
            try
            {
                SqlConnection conn = connect.Getconect();
                conn.Open();
                if (carcode != "" && carname != "" && suplier != "" && compens != "" && boughtdate != "" && Unitprice != "" && rentprice != "")
                {
                    string sql = "insert into tblCars values ('" + carcode + "','" + carname + "','" + suplier + "','" + compens + "','" + boughtdate + "','" + Unitprice + "','" + rentprice + "','null','null')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    frmCar frm = new frmCar();
                    frm.Show();
                    this.Dispose();
                }
                else { MessageBox.Show("Please enter full data!");
                txtCarcode.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
