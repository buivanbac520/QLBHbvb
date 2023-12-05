using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlybanhang
{
    public partial class Formdangnhap : Form
    {
        public static string TenDangNhap = string.Empty;
        public static string Quyen = string.Empty;
        public Formdangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttk.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttk.Focus();
                return;
            }
            if (txtmk.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttk.Focus();
                return;
            }
            SqlConnection Kn = new SqlConnection(@"Data Source=MAY02\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM [USER] WHERE TENDANGNHAP = '" + txttk.Text + "' AND MATKHAU ='" + txtmk.Text + "'", Kn);
            DataTable dttaikhoan = new DataTable();
            DataSet ds = new DataSet();
            adap.Fill(dttaikhoan);
            if (dttaikhoan.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain f = new FormMain();
                string sql = "select Quyen from [USER] where tendangnhap = '" + txttk.Text + "'";
                adap = new SqlDataAdapter(sql, Kn);
                DataSet ds2 = new DataSet(); 
                adap.Fill(ds, "[USER]");                
                TenDangNhap = txttk.Text;
                Quyen = ds.Tables[0].Rows[0]["Quyen"].ToString();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
