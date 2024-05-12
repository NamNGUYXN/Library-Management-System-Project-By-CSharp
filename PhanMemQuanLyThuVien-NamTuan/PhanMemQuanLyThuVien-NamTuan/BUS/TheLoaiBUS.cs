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

        public static string CreateNextId()
        {
            string NextId = "TL001";
            // Tìm mã cao nhất trong csdl
            string query = $"SELECT MAX(MaTL) FROM TheLoai";
            DataTable data = DataProvider.GetData(query);
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
