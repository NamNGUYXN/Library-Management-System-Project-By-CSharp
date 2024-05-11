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
    public class PhieuMuonTraBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM PhieuMuonTra";
            return PhieuMuonTraDAO.GetData(query);
        }

        public static int InsertData()
        {
            return PhieuMuonTraDAO.InsertData();
        }

        public static int UpdateData()
        {
            return PhieuMuonTraDAO.UpdateData();
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM PhieuMuonTra WHERE " + key + " LIKE @" + key;
            ParameterCSDL param = new ParameterCSDL(key, "%" + value + "%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return PhieuMuonTraDAO.GetData(query, LstParam);
        }
    }
}
