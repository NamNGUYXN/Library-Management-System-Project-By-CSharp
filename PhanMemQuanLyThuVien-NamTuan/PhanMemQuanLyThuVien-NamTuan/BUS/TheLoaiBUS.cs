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
    public class TheLoaiBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM TheLoai WHERE TrangThai = 1";
            return TheLoaiDAO.GetData(query, LstParams);
        }

        public static int InsertData(List<ParameterCSDL> LstParams)
        {
            string query = $"INSERT INTO TheLoai (MaTL, TenTL, TrangThai)";
            query += " VALUES(@MaTL, @TenTL, 1)";
            return TheLoaiDAO.InsertData(query, LstParams);
        }

        public static int UpdateData(List<ParameterCSDL> LstParams)
        {
            string query = $"UPDATE TheLoai SET TenTL = @TenTL WHERE MaTL = @MaTL";
            return TheLoaiDAO.UpdateData(query, LstParams);
        }

        public static int DeleteData(string MaTL)
        {
            string query = $"UPDATE TheLoai SET TrangThai = 0 WHERE MaTL = '{MaTL}'";
            return TheLoaiDAO.DeleteData(query);
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM TheLoai WHERE TrangThai = 1";
            query += " AND " + key + " LIKE @" + key;
            ParameterCSDL param = new ParameterCSDL(key, "%" + value + "%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return TheLoaiDAO.GetData(query, LstParam);
        }
    }
}
