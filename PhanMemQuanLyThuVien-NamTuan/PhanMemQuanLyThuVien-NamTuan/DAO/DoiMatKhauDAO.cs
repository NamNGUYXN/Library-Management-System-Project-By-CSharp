using GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.DAO
{
    public class DoiMatKhauDAO
    {
        public static bool CheckChangePassword(string MatKhauHienTai, string MatKhauMoi)
        {
            bool check = false;
            string MaTK = frmDangNhap.MaTK;
            // Lấy mật khẩu cũ từ csdl
            string query = $"SELECT MatKhau FROM TaiKhoan WHERE MaTK = '{MaTK}'";
            DataTable data = DataProvider.GetData(query);
            string MatKhauCu = data.Rows[0][0].ToString();

            //Kiểm tra mật khẩu hiện tại khớp với mật khẩu cũ 
            if (MatKhauHienTai == MatKhauCu)
            {
                query = $"UPDATE TaiKhoan SET MatKhau = '{MatKhauMoi}' WHERE MaTK = '{MaTK}'";
                DataProvider.ExcuteSQL(query);
                check = true;
            }

            return check;
        }
    }
}
