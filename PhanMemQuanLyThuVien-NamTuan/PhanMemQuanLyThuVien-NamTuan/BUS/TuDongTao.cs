using PhanMemQuanLyThuVien_NamTuan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class TuDongTao
    {
        public static string MaKeTiep(string TypeId, string table, string FirstChar)
        {
            string NextId = FirstChar + "001";
            // Tìm mã cao nhất trong csdl
            string query = "SELECT MAX(" + TypeId + ") FROM " + table;
            DataTable data = DataProvider.GetData(query, null);
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
