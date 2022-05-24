﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class FrmTrangChu : Form
    {
        Utilities utl = new Utilities();

        #region Sub menu
        public FrmTrangChu()
        {
            InitializeComponent();
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        
        private void ShowSubMenu(Panel pnl)
        {
            if (pnl.Visible == false)
            {
                HideSubMenu();
                pnl.Visible = true;
            }
            else
                pnl.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlQuanLySubMenu.Visible == true)
                pnlQuanLySubMenu.Visible = false;

            if (pnlChucNangSubMenu.Visible == true)
                pnlChucNangSubMenu.Visible = false;

            if (pnlHeThongSubMenu.Visible == true)
                pnlHeThongSubMenu.Visible = false;
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlQuanLySubMenu);
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlChucNangSubMenu);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlHeThongSubMenu);
        }
        #endregion

        #region Quản lý
        private void btnDocGia_Click(object sender, EventArgs e)
        {
            FrmDocGia frm = new FrmDocGia();
            utl.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region Chức năng
        private void btnDatBao_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region Hệ thống
        private void btnBackup_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
