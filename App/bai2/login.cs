using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace bai2
{

    public partial class login : Form
    {
        string connectionString;
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        //private void btn_login_Click(object sender, EventArgs e)
        //{

        //    string connectionString = ConfigurationManager.ConnectionStrings["QLVT_T1"].ConnectionString;
        //    createForm(connectionString);
        //}
        private void createForm(string connectionString)
        {
            FormMenu f = new FormMenu(connectionString);
            f.ShowDialog();

        }
        private void btn_login_Click(object sender, EventArgs e)
        {

            if (username.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống", "", MessageBoxButtons.OK);

            }
            else if (username.Text == "tram1")
            {
                MessageBox.Show("Đăng nhập thành công !!!", "", MessageBoxButtons.OK);
                string connectionString = ConfigurationManager.ConnectionStrings["QLVT_T1"].ConnectionString;
                createForm(connectionString);
                this.Close();
            }

            else if (username.Text == "tram2")
            {
                MessageBox.Show("Đăng nhập thành công !!!", "", MessageBoxButtons.OK);
                string connectionString = ConfigurationManager.ConnectionStrings["QLVT_T2"].ConnectionString;
                createForm(connectionString);
            }
            else if (username.Text == "tram3")
            {
                MessageBox.Show("Đăng nhập thành công !!!", "", MessageBoxButtons.OK);
                string connectionString = ConfigurationManager.ConnectionStrings["QLVT_T3"].ConnectionString;
                createForm(connectionString);
            }
            
         else
            {
                MessageBox.Show("Đăng nhập không thành công !!!", "", MessageBoxButtons.OK);
            }
     
        }

    }
}
