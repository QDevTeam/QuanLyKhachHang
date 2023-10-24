using K4os.Hash.xxHash;
using OfficeOpenXml;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace cau1
{

    public partial class Form1 : Form
    {
        xuly xl = new xuly();
        public static bool isDataUpdated = false;
        public static int selectrow, rowindex = 0;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            List<khachhang> dsKhachHang = xuly.LayDSKhachHang();
            dataGridView1.DataSource = dsKhachHang;
            dataGridView1.Rows[0].Selected = true;
            this.KeyPreview = true;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            dataGridView1.Columns[0].HeaderText = "Mã KH";
            dataGridView1.Columns[1].HeaderText = "Tên KH";
            dataGridView1.Columns[2].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[3].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[4].HeaderText = "SĐT";
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
                selectrow = 0;
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
                MessageBox.Show("Vui lòng chọn khách hàng muốn sửa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectrow != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?",
                                      "Xác Nhận Xóa",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool resultxoa = xl.XoaKhachHang(selectrow.ToString());
                    if (resultxoa)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                        selectrow = 0;
                        LoadDanhSachKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng!",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                        selectrow = 0;
                        LoadDanhSachKhachHang();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Vui lòng chờ...";
            button4.Enabled = false;
            if (textBox1.Text.Length > 0)
            {
                selectrow = 0;
                dataGridView1.Columns.Clear();
                List<khachhang> dsKhachHang = xl.TimKiemKH(textBox1.Text.ToString());
                dataGridView1.DataSource = dsKhachHang;
                button5.Visible = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng muốn tìm kiếm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button4.Text = "Tìm Kiếm";
            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectrow = 0;
            button5.Visible = false;
            textBox1.Text = "";
            dataGridView1.Columns.Clear();
            LoadDanhSachKhachHang();
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D2)
            {
                button2_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.D1)
            {
                button1_Click(sender, e);
            }
            if ((e.Control && e.KeyCode == Keys.D3) || (e.KeyCode == Keys.Delete))
            {
                button3_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.D4)
            {
                button5_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.D5)
            {
                textBox1.Focus();
            }
            if (e.Control && e.KeyCode == Keys.D6)
            {
                XuatDuLieu();
            }
            if (e.Control && e.KeyCode == Keys.D7)
            {
                CloseApp();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
            MessageBox.Show("Tải lại danh sách thành công!", "Hệ Thống!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApp();
        }
        private void ShowAboutDialog()
        {
            string aboutMessage = "Ứng dụng Quản lý khách hàng\nỨng dụng này được code bởi HDQuanDev, để dùng vào mục đích học tập!\n\n";
            aboutMessage += "Phím tắt:\n";
            aboutMessage += " - Ctrl+1: Thêm khách hàng\n";
            aboutMessage += " - Ctrl+2: Sửa thông tin khách hàng\n";
            aboutMessage += " - Ctrl+3, Del: Xóa khách hàng\n";
            aboutMessage += " - Ctrl+4: Tải lại danh sách khách hàng\n";
            aboutMessage += " - Ctrl+5: Tìm kiếm khách hàng\n";
            aboutMessage += " - Ctrl+6: Xuất danh sách khách hàng\n";
            aboutMessage += " - Ctrl+S: Lưu dữ liệu khi chỉnh sửa hoặc thêm khách hàng\n";
            aboutMessage += " - Ctrl+7: Thoát ứng dụng\n";

            MessageBox.Show(aboutMessage, "Thông tin ứng dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowAboutDialog();
        }
        private void CloseApp()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4_Click(sender, e);
            }
        }
        private void XuatDuLieu()
        {
            try
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách khách hàng");

                    for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        package.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                        MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XuatDuLieu();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void ShowContact()
        {
            string message = "Liên hệ với tôi qua Facebook: @Quancp72h\n\n";
            string facebookLink = "https://www.facebook.com/quancp72h";

            DialogResult result = MessageBox.Show(message, "Liên hệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                try
                {
                    Process.Start(facebookLink);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở liên kết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowContact();
        }
    }
}