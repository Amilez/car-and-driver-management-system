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
    public partial class FrmReportTotalmoney : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        public FrmReportTotalmoney()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //conn = connect.Getconect();
            //conn.Open();
            //String str = "select a.Car_code,Car_name,Bought_date,UnitPrice,RentPrice,Driver_name from TblCars a,tblDrivers b,TblCar_Driver c group by a.Car_code,Car_name,Bought_date,UnitPrice,RentPrice,Driver_name";
            //da = new SqlDataAdapter(str, conn);
            //// ds = new DataSet();
            //Car ds = new Car();
            //da.Fill(ds, "TblCars");
            //Car1 rpt = new Car1();
            //rpt.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = rpt;
            //crystalReportViewer1.Show();
        }
    }
}
