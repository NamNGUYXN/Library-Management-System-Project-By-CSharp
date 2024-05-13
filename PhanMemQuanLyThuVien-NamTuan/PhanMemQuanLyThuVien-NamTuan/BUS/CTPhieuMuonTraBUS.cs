using PhanMemQuanLyThuVien_NamTuan.DAO;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class CTPhieuMuonTraBUS
    {
        public static DataTable GetData(string query, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM CTPhieuMuonTra";
            return CTPhieuMuonTraDAO.GetData(query, LstParams);
        }

        public static int InsertData(string MaPhieu, string MaSach)
        {
            string query = $"INSERT INTO CTPhieuMuonTra (MaPhieu, MaSach) VALUES ('{MaPhieu}', '{MaSach}')";
            return CTPhieuMuonTraDAO.InsertData(query, null);
        }
    }
}
