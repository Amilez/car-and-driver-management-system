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
            SqlConnection conn = connect.Getconect();
            conn.Open();
            try
            {
                if (txtCarcode.Text == "" || txtCarname.Text == "" || txtCompens.Text == "" || txtSuplier.Text == "" || txtUnitprice.Text=="" || txtRentprice.Text=="")
                {
                    MessageBox.Show("You must enter full information");
                }
                else
                {
                    string sql = "insert into tblCars values ('" + carcode + "','" + carname + "','" + suplier + "','" + compens + "','" + boughtdate + "','" + Unitprice + "','" + rentprice + "',null,null)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Add successfull");
                    frmCar frm = new frmCar();
                    frm.Show();
                    this.Dispose();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCarcode.Text = "";
            txtCarname.Text = "";
            txtSuplier.Text = "";
            txtCompens.Text = "";
            txtRentprice.Text = "";
            txtUnitprice.Text= "";


        }

    }
}
