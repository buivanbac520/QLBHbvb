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
    public partial class Formhoadon : Form
    {
        SqlConnection Kn = new SqlConnection(@"Data Source=MAY02\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        DataTable dtbgiohang = new DataTable();
        public Formhoadon()
        {
            InitializeComponent();
        }       
        private void Formhoadon_Load(object sender, EventArgs e)
        {
            taocomboxmathang();
            taogiohang();
            taocomboxkhachhang();
            TaoComboBoxnhanvien();
        }
        private void taocomboxmathang()
        {
            string sql = "SELECT * FROM MATHANG ";
            adapter = new SqlDataAdapter(sql, Kn);
            DataTable dtbMH = new DataTable();
            adapter.Fill(dtbMH);
            comboBoxMaHang.DataSource = dtbMH;
            comboBoxMaHang.DisplayMember = "TenHang";
            comboBoxMaHang.ValueMember = "MaHang";
        }
        private void laythongtinmathang()
        {
            DataTable dtbMH = (DataTable)comboBoxMaHang.DataSource;
            DataRow[] dr = dtbMH.Select("MaHang='" + comboBoxMaHang.SelectedValue + "'");
            if (dr.Length > 0)
            {
                textBoxTenHang.Text = dr[0]["tenhang"].ToString();
                textBoxDonGia.Text = dr[0]["GiaHang"].ToString();
                textBoxSoLuong.Text = dr[0]["Soluong"].ToString();
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            dtbgiohang.Rows.Add(comboBoxMaHang.SelectedValue, textBoxTenHang.Text, textBoxDonGia.Text, textBoxSoLuong.Text, textBoxGiamGia.Text);
            txtTongTien.Text = tinhtien().ToString();
        }
        private void taogiohang()
        {
            dtbgiohang.Columns.Add("MaHang");
            dtbgiohang.Columns.Add("TenHang");
            dtbgiohang.Columns.Add("GiaBan");
            dtbgiohang.Columns.Add("SoLuong");
            dtbgiohang.Columns.Add("MucGiamGia");
            dataGridViewDonHang.DataSource = dtbgiohang;
        }
        private void comboBoxMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            laythongtinkhachhang();
        }
        private double tinhtien()
        {
            double TongTien = 0;
            foreach (DataRow monhang in dtbgiohang.Rows)
            {
                TongTien += Convert.ToDouble(monhang["SoLuong"].ToString()) * Convert.ToDouble(monhang["GiaBan"].ToString());
            }
            return TongTien;
        }

        private void dataGridViewDonHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dtbgiohang.Rows.Count > 0)
            {
                int stt = dataGridViewDonHang.CurrentRow.Index;
                dataGridViewDonHang.Rows.RemoveAt(stt);
            }
            txtTongTien.Text = tinhtien().ToString();
        }

        private void taocomboxkhachhang()
        {
            string sql = "SELECT * FROM KHACHHANG";
            adapter = new SqlDataAdapter(sql, Kn);
            DataTable dtbkh = new DataTable();
            adapter.Fill(dtbkh);
            comboBoxMaKH.DisplayMember = "TenCongTy";
            comboBoxMaKH.ValueMember = "MaKhachHang";
            comboBoxMaKH.DataSource = dtbkh;
        }
        private void laythongtinkhachhang()
        {
            DataTable dtbkh = (DataTable)comboBoxMaKH.DataSource;
            if (comboBoxMaKH.SelectedValue == null) return;
            DataRow[] dr = dtbkh.Select("MaKhachHang= " + comboBoxMaKH.SelectedValue.ToString() + "");
            if (dr.Length > 0)
            {
                txt_tenkh.Text = dr[0]["TencongTy"].ToString();
                txt_diachi.Text = dr[0]["DiaChi"].ToString();
                txt_dienthoai.Text = dr[0]["DienThoai"].ToString();
            }
        }
        private void TaoComboBoxnhanvien()
        {
            string sql = "SELECT * FROM NHANVIEN ";
            adapter = new SqlDataAdapter(sql, Kn);
            DataTable dtbNV = new DataTable();
            adapter.Fill(dtbNV);           
            comboBoxMaNV.DisplayMember = "MaNhanVien";
            comboBoxMaNV.ValueMember = "MaNhanVien";
            comboBoxMaNV.DataSource = dtbNV;
        }
        private void laythongtinnhanvien()
        {
            DataTable dtbNV = (DataTable)comboBoxMaNV.DataSource;
            DataRow[] dr = dtbNV.Select("MaNhanVien='" + comboBoxMaNV.SelectedValue + "'");
            if (dr.Length > 0)
            {
                textBoxTenNV.Text = dr[0]["Ten"].ToString();
            }
        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            laythongtinnhanvien();
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (txt_SoHD.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào số hóa đơn", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SoHD.Focus();
                return;
            }
            if (kiemtratrungsoHD() == true)
            {
                MessageBox.Show("Số hóa đơn bị trùng");
                txt_SoHD.Focus();
                return;
            }
            if (dtbgiohang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang rỗng, hãy thêm hàng vào giỏ");
                return;
            }
            if (themHoaDon()== true)
            {
                if (themChiTietHoaDon()== true)
                {
                    MessageBox.Show("Lưu hóa đơn thành công");
                }
                else
                {
                    MessageBox.Show("Lưu hóa đơn không thành công");
                }
            }
        }
        private bool kiemtratrungsoHD()
        {
            string sql = "SELECT * FROM HOADON WHERE SOHOADON='" + txt_SoHD.Text + "'";
            adapter = new SqlDataAdapter(sql, Kn);
            DataTable dtbkt = new DataTable();
            adapter.Fill(dtbkt);
            if (dtbkt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        private bool themHoaDon()
        {
            string sqlHD = @"INSERT INTO [dbo].[HOADON]
           ([SoHoaDon]
           ,[MaKhachHang]
           ,[MaNhanVien]
           ,[NgayDatHang]
           ,[NgayGiaoHang]
           ,[NgayChuyenHang]
           ,[NoiChuyenHang])
     VALUES
           ('" + txt_SoHD.Text + "', '" + comboBoxMaKH.SelectedValue + "' , '" + comboBoxMaNV.SelectedValue + "', '"
           + dateTimePickerNgayDat.Value + "', '" + dateTimePickerNgayGiao.Value + "', '" + dateTimePickerNgayChuyen.Value + "', '"
           + textBoxNoiChuyen.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlHD, Kn);
            if (Kn.State == ConnectionState.Closed)
                Kn.Open();
            int kq = cmd.ExecuteNonQuery();
            {
                if (kq != 0)
                    return true;
                return false;
            }
        }
        private bool themChiTietHoaDon()
        {
            foreach (DataRow monhang in dtbgiohang.Rows)
                {
            string sqlCTHD = @"INSERT INTO [dbo].[CHITIETHOADON]
           ([SoHoaDon]
           ,[MaHang]
           ,[GiaBan]
           ,[SoLuong]
           ,[MucGiamGia])
     VALUES
           ('" + txt_SoHD.Text +"','" + monhang["MaHang"].ToString() +"','" + monhang["GiaBan"].ToString() +"','" + monhang["SoLuong"].ToString() + "','" + monhang["MucGiamGia"].ToString() + "')";
            SqlCommand cmd = new SqlCommand(sqlCTHD, Kn);
            if (Kn.State == ConnectionState.Closed)
                Kn.Open();
                int kq = cmd.ExecuteNonQuery();      
                                
                }
            return true;
            return false;
           }
        private void timHoaDon()
        {
            string sql = "SELECT * FROM HOADON WHERE SOHOADON='" + textBoxTimKiem.Text + "'";
            adapter = new SqlDataAdapter(sql, Kn);
            DataTable dtbTHD = new DataTable();
            adapter.Fill(dtbTHD);
            if (dtbTHD.Rows.Count>0)
            {
                txt_SoHD.Text = dtbTHD.Rows[0][0].ToString();
                comboBoxMaKH.SelectedValue = dtbTHD.Rows[0][1].ToString();
                comboBoxMaNV.SelectedValue = dtbTHD.Rows[0][2].ToString();
                dateTimePickerNgayDat.Value = Convert.ToDateTime(dtbTHD.Rows[0][3].ToString());
                dateTimePickerNgayGiao.Value = Convert.ToDateTime(dtbTHD.Rows[0][4].ToString());
                dateTimePickerNgayChuyen.Value = Convert.ToDateTime(dtbTHD.Rows[0][5].ToString());
                textBoxNoiChuyen.Text = dtbTHD.Rows[0][6].ToString();
            }
            else
            {
                MessageBox.Show("Số đơn này không tồn tại ");
                return;
            }
            string sqlCTHD = @"SELECT MH.MAHANG, TENHANG, MH.SOLUONG, GIABAN, MUCGIAMGIA 
            FROM CHITIETHOADON CT INNER JOIN MATHANG MH ON CT.MAHANG= MH.MAHANG WHERE SOHOADON= '" + textBoxTimKiem.Text + "'";
            adapter = new SqlDataAdapter(sqlCTHD, Kn);
            DataTable dtbTimCTHD = new DataTable();
            adapter.Fill(dtbTimCTHD);
            dataGridViewDonHang.DataSource = dtbTimCTHD;
        }

        private void btntTHD_Click(object sender, EventArgs e)
        {
            timHoaDon();
        }

        private void comboBoxMaHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            laythongtinmathang();
        }
    }
}
