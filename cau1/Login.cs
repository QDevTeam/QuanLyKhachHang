namespace cau1
{
    public partial class Login : Form
    {
        Loading fLoading;
        public Login()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            WindowState = FormWindowState.Normal;
            textBox1.Text = "admin";
            textBox2.Text = "12345";
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "admin" && textBox2.Text.ToString() == "12345")
            {
                MessageBox.Show("Đăng Nhập Thành Công, Vui lòng chờ hệ thống lấy dữ liệu!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                fLoading = new Loading();
                fLoading.Show();
                Form1 main = new Form1();
                for (int i = 0; i < 100; i++)
                {
                    int percent = i;
                    fLoading.Invoke(new Action(() =>
                    {
                        fLoading.UpdateProgress(percent);
                    }));
                    Thread.Sleep(10);
                }
                Thread.Sleep(1000);
                fLoading.Hide();
                main.ShowDialog();
                Thread.Sleep(1000);
                fLoading.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
