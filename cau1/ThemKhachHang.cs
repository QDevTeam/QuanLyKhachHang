using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cau1
{

    public partial class ThemKhachHang : Form
    {

        public khachhang ThongTinKhachHang { get; set; }
        xuly xl = new xuly();
        public ThemKhachHang()
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            WindowState = FormWindowState.Normal;
            this.FormClosing += ThemKhachHang_FormClosing;
            this.KeyPreview = true;
        }
        private void ThemKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.isDataUpdated = true;
        }
        private void them_click_Click(object sender, EventArgs e)
        {

            them_click.Enabled = false;
            if (IsValid())
            {
                ThongTinKhachHang = new khachhang();
                ThongTinKhachHang.TenKH = them_tenkhachhang.Text;
                ThongTinKhachHang.NgaySinh = DateTime.Parse(them_ngaysinh.Text);
                ThongTinKhachHang.DiaChi = them_diachi.Text;
                ThongTinKhachHang.SDT = them_sdt.Text;
                khachhang kh = ThongTinKhachHang;
                int value = xl.ThemMoiKhachHang(kh);
                if (value == 1)
                {
                    if (MessageBox.Show("Thêm Khách Hàng Thành Công, bạn có muốn đóng form!", "Thành Công!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form1.isDataUpdated = true;
                        this.Close();
                    }
                    else
                    {
                        Form1.isDataUpdated = true;
                        ResetForm();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi Dữ Liệu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            them_click.Enabled = true;
        }

        private void them_ngaysinh_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex reg = new Regex(@"^(\d{4})/(\d{1,2})/(\d{1,2})$");
            Match m = reg.Match(them_ngaysinh.Text);
            if (m.Success)
            {
                int dd = int.Parse(m.Groups[3].Value);
                int mm = int.Parse(m.Groups[2].Value);
                int yyyy = int.Parse(m.Groups[1].Value);
                e.Cancel = dd < 1 || dd > 31 || mm < 1 || mm > 12 || yyyy > 2012;
            }
            else e.Cancel = true;
            if (e.Cancel)
            {
                if (MessageBox.Show("Vui lòng nhập đúng định dạng năm/tháng/ngày", "Lỗi Dữ Liệu!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.Cancel)
                    e.Cancel = false;
            }
        }

        private bool IsValid()
        {
            bool isValid = true;

            if (them_tenkhachhang.Text.Length == 0)
            {
                isValid = false;
            }

            if (them_ngaysinh.Text.Length == 0)
            {
                isValid = false;
            }

            if (them_diachi.Text.Length == 0)
            {
                isValid = false;
            }

            if (them_sdt.Text.Length == 0)
            {
                isValid = false;
            }

            return isValid;
        }
        public void ResetForm()
        {
            them_tenkhachhang.Text = "";
            them_ngaysinh.Text = "";
            them_diachi.Text = "";
            them_sdt.Text = "";
        }

        private void ThemKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                them_click_Click(sender, e);
            }
        }
    }
}
