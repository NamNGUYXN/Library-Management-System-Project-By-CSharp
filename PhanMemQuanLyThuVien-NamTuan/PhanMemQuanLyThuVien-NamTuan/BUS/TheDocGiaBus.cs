using PhanMemQuanLyThuVien_NamTuan.DAO;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class TheDocGiaBus
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
            return TheDocGiaDAO.GetData(query, LstParams);
        }

        public static int InsertData(List<ParameterCSDL> LstParams)
        {
            string query = "INSERT INTO TheDocGia (MaTDG, HoTenDG, GioiTinh, DiaChi, SDT, CCCD,";
            query += " NgayTao, NgayHetHan, TrangThai) VALUES (@MaTDG, @HoTenDG, @GioiTinh, @DiaChi,";
            query += " @SDT, @CCCD, @NgayTao, @NgayHetHan, 1)";
            return TheDocGiaDAO.InsertData(query, LstParams);
        }

        public static int UpdateData(List<ParameterCSDL> LstParams)
        {
            string query = "UPDATE TheDocGia SET HoTenDG = @HoTenDG, GioiTinh = @GioiTinh, DiaChi = @DiaChi,";
            query += " SDT = @SDT, CCCD = @CCCD, NgayTao = @NgayTao, NgayHetHan = @NgayHetHan";
            query += " WHERE MaTDG = @MaTDG";
            return TheDocGiaDAO.UpdateData(query, LstParams);
        }

        public static int DeleteData(string MaTDG)
        {
            string query = $"UPDATE TheDocGia SET TrangThai = 0 WHERE MaTDG = '{MaTDG}'";
            return TheDocGiaDAO.DeleteData(query);
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM TheDocGia WHERE TrangThai = 1";
            query += " AND " + key + " LIKE @" + key;
            ParameterCSDL param = new ParameterCSDL(key, "%" + value + "%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return TheDocGiaDAO.GetData(query, LstParam);
        }
    }
}
