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
    public partial class frmReportDriver : Form
    {
        public frmReportDriver()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connect.Getconect();
            conn.Open();
            string sql = "select * from tblDrivers";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            Driver ds = new Driver();
            sda.Fill(ds, "TblDrivers");
            ReportDriver rpd = new ReportDriver();
            rpd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpd;
            crystalReportViewer1.Show();


        }
    }
}
