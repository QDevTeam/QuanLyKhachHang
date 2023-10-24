using MySql.Data.MySqlClient;
using System.Data;
using System;
using MySqlX.XDevAPI.Common;

namespace cau1
{
    public class data
    {
        private static MySqlConnection db = new MySqlConnection("Server=216.9.227.213;Database=testne;Uid=testne;Pwd=4bReH7p5E2FFCx3N");

        public static List<khachhang> LayDanhSachKhachHang()
        {
            List<khachhang> list = new List<khachhang>();
            try
            {
                db.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "SELECT * FROM KhachHang";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    khachhang kh = new khachhang();
                    kh.MaKH = reader["MaKH"].ToString();
                    kh.TenKH = reader["HoTen"].ToString();
                    kh.NgaySinh = (DateTime)reader["NgaySinh"];
                    kh.DiaChi = reader["DiaChi"].ToString();
                    kh.SDT = reader["SDT"].ToString();

                    list.Add(kh);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
            return list;
        }

        public int ThemKhachHang(khachhang kh)
        {
            int result = 1;

            try
            {
                db.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "INSERT INTO KhachHang (HoTen, NgaySinh, DiaChi, SDT) VALUES (@TenKH, @NgaySinh, @DiaChi, @SDT)";

                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    result = 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = 0;
            }
            finally
            {
                db.Close();
            }

            return result;
        }

        public bool SuaKhachHang(khachhang kh)
        {
            bool result = true;

            try
            {
                db.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE KhachHang SET HoTen = @TenKH, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT WHERE MaKH = @MaKH";

                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    result = false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            finally
            {
                db.Close();
            }

            return result;

        }

        public bool XoaKhachHang(string maKH)
        {
            bool result = true;

            try
            {
                db.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "DELETE FROM KhachHang WHERE MaKH = @MaKH";

                cmd.Parameters.AddWithValue("@MaKH", maKH);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    result = false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            finally
            {
                db.Close();
            }

            return result;
        }
        public khachhang LayThongTinKH(int MaKH)
        {
            khachhang tt = null;
            try
            {
                db.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "SELECT * FROM KhachHang WHERE MaKH = @maKH";
                cmd.Parameters.AddWithValue("@maKH", MaKH);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tt = new khachhang();
                    tt.TenKH = reader["HoTen"].ToString();
                    tt.NgaySinh = (DateTime)reader["NgaySinh"];
                    tt.DiaChi = reader["DiaChi"].ToString();
                    tt.SDT = reader["SDT"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi lấy thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tt = null;
            }
            finally
            {
                db.Close();
            }
            return tt;
        }
        public static List<khachhang> TimKiemKH(string ten)
        {
            List<khachhang> list = new List<khachhang>();
            try
            {
                db.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "SELECT * FROM KhachHang WHERE HoTen LIKE '%"+ten+"%'";
                cmd.Parameters.AddWithValue("@tenKH", ten.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    khachhang kh = new khachhang();
                    kh.MaKH = reader["MaKH"].ToString();
                    kh.TenKH = reader["HoTen"].ToString();
                    kh.NgaySinh = (DateTime)reader["NgaySinh"];
                    kh.DiaChi = reader["DiaChi"].ToString();
                    kh.SDT = reader["SDT"].ToString();

                    list.Add(kh);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
            return list;
        }

    }
}
