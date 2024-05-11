using PhanMemQuanLyThuVien_NamTuan.DAO;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class TacGiaBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM TacGia WHERE TrangThai = 1";
            return TacGiaDAO.GetData(query);
        }

        public static int InsertData(List<ParameterCSDL> LstParams)
        {
            string query = "INSERT INTO TacGia (MaTG, HoTenTG, GioiTinh, QueQuan, TrangThai)";
            query += " VALUES (@MaTG, @HoTenTG, @GioiTinh, @QueQuan, 1)";
            return TacGiaDAO.InsertData(query, LstParams);
        }

        public static int UpdateData(List<ParameterCSDL> LstParams)
        {
            string query = "UPDATE TacGia SET HoTenTG = @HoTenTG, GioiTinh = @GioiTinh, QueQuan = @QueQuan";
            query += " WHERE MaTG = @MaTG";
            return TacGiaDAO.UpdateData(query, LstParams);
        }

        public static int DeleteData(string MaTG)
        {
            string query = $"UPDATE TacGia SET TrangThai = 0 WHERE MaTG = '{MaTG}'";
            return TacGiaDAO.DeleteData(query);
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM TacGia WHERE TrangThai = 1";
            query += " AND " + key + " LIKE @" + key;
            ParameterCSDL param = new ParameterCSDL(key, "%" + value + "%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return TacGiaDAO.GetData(query, LstParam);
        }

        public static string CreateNextId()
        {
            string NextId = "TG001";
            // Tìm mã cao nhất trong csdl
            string query = $"SELECT MAX(MaTG) FROM TacGia";
            DataTable data = TacGiaDAO.GetData(query);
            string MaxId = data.Rows[0][0].ToString();

            if (MaxId != "")
            {
                // Tách ra phần chuỗi và số
                string StringPart = Regex.Match(MaxId, @"[A-Z]+").Value;
                int NumberPart = int.Parse(Regex.Match(MaxId, @"\d+").Value);

                // Tăng phần số lên 1 đơn vị
                NumberPart++;

                // Nối phần chuỗi và số lại
                NextId = StringPart + NumberPart.ToString("D3");
            }

            return NextId;
        }
    }
}
