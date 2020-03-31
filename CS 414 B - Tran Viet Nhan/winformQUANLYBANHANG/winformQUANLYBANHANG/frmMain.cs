using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformQUANLYBANHANG
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private bool isHave(string nameForm)
        {
            foreach (Form form in this.MdiChildren)
                if (form.Name.Equals(nameForm))
                {
                    form.Activate();
                    return true;
                }
            return false;
        }

        private void iteDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frmdangnhap = new frmDangNhap();
            if (!isHave(frmdangnhap.Name))
            {
                frmdangnhap.MdiParent = this;
                frmdangnhap.Show();
            }
        }
    }
}
