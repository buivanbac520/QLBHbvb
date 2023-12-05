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
    public partial class Formkhachhang : Form
    {
        SqlConnection Kn = new SqlConnection(@"Data Source=MAY02\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
        SqlDataAdapter adap = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        SqlCommand cmd = new SqlCommand();
        bool them = false;
        public Formkhachhang()
        {
            InitializeComponent();
        }

        private void Formkhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet4.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLBHDataSet4.KHACHHANG);
            databin();
        }
        private void databin()
        {
            string sql = "SELECT * FROM KHACHHANG";
            adap = new SqlDataAdapter(sql, Kn);
            ds.Clear();
            adap.Fill(ds);
            bs.DataSource = ds.Tables[0];
            txtkh.DataBindings.Clear();
            txtct.DataBindings.Clear();
            txtgd.DataBindings.Clear();
            txtdt.DataBindings.Clear();
            txtdc.DataBindings.Clear();
            txtemail.DataBindings.Clear();
            txtfax.DataBindings.Clear();
            txtkh.DataBindings.Add("text", bs, "MaKhachHang", true);
            txtct.DataBindings.Add("text", bs, "TenCongTy", true);
            txtgd.DataBindings.Add("text", bs, "TenGiaoDich", true);
            txtdt.DataBindings.Add("text", bs, "DienThoai", true);
            txtdc.DataBindings.Add("text", bs, "DiaChi", true);
            txtemail.DataBindings.Add("text", bs, "Email", true);
            txtfax.DataBindings.Add("text", bs, "Fax", true);
            dataGridView1.DataSource = bs;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtkh.Clear();
            txtct.Clear();
            txtgd.Clear();
            txtdt.Clear();
            txtdc.Clear();
            txtemail.Clear();
            txtfax.Clear();
            txtfax.Focus();
            txtkh.Enabled = (true);
            txtct.Enabled = (true);
            txtgd.Enabled = (true);
            txtdt.Enabled = (true);
            txtdc.Enabled = (true);
            txtemail.Enabled = (true);
            txtfax.Enabled = (true);
            block(false);
            them = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txtkh.Enabled = (true);
            txtct.Enabled = (true);
            txtgd.Enabled = (true);
            txtdt.Enabled = (true);
            txtdc.Enabled = (true);
            txtemail.Enabled = (true);
            txtfax.Enabled = (true);
            block(false);
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
            Formkhachhang_Load(sender, e);
            block(true);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                if (txtkh.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtkh.Focus();
                    return;
                }
                if (txtct.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập tên công ty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtct.Focus();
                    return;
                }
                //if (kiemtratrungma() == true)
                //{
                //    MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (kiemtratrungten() == true)
                {
                    MessageBox.Show("Tên khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmd = new SqlCommand(@"INSERT INTO [dbo].[KHACHHANG] ([MaKhachHang],[TenCongTy],[TenGiaoDich],[DiaChi],[Email],[DienThoai],[Fax]) VALUES (" + txtkh.Text + ", N'" + txtct.Text + "', N'" + txtgd.Text + "', N'" + txtdc.Text + "', N'" + txtemail.Text + "', '" + txtdt.Text + "', '" + txtfax.Text + "')");
                if (Kn.State == ConnectionState.Closed) Kn.Open();
                cmd.Connection = Kn;
            }
            else
            {

                cmd = new SqlCommand(@"UPDATE [dbo].[KHACHHANG] SET TenCongTy = N'" + txtct.Text + "', TenGiaoDich = N'" + txtgd.Text + "', DiaChi = N'" + txtdc.Text + "', Email = N'" + txtemail.Text + "',DienThoai = '" + txtdt.Text + "',Fax = '" + txtfax.Text + "' WHERE MaKhachHang = " + txtkh.Text + "");
                if (Kn.State == ConnectionState.Closed) Kn.Open();
                cmd.Connection = Kn;
            }

            int KQ = cmd.ExecuteNonQuery();
            if (KQ != 0)
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Formkhachhang_Load(sender, e);
            }
            else MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Kn.Close();
            block(true);
        }
        private bool kiemtratrungten()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT count(*)
            FROM [dbo].[KHACHHANG] WHERE TenCongTy = N'" + txtct.Text + "'");
            cmd.Connection = Kn;
            if (Kn.State == ConnectionState.Closed) Kn.Open();
            int Kq = (int)cmd.ExecuteScalar();
            if (Kq != 0) return true;
            return false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không ????", "chú ý",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (kiemtramahangtheokhachhang() == true)
                {
                    MessageBox.Show("Có đơn hàng thuộc loại này nên không thể xóa", "chú ý",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    SqlCommand cmd = new SqlCommand(@"DELETE
                    [dbo].[KHACHHANG] WHERE MaKhachHang = N'" + txtkh.Text + "' AND TenCongTy = N'" + txtct.Text + "' AND TenGiaoDich = N'" + txtgd.Text + "' AND DiaChi = N'" + txtdc.Text + "' AND Email = N'" + txtemail.Text + "' AND DienThoai = N'" + txtdt.Text + "' AND Fax = N'" + txtfax.Text + "' ");
                    if (Kn.State == ConnectionState.Closed) Kn.Open();
                    cmd.Connection = Kn;
                    int Kq = cmd.ExecuteNonQuery(); ;
                    if (Kq != 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Formkhachhang_Load(sender, e);
                    }
                    else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Kn.Close();
                }
            }
        }
                private bool kiemtramahangtheokhachhang()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT count(*)
            FROM [dbo].[HOADON] WHERE MAKHACHHANG = N'" + txtkh.Text + "'");
            cmd.Connection = Kn;
            if (Kn.State == ConnectionState.Closed) Kn.Open();
            int Kq = (int)cmd.ExecuteScalar();
            if (Kq != 0) return true;
            return false;
        }
     }
}

