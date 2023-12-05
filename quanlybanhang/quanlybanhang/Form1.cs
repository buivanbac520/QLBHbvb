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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.MATHANG' table. You can move, or remove it, as needed.
            this.mATHANGTableAdapter.Fill(this.qLBHDataSet.MATHANG);
            ketnoiCSDL();
            comboloaihang1();
            congty();
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {

        }

        private void ketnoiCSDL()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=MAY02\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
            string sql = "SELECT * FROM MATHANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, kn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
           }
         private void comboloaihang1()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=MAY02\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
            string sql = "SELECT * FROM LOAIHANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, kn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            comboloaihang.DataSource = ds.Tables[0];
            comboloaihang.DisplayMember = "TenLoaiHang";
            comboloaihang.ValueMember = "MaLoaiHang";
        }

        private void congty()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=MAY02\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
            string sql = "SELECT * FROM nhacungcap";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, kn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "TenCongTy";
            comboBox1.ValueMember = "MacongTy";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
