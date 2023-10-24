using System;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace cau1
{
    public partial class Form1 : Form
    {
        xuly xl = new xuly();
        public static bool isDataUpdated = false;
        public static int selectrow,rowindex = 0;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            List<khachhang> dsKhachHang = xuly.LayDSKhachHang();
            dataGridView1.DataSource = dsKhachHang;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThemKhachHang f2 = new ThemKhachHang();
            f2.ShowDialog();
            if (isDataUpdated)
            {
                LoadDanhSachKhachHang();
                isDataUpdated = false;
            }
        }
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string select = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                selectrow = int.Parse(select);
                rowindex = e.RowIndex;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }
        public bool LoadDanhSachKhachHang()
        {
            List<khachhang> dsKhachHang = xuly.LayDSKhachHang();
            dataGridView1.DataSource = dsKhachHang;
            dataGridView1.ClearSelection();
            if (selectrow != 0)
            {
                dataGridView1.Rows[rowindex].Selected = true;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectrow != 0)
            {
                khachhang tt = xl.LayThongTinKH(selectrow);
                SuaKhachHang sua = new SuaKhachHang(tt);
                sua.ShowDialog();
                if (isDataUpdated)
                {
                    LoadDanhSachKhachHang();
                    isDataUpdated = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn sửa!", "Lỗi!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }


    }
}