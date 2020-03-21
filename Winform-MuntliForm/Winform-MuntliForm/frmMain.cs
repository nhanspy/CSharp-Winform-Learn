using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_MuntliForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool kiemTra(string name)
        {
            foreach (Form form in this.MdiChildren)
                if (form.Name.Equals(name))
                {
                    form.Activate();
                    return true;
                }
                    
            return false;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.Show();
        }

        private void nhậpDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham frmQuanLySanPham = new frmQuanLySanPham();
            if (!kiemTra(frmQuanLySanPham.Name))
            {
                frmQuanLySanPham.MdiParent = this;
                frmQuanLySanPham.Show();
            } 
        }
    }
}
