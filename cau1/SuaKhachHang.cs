﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau1
{
    public partial class SuaKhachHang : Form
    {
        Form1 main = new Form1();
        public khachhang SuaThongTinKH { get; set; }
        xuly xl = new xuly();
        public SuaKhachHang(khachhang tt)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            WindowState = FormWindowState.Normal;
            sua_tenkhachhang.Text = tt.TenKH.ToString();
            sua_ngaysinh.Text = tt.NgaySinh.ToString("yyyy/MM/dd");
            sua_diachi.Text = tt.DiaChi.ToString();
            sua_sdt.Text = tt.SDT.ToString();
        }

        private void SuaKhachHang_Load(object sender, EventArgs e)
        {
            this.Text = "Sửa khách hàng mã: " + Form1.selectrow;
        }

        private void sua_click_Click(object sender, EventArgs e)
        {
            sua_click.Enabled = false;
            if (IsValid())
            {
                SuaThongTinKH = new khachhang();
                SuaThongTinKH.MaKH = Form1.selectrow.ToString();
                SuaThongTinKH.TenKH = sua_tenkhachhang.Text;
                SuaThongTinKH.NgaySinh = DateTime.Parse(sua_ngaysinh.Text);
                SuaThongTinKH.DiaChi = sua_diachi.Text;
                SuaThongTinKH.SDT = sua_sdt.Text;
                khachhang kh = SuaThongTinKH;
                bool value = xl.SuaKhachHang(kh);
                if (value)
                {
                    if (MessageBox.Show("Sửa Thông Tin Khách Hàng Thành Công, bạn có muốn đóng form!", "Thành Công!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form1.isDataUpdated = true;
                        this.Close();
                    }
                    else
                    {
                        Form1.isDataUpdated = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi Dữ Liệu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            sua_click.Enabled = true;
        }

        private void sua_ngaysinh_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^(\d{4})/(\d{1,2})/(\d{1,2})$");
            Match m = reg.Match(sua_ngaysinh.Text);
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
                if (MessageBox.Show("Vui lòng nhập đúng định dạng năm/tháng/ngày", "Lỗi Dữ Liệu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    e.Cancel = false;
            }
        }

        private bool IsValid()
        {
            bool isValid = true;

            if (sua_tenkhachhang.Text.Length == 0)
            {
                isValid = false;
            }

            if (sua_ngaysinh.Text.Length == 0)
            {
                isValid = false;
            }

            if (sua_diachi.Text.Length == 0)
            {
                isValid = false;
            }

            if (sua_sdt.Text.Length == 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
