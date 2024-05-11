using PhanMemQuanLyThuVien_NamTuan.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class DangNhapBUS
    {
        public static bool CheckLogin(string MatKhau)
        {
            return DangNhapDAO.CheckLogin(MatKhau);
        }
    }
}
