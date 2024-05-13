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
    public class PhieuMuonTraBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM PhieuMuonTra";
            return PhieuMuonTraDAO.GetData(query, LstParams);
        }

        public static int InsertData(List<ParameterCSDL> LstParams)
        {
            string query = "INSERT INTO PhieuMuonTra (MaPhieu, MaTDG, MaTK, NgayTao, HanTra, NgayTra,";
            query += $" DaTra, GhiChu) VALUES (@MaPhieu, @MaTDG, @MaTK, @NgayTao, @HanTra, null, 0, @GhiChu)";
            return PhieuMuonTraDAO.InsertData(query, LstParams);
        }

        public static int UpdateData(string MaPhieu, string NgayTra)
        {
            string query = $"UPDATE PhieuMuonTra SET DaTra = 1, NgayTra = '{NgayTra}'";
            query += $" WHERE MaPhieu = '{MaPhieu}'";
            return PhieuMuonTraDAO.UpdateData(query, null);
        }

        public static DataTable SearchData(string key, string value)
        {
            string query = $"SELECT * FROM PhieuMuonTra WHERE {key} LIKE @{key}";
            ParameterCSDL param = new ParameterCSDL(key, $"%{value}%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return PhieuMuonTraDAO.GetData(query, LstParam);
        }

        public static int Extend(string MaPhieu, string HanTra)
        {
            string query = $"UPDATE PhieuMuonTra SET HanTra = '{HanTra}' WHERE MaPhieu = '{MaPhieu}'";
            return PhieuMuonTraDAO.UpdateData(query, null);
        }

        public static string CreateNextId()
        {
            string NextId = "P001";
            // Tìm mã cao nhất trong csdl
            string query = $"SELECT MAX(MaPhieu) FROM PhieuMuonTra";
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

        public static DateTime SauSoNgay(DateTime date, int days)
        {
            int day = date.Day, month = date.Month, year = date.Year;
            int cnt = 0;
            while (cnt != days)
            {
                cnt++;
                day++;

                if (day > NgayCuaThang(month, year))
                {
                    if (month < 12)
                    {
                        day = 1;
                        month++;
                    }
                    else
                    {
                        day = 1;
                        month = 1;
                        year++;
                    }
                }
            }

            DateTime datetime = new DateTime(year, month, day);
            return datetime;
        }

        public static DateTime TruocSoNgay(DateTime date, int days)
        {
            int day = date.Day, month = date.Month, year = date.Year;
            int cnt = 0;
            while (cnt != days)
            {
                cnt++;
                day--;

                if (day < 1)
                {
                    if (month > 1)
                    {
                        month--;
                        day = NgayCuaThang(month, year);
                    }
                    else
                    {
                        day = 31;
                        month = 12;
                        year--;
                    }
                }
            }

            DateTime datetime = new DateTime(year, month, day);
            return datetime;
        }

        static bool LaNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        }

        static int NgayCuaThang(int month, int year)
        {
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                {
                    return 31;
                }
                case 4: case 6: case 9: case 11:
                {
                    return 30;
                }
                case 2:
                {
                    if (LaNamNhuan(year)) return 29;
                    else return 28;
                }
                default: return 0;
            }
        }
    }
}
