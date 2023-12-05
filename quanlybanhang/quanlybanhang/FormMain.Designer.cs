namespace quanlybanhang
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbtrendn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblquyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblquyen1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblquyen2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.loạiHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.qLBánHàngToolStripMenuItem,
            this.loạiHàngToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // qLBánHàngToolStripMenuItem
            // 
            this.qLBánHàngToolStripMenuItem.Name = "qLBánHàngToolStripMenuItem";
            this.qLBánHàngToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.qLBánHàngToolStripMenuItem.Text = "QL Bán Hàng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbtrendn,
            this.toolStripStatusLabel2,
            this.lblquyen,
            this.lblquyen1,
            this.lblquyen2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(689, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel1.Text = "Tên Đăng Nhập :";
            this.toolStripStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // lbtrendn
            // 
            this.lbtrendn.Name = "lbtrendn";
            this.lbtrendn.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // lblquyen
            // 
            this.lblquyen.Name = "lblquyen";
            this.lblquyen.Size = new System.Drawing.Size(0, 17);
            // 
            // lblquyen1
            // 
            this.lblquyen1.Name = "lblquyen1";
            this.lblquyen1.Size = new System.Drawing.Size(48, 17);
            this.lblquyen1.Text = "Quyền :";
            // 
            // lblquyen2
            // 
            this.lblquyen2.Name = "lblquyen2";
            this.lblquyen2.Size = new System.Drawing.Size(0, 17);
            // 
            // loạiHàngToolStripMenuItem
            // 
            this.loạiHàngToolStripMenuItem.Name = "loạiHàngToolStripMenuItem";
            this.loạiHàngToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.loạiHàngToolStripMenuItem.Text = "Loại Hàng";
            this.loạiHàngToolStripMenuItem.Click += new System.EventHandler(this.loạiHàngToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.kháchHàngToolStripMenuItem.Text = "khách Hàng";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(689, 454);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLBánHàngToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbtrendn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblquyen;
        private System.Windows.Forms.ToolStripStatusLabel lblquyen1;
        private System.Windows.Forms.ToolStripStatusLabel lblquyen2;
        private System.Windows.Forms.ToolStripMenuItem loạiHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
    }
}