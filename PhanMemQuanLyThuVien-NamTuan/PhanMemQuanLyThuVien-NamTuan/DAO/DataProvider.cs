using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GUI;
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan.DAO
{
    public class DataProvider
    {
        public static SqlConnection KetNoiCSDL()
        {
            try
            {
                string sConn = @"Data Source=.;Initial Catalog=DBQuanLyThuVien;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sConn);
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối Cơ Sở Dữ Liệu...", ex);
            }
        }

        public static DataTable LayDuLieu(string query)
        {
            try
            {
                SqlConnection conn = KetNoiCSDL();
                conn.Open();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(data);
                conn.Close();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn dữ liệu...", ex);
            }
        }

        public static int ThaoTacDuLieu(string query)
        {
            int result;

            try
            {
                SqlConnection conn = KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thực thi truy vấn...", ex);
            }
            
            return result;
        }

        public static bool KTDangNhap(string MatKhau)
        {
            try
            {
                bool check = false;
                string MaTK = frmDangNhap.MaTK;
                string query = "SELECT MatKhau, Quyen FROM TaiKhoan WHERE MaTK = '" + MaTK + "' AND TrangThai = 1";
                DataTable data = LayDuLieu(query);

                if (data.Rows.Count > 0)
                {
                    string MatKhauTrongCSDL = data.Rows[0][0].ToString();
                    bool Quyen = (bool)data.Rows[0][1];

                    if (MatKhau == MatKhauTrongCSDL)
                    {
                        check = true;
                        frmDangNhap.Quyen = Quyen;
                    }
                }

                return check; 

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thực thi truy vấn...", ex);
            }
        }

        public static bool KTDoiMatKhau(string MatKhauHienTai, string MatKhauMoi)
        {
            try
            {
                bool check = true;

                // Lấy mật khẩu cũ từ csdl
                string MaTK = frmDangNhap.MaTK;
                string MatKhauCu = "";
                string query = "SELECT MatKhau FROM TaiKhoan";
                query += " WHERE MaTK = '" + MaTK + "'";
                SqlConnection conn = KetNoiCSDL();
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    MatKhauCu = reader.GetString(0);
                }
                reader.Close();

                //Kiểm tra mật khẩu hiện tại khớp với mật khẩu cũ 
                if (MatKhauHienTai == MatKhauCu)
                {
                    query = "UPDATE TaiKhoan SET MatKhau = '" + MatKhauMoi + "'";
                    query += " WHERE MaTK = '" + MaTK + "'";
                    ThaoTacDuLieu(query);
                }
                else check = false;

                conn.Close();

                return check;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thực thi truy vấn...", ex);
            }
        }

        public static void DoDuLieu(string column, string table, ComboBox cbo)
        {
            string query = "SELECT " + column + " FROM " + table;

            SqlConnection conn = KetNoiCSDL();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbo.Items.Add(value);
                }
            }
        }
    }
}
