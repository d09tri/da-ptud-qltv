namespace GUI
{
    partial class FrmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongQLPQ = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongQLND = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongQLDG = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongBCMT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongTKMT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongQLNND = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(594, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThongQLPQ,
            this.mnuHeThongQLND,
            this.mnuHeThongQLNND,
            this.mnuHeThongQLDG,
            this.mnuHeThongBCMT,
            this.mnuHeThongTKMT});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuHeThongQLPQ
            // 
            this.mnuHeThongQLPQ.Name = "mnuHeThongQLPQ";
            this.mnuHeThongQLPQ.Size = new System.Drawing.Size(215, 22);
            this.mnuHeThongQLPQ.Tag = "SC001";
            this.mnuHeThongQLPQ.Text = "Quản lý phân quyền";
            // 
            // mnuHeThongQLND
            // 
            this.mnuHeThongQLND.Name = "mnuHeThongQLND";
            this.mnuHeThongQLND.Size = new System.Drawing.Size(215, 22);
            this.mnuHeThongQLND.Tag = "SC002";
            this.mnuHeThongQLND.Text = "Quản lý người dùng";
            // 
            // mnuHeThongQLDG
            // 
            this.mnuHeThongQLDG.Name = "mnuHeThongQLDG";
            this.mnuHeThongQLDG.Size = new System.Drawing.Size(215, 22);
            this.mnuHeThongQLDG.Tag = "SC004";
            this.mnuHeThongQLDG.Text = "Quản lý độc giả";
            // 
            // mnuHeThongBCMT
            // 
            this.mnuHeThongBCMT.Name = "mnuHeThongBCMT";
            this.mnuHeThongBCMT.Size = new System.Drawing.Size(215, 22);
            this.mnuHeThongBCMT.Tag = "SC005";
            this.mnuHeThongBCMT.Text = "Báo cáo mượn trả";
            // 
            // mnuHeThongTKMT
            // 
            this.mnuHeThongTKMT.Name = "mnuHeThongTKMT";
            this.mnuHeThongTKMT.Size = new System.Drawing.Size(215, 22);
            this.mnuHeThongTKMT.Tag = "SC006";
            this.mnuHeThongTKMT.Text = "Thống kê mượn trả";
            // 
            // mnuHeThongQLNND
            // 
            this.mnuHeThongQLNND.Name = "mnuHeThongQLNND";
            this.mnuHeThongQLNND.Size = new System.Drawing.Size(215, 22);
            this.mnuHeThongQLNND.Tag = "SC003";
            this.mnuHeThongQLNND.Text = "Quản lý nhóm người dùng";
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 403);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmTrangChu";
            this.Text = "FrmTrangChu";
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongQLPQ;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongQLND;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongQLDG;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongBCMT;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongTKMT;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongQLNND;
    }
}