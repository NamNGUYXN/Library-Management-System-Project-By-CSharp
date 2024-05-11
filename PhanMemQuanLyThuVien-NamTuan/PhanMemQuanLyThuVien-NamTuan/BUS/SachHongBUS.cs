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
    public class SachHongBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM SachHong WHERE TrangThai = 1";
            return SachHongDAO.GetData(query);
        }

        public static int InsertData()
        {
            return SachHongDAO.InsertData();
        }

        public static int UpdateData()
        {
            return SachHongDAO.UpdateData();
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM SachHong WHERE TrangThai = 1";
            query += " AND " + key + " LIKE @" + key;
            ParameterCSDL param = new ParameterCSDL(key, "%" + value + "%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return SachHongDAO.GetData(query, LstParam);
        }
    }
}
