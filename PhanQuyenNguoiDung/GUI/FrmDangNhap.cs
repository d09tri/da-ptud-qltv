using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
        
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (nguoiDungBLL.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                if (Program.frmTrangChu == null || Program.frmTrangChu.IsDisposed)
                    Program.frmTrangChu = new FrmTrangChu();
                this.Visible = false;
                Program.frmTrangChu.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
