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
    public class NhaXuatBanBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM NhaXuatBan WHERE TrangThai = 1";
            return NhaXuatBanDAO.GetData(query, LstParams);
        }

        public static int InsertData(List<ParameterCSDL> LstParams)
        {
            string query = "INSERT INTO NhaXuatBan (MaNXB, TenNXB, DiaChi, SDT, TrangThai)";
            query += " VALUES (@MaNXB, @TenNXB, @DiaChi, @SDT, 1)";
            return NhaXuatBanDAO.InsertData(query, LstParams);
        }

        public static int UpdateData(List<ParameterCSDL> LstParams)
        {
            string query = "UPDATE NhaXuatBan SET TenNXB = @TenNXB, DiaChi = @DiaChi, SDT = @SDT";
            query += " WHERE MaNXB = @MaNXB";
            return NhaXuatBanDAO.UpdateData(query, LstParams);
        }

        public static int DeleteData(string MaNXB)
        {
            string query = $"UPDATE NhaXuatBan SET TrangThai = 0 WHERE MaNXB = '{MaNXB}'";
            return NhaXuatBanDAO.DeleteData(query);
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM NhaXuatBan WHERE TrangThai = 1";
            query += " AND " + key + " LIKE @" + key;
            ParameterCSDL param = new ParameterCSDL(key, "%" + value + "%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return NhaXuatBanDAO.GetData(query, LstParam);
        }

        public static string CreateNextId()
        {
            string NextId = "NXB001";
            // Tìm mã cao nhất trong csdl
            string query = $"SELECT MAX(MaNXB) FROM NhaXuatBan";
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
