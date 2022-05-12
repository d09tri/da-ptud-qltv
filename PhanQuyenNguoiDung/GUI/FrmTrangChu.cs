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
    public partial class FrmTrangChu : Form
    {
        string maNhom = "";
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();

        public FrmTrangChu(string maNhom)
        {
            this.maNhom = maNhom;
            InitializeComponent();
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            List<PhanQuyen> dsPQ = phanQuyenBLL.LoadDSPhanQuyenTheoMaNhom(maNhom);

            foreach (PhanQuyen pq in dsPQ)
            {
                TimMenuPhanQuyen(this.menuStrip.Items, pq.MaManHinh, pq.CoQuyen);                 
            }
        }

        private void TimMenuPhanQuyen(ToolStripItemCollection mnuItems, string screenName, bool pEnable)
        {
            foreach (ToolStripItem item in mnuItems)
            {
                if (item is ToolStripMenuItem && ((ToolStripMenuItem)(item)).DropDownItems.Count > 0)
                {
                    TimMenuPhanQuyen(((ToolStripMenuItem)(item)).DropDownItems, screenName, pEnable);
                    // item.Enabled = CheckAllMenuChildVisible(((ToolStripMenuItem)(item)).DropDownItems);
                    // item.Visible = item.Enabled;
                }
                else if (string.Equals(screenName, item.Tag))
                {
                    item.Enabled = pEnable;
                    item.Visible = pEnable;
                }
            }
        }

        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem item in mnuItems)
            {
                if (item is ToolStripMenuItem && item.Enabled)
                {
                    return true;
                }
                else if (item is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }
    }
}
