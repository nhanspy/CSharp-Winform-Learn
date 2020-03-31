using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace winformQUANLYBANHANG
{
    public partial class frmDangNhap : Form
    {
        SqlConnection con;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        [TestInitialize]
        public void TestInitialize() => AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases"));// rest of initialize implementation ...

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=NHAN\nhan;Initial Catalog=dbQuanLyBanHang;Integrated Security=True";
            con = new SqlConnection(conString);
            con.Open();
            con.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.con.Open();

            string sql = "select count(*) from tbUser where "
                + " tendangnhap='" + this.txtUser.Text
                + "' and "
                + " matkhau='" + this.txtPassword.Text +"';";
            SqlCommand com = new SqlCommand(sql, this.con);
            int ketqua = (int)com.ExecuteScalar();
            if (ketqua > 0)
            {
                MessageBox.Show("Dang nhap thanh cong");
                this.Close();
            } else
            {
                MessageBox.Show("Dang nhap khong thanh cong");
            }
            this.con.Close();
        }
    }
}
