using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        // Bổ sung
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FrmTrangChu frm = new FrmTrangChu();
            frm.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
