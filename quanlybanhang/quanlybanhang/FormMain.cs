using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhang
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbtrendn.Text = Formdangnhap.TenDangNhap;
            lblquyen2.Text = Formdangnhap.Quyen;
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formloaihang f = new Formloaihang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
