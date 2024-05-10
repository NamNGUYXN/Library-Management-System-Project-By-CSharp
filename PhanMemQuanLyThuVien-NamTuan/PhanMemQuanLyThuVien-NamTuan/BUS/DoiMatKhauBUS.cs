using PhanMemQuanLyThuVien_NamTuan.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class DoiMatKhauBUS
    {
        public static bool KTDoiMatKhau(string MatKhauHienTai, string MatKhauMoi)
        {
            return DataProvider.KTDoiMatKhau(MatKhauHienTai, MatKhauMoi);
        }
    }
}
