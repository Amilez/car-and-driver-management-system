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
    public partial class frmReportCar : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public frmReportCar()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            conn = connect.Getconect();
            conn.Open();
            String str = "select * from TblCars";
            da = new SqlDataAdapter(str, conn);
            // ds = new DataSet();
            Car ds = new Car();
            da.Fill(ds, "TblCars");
            ReportCar rpt = new ReportCar();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Show();

        }
    }
}
