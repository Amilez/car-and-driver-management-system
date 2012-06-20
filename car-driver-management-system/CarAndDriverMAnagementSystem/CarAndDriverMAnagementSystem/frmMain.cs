using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarAndDriverMAnagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void managerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
            this.Hide();
        }

        private void managerCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCar car = new frmCar();
            car.Show();
            this.Hide();

        }

        private void managerDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers driver= new frmDrivers();
            driver.Show();
            this.Hide();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin view = new frmLogin();
            view.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
