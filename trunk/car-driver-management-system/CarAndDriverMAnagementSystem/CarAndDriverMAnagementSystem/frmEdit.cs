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
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }
     private void frmEdit_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
         string sql="select * from tblCars where Car_code= '"+frmCar.Code+"'";
         SqlCommand cmd = new SqlCommand(sql,conn);
         SqlDataReader sdr = cmd.ExecuteReader();
         while (sdr.Read()) {
             txtCarcode.Text = sdr.GetString(0);
             txtCarname.Text = sdr.GetString(1);
             txtSuplier.Text = sdr.GetString(2);
             txtCompens.Text = sdr.GetDecimal(3).ToString();
             BoughtDate.Text = sdr.GetDateTime(4).ToString();
         }

     }

    }
}
