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
    public partial class Formloaihang : Form
    {
        SqlConnection Kn = new SqlConnection(@"Data Source=MAY02\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
        SqlDataAdapter adap = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        bool them = false;
        public Formloaihang()
        {
            InitializeComponent();
        }

        private void Formloaihang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet2.LOAIHANG' table. You can move, or remove it, as needed.
            this.lOAIHANGTableAdapter.Fill(this.qLBHDataSet2.LOAIHANG);
            databin();
        }

        private void databin()
        {
            string sql = "SELECT * FROM LOAIHANG";
            adap = new SqlDataAdapter(sql, Kn);
            ds.Clear();
            adap.Fill(ds);
            bs.DataSource = ds.Tables[0];
            txtmh.DataBindings.Clear();
            txtth.DataBindings.Clear();
            txtmh.DataBindings.Add("text", bs, "Maloaihang", true);
            txtth.DataBindings.Add("text", bs, "Tenloaihang", true);
            dataGridView1.DataSource = bs;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmh.Clear();
            txtth.Clear();
            txtth.Focus();
            block(false);
            them = true;
            txtmh.Enabled = (true);
            txtth.Enabled = (true);
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            txtmh.Enabled = (true);
            txtth.Enabled = (true);
            block(false);
            //SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[LOAIHANG] SET TenLoaiHang = N'" + txtth.Text + "' WHERE MaLoaiHang = '" + txtmh.Text + "'");
            //if (Kn.State == ConnectionState.Closed) Kn.Open();
            //cmd.Connection = Kn;
            //int Kq = cmd.ExecuteNonQuery();
            //if (Kq != 0)
            //{
            //    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Formloaihang_Load(sender, e);
            //}
            //else MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Kn.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmh.Text == string.Empty)
            {
                MessageBox.Show("Hãy vào mã loại hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtth.Text == string.Empty)
            {
                MessageBox.Show("Hãy vào Tên loại hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kiemtratrungten() == true)
            {
                MessageBox.Show("Tên loại hàng bị trùng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (kiemtratrungma() == true)
            //{
            //    MessageBox.Show("Mã loại hàng bị trùng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            SqlCommand cmd;
            if (them == true)
            {
                cmd = new SqlCommand(@"INSERT INTO[dbo].[LOAIHANG]
               ([MaLoaiHang]
               ,[TenLoaiHang])
                   VALUES
               ('" + txtmh.Text + "','" + txtth.Text + "')");
            }
            else
            {
                cmd = new SqlCommand(@"UPDATE[dbo].[LOAIHANG] SET TenLoaiHang = N'" + txtth.Text + "' WHERE MaLoaiHang = '" + txtmh.Text + "'");
            }
            cmd.Connection = Kn;
            if (Kn.State == ConnectionState.Closed) Kn.Open();
            int Kq = cmd.ExecuteNonQuery();
            if (Kq != 0)
            {
                MessageBox.Show("Lưu loại hàng thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Formloaihang_Load(sender, e);
            }
            block(true);
        }
        private bool kiemtratrungten()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT count(*)
            FROM [dbo].[LOAIHANG] WHERE TENLOAIHANG = N'" + txtth.Text + "'");
            cmd.Connection = Kn;
            if (Kn.State == ConnectionState.Closed) Kn.Open();
            int Kq = (int)cmd.ExecuteScalar();
            if (Kq != 0) return true;
            return false;
        }
        //private bool kiemtratrungma()
        //{
        //    SqlCommand cmd = new SqlCommand(@"SELECT count(*)
        //    FROM [dbo].[LOAIHANG] WHERE MALOAIHANG = N'" + txtmh.Text + "'");
        //    cmd.Connection = Kn;
        //    if (Kn.State == ConnectionState.Closed) Kn.Open();
        //    int Kq = (int)cmd.ExecuteScalar();
        //    if (Kq != 0) return true;
        //    return false;
        //}

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa loại hàng này không ????", "chú ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (kiemtramahangtheoloaihang() == true)
                {
                    MessageBox.Show("Có mặt hàng thuộc loại này nên không thể xóa", "chú ý",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    SqlCommand cmd = new SqlCommand(@"DELETE
                    [dbo].[LOAIHANG] WHERE MaLoaiHang = '" + txtmh.Text + "' AND TenLoaiHang = N'" + txtth.Text + "'");
                    if (Kn.State == ConnectionState.Closed) Kn.Open();
                    cmd.Connection = Kn;
                    int Kq = cmd.ExecuteNonQuery(); ;
                    if (Kq != 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Formloaihang_Load(sender, e);
                    }
                    else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Kn.Close();
                }
            }
        }
            private void block(bool khoa)
            {
            btnthem.Visible = (khoa);
            btnsua.Visible = (khoa);
            btnxoa.Visible = (khoa);
            btnluu.Visible = (!khoa);
            btnboqua.Visible = (!khoa);
            }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            Formloaihang_Load(sender, e);
            block(true);
        }

            private bool kiemtramahangtheoloaihang()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT count(*)
            FROM [dbo].[MATHANG] WHERE MALOAIHANG = N'" + txtmh.Text + "'");
            cmd.Connection = Kn;
            if (Kn.State == ConnectionState.Closed) Kn.Open();
            int Kq = (int)cmd.ExecuteScalar();
            if (Kq != 0) return true;
            return false;
        }
    }
}



