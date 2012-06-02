using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace carandrivermanagesystem
{
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string user =txtUserName.Text;
           string pass = txtPassword.Text;
          // Username = txtusername.Text;
           String quyen;
           try
           {

               conn = Connect.getConnection();
               if (conn != null)
               {
                   conn.Open();
                   String strsql = "select Permission from TblUser where UserName= '" + user+ "' and Password= '" + pass + "'";
                  // MessageBox.Show(strsql);
                   cmd = new SqlCommand(strsql, conn);
                   dr = cmd.ExecuteReader();
                   if (dr.Read())
                   {
                       quyen = dr.GetValue(0).ToString();
                       if (quyen.Equals("Admin"))
                       {
                           MessageBox.Show("Chúc mừng Admin đã đăng nhập thành công", "Thành Công");
                           this.Hide();
                           frmMain frmMain = new frmMain();
                           frmMain.Show();


                       }
                       else
                       {
                           MessageBox.Show("Chúc mừng " +user + " đã đăng nhập thành công", "Thành Công");
                           this.Hide();
                           frmMain frmMain = new frmMain();
                           frmMain.Show();

                       }
                   }
                   else
                   {
                       MessageBox.Show(this, "Tên hoặc mật khẩu sai!");
                       txtPassword.Clear();
                       txtUserName.Clear();
                       txtUserName.Focus();

                   }
               }
               conn.Close();
           }
           catch (Exception)
           {
               MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ", "Có lỗi xảy ra");
              txtUserName.Focus();
           }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
    }
}
