using PhanMemQuanLyThuVien_NamTuan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class TuDongTao
    {
        public static string MaKeTiep(string LoaiMa, string LoaiBang, string KiTuDau)
        {
            string MaKeTiep = KiTuDau + "001";
            // Tìm mã cao nhất trong csdl
            string query = "SELECT MAX(" + LoaiMa + ") FROM " + LoaiBang;
            DataTable data = DataProvider.LayDuLieu(query);
            string MaToiDa = data.Rows[0][0].ToString();

            if (MaToiDa != "")
            {
                // Tách ra phần chuỗi và số
                string StringPart = Regex.Match(MaToiDa, @"[A-Z]+").Value;
                int NumberPart = int.Parse(Regex.Match(MaToiDa, @"\d+").Value);

                // Tăng phần số lên 1 đơn vị
                NumberPart++;

                // Nối phần chuỗi và số lại
                MaKeTiep = StringPart + NumberPart.ToString("D3");
            }

            return MaKeTiep;
        }
    }
}
