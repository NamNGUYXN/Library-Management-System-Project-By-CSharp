using GUI;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.DAO
{
    public class DangNhapDAO
    {
        public static bool CheckLogin(string MatKhau)
        {
            bool check = false;
            string query = "SELECT MatKhau, Quyen FROM TaiKhoan WHERE MaTK = @MaTK AND TrangThai = 1";
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            ParameterCSDL param = new ParameterCSDL("MaTK", frmDangNhap.MaTK);
            LstParam.Add(param);
            DataTable data = DataProvider.GetData(query, LstParam);

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
    }
}
