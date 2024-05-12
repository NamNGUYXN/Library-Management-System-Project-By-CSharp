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
    public class SachBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null)
            {
                query = "SELECT * FROM Sach s INNER JOIN TheLoai tl";
                query += " ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb";
                query += " ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg";
                query += " ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1";
            }
            return SachDAO.GetData(query);
        }

        public static int InsertData()
        {
            return SachDAO.InsertData();
        }

        public static int UpdateData()
        {
            return SachDAO.UpdateData();
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM Sach s INNER JOIN TheLoai tl";
            query += " ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb";
            query += " ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg";
            query += " ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1";
            query += " AND " + key + " LIKE @" + key;
            ParameterCSDL param = new ParameterCSDL(key, "%" + value + "%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return SachDAO.GetData(query, LstParam);
        }

        public static string CreateNextId()
        {
            string NextId = "S001";
            // Tìm mã cao nhất trong csdl
            string query = $"SELECT MAX(MaSach) FROM Sach";
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
