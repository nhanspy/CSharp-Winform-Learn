using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform___Bai1
{
    public partial class frmTong : Form
    {
        public frmTong()
        {
            InitializeComponent();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            double kq = Convert.ToDouble(txtSoA.Text) + Convert.ToDouble(txtSoB.Text);
            txtKetQua.Text = kq.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
