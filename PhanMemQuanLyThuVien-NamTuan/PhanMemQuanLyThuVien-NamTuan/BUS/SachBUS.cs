using PhanMemQuanLyThuVien_NamTuan.DAO;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections;
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
            return SachDAO.GetData(query, LstParams);
        }

        public static int InsertData(List<ParameterCSDL> LstParams)
        {
            string query = "INSERT INTO Sach (MaSach, TenSach, MaTL, MaTG, MaNXB, NamXuatBan, SoLuong,";
            query += " TrangThai) VALUES (@MaSach, @TenSach, @MaTL, @MaTG, @MaNXB, @NamXuatBan, @SoLuong, 1)";
            return SachDAO.InsertData(query, LstParams);
        }

        public static int UpdateData(List<ParameterCSDL> LstParams = null)
        {
            string query = "UPDATE Sach SET TenSach = @TenSach, MaTL = @MaTL, MaTG = @MaTG, MaNXB = @MaNXB,";
            query += " NamXuatBan = @NamXuatBan, SoLuong = @SoLuong WHERE MaSach = @MaSach";
            return SachDAO.UpdateData(query, LstParams);
        }

        public static int DeleteData(string MaSach)
        {
            string query = $"UPDATE Sach SET TrangThai = 0 WHERE MaSach = '{MaSach}'";
            return SachDAO.DeleteData(query);
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM Sach s INNER JOIN TheLoai tl ON s.MaTL = tl.MaTL";
            query += " INNER JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB";
            query += " INNER JOIN TacGia tg ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1";
            query += $" AND {key} LIKE @{key}";
            ParameterCSDL param = new ParameterCSDL(key, $"%{value}%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return SachDAO.GetData(query, LstParam);
        }

        public static int UpdateInStock(string MaSachTrongCSDL, int SoLuong)
        {
            // Lấy số lượng sách đó trong csdl
            string query = $"SELECT SoLuong FROM Sach WHERE MaSach = '{MaSachTrongCSDL}'";
            int SoLuongTrongCSDL = (int)GetData(query).Rows[0][0];
            SoLuongTrongCSDL += SoLuong;
            // Cập nhật số lượng sách đó lại
            query = $"UPDATE Sach SET SoLuong = {SoLuongTrongCSDL} WHERE MaSach = '{MaSachTrongCSDL}'";
            return SachDAO.UpdateInStock(query);
        }

        public static string CreateNextId()
        {
            string NextId = "S001";
            // Tìm mã cao nhất trong csdl
            string query = $"SELECT MAX(MaSach) FROM Sach";
            DataTable data = GetData(query);
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
