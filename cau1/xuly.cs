using System.Text.RegularExpressions;

namespace cau1
{
    public class xuly
    {
        data db = new data();
        public static List<khachhang> LayDSKhachHang()
        {
            return data.LayDanhSachKhachHang();
        }

        public int ThemMoiKhachHang(khachhang kh)
        {
            if (KiemTraHopLe(kh))
            {
               return db.ThemKhachHang(kh);
            }
            return -1;
        }

        public bool SuaKhachHang(khachhang kh)
        {
            if (KiemTraHopLe(kh))
            {
                return db.SuaKhachHang(kh);
            }
            return false;
        }
        public List<khachhang> TimKiemKH(string tenKH)
        {
            return data.TimKiemKH(tenKH);
        }
        public bool XoaKhachHang(string maKH)
        {
            return db.XoaKhachHang(maKH);
        }

        public khachhang LayThongTinKH(int MaKH)
        {
            return db.LayThongTinKH(MaKH);
        }
        private bool KiemTraHopLe(khachhang kh)
        {
            if (!IsFullNameValid(kh.TenKH))
            {
                MessageBox.Show("Tên KH không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (kh.NgaySinh > DateTime.Today || !IsValidDate(kh.NgaySinh.ToString()))
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsAddressValid(kh.DiaChi))
            {
                MessageBox.Show("Địa chỉ không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsPhoneNumberValid(kh.SDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool IsValidDate(string value)
        {
            DateTime dt;
            bool success = DateTime.TryParse(value, out dt);
            return success;
        }

        public static bool IsFullNameValid(string ten)
        {
            if (ten.Length < 2)
            {
                return false;
            }

            if (ten.Length > 50)
            {
                return false;
            }

            return true;
        }

        public static bool IsAddressValid(string address)
        {
            if (address.Length < 5)
            {
                return false;
            }

            if (address.Length > 100)
            {
                return false;
            }

            return true;
        }

        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            if (phoneNumber.Length != 10 && phoneNumber.Length != 11)
            {
                return false;
            }

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!Char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }

            if (phoneNumber.Length == 11)
            {
                if (phoneNumber[0] != '0')
                {
                    return false;
                }
            }
            return true;
        }


    }
}
