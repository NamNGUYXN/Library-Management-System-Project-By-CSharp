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
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class TaiKhoanBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1";
            return TaiKhoanDAO.GetData(query, LstParams);
        }

        public static int InsertData(List<ParameterCSDL> LstParams)
        {
            string query = "INSERT INTO TaiKhoan (MaTK, HoTen, NgaySinh, GioiTinh, SDT, MatKhau, Quyen, TrangThai)";
            query += " VALUES (@MaTK, @HoTen, @NgaySinh, @GioiTinh, @SDT, @MatKhau, 0, 1)";
            return TaiKhoanDAO.InsertData(query, LstParams);
        }

        public static int UpdateData(List<ParameterCSDL> LstParams)
        {
            string query = "UPDATE TaiKhoan SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh,";
            query += " SDT = @SDT, MatKhau = @MatKhau WHERE MaTK = @MaTK";
            return TaiKhoanDAO.UpdateData(query, LstParams);
        }

        public static int DeleteData(string MaTK)
        {
            string query = $"UPDATE TaiKhoan SET TrangThai = 0 WHERE MaTK = '{MaTK}'";
            return TaiKhoanDAO.DeleteData(query);
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TrangThai = 1";
            query += " AND " + key + " LIKE @" + key;
            ParameterCSDL param = new ParameterCSDL(key, "%" + value + "%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return TaiKhoanDAO.GetData(query, LstParam);
        }

        public static string CreateNextId()
        {
            string NextId = "TK001";
            // Tìm mã cao nhất trong csdl
            string query = $"SELECT MAX(MaTK) FROM TaiKhoan";
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
