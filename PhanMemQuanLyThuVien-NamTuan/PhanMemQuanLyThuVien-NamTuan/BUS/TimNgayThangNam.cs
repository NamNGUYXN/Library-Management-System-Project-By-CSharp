using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class TimNgayThangNam
    {
        private int ngay;
        private int thang;
        private int nam;

        public TimNgayThangNam()
        {
            ngay = 0;
            thang = 0;
            nam = 0;
        }

        public TimNgayThangNam(int ngay, int thang, int nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }


        public TimNgayThangNam (DateTime NTN)
        {
            this.ngay = NTN.Day;
            this.thang = NTN.Month;
            this.nam = NTN.Year;
        }

        bool LaNamNhuan(int nam)
        {
            return (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0);
        }

        int NgayCuaThang(int thang, int nam)
        {
            switch(thang)
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
                    if (LaNamNhuan(nam)) return 29;
                    else return 28;
                }
                default: return 0;
            }
        }

        public DateTime SauSoNgay(int SoNgay)
        {
            int cnt = 0;
            int ngay, thang, nam;
            ngay = this.ngay;
            thang = this.thang;
            nam = this.nam;

            while (cnt != SoNgay)
            {
                cnt++;
                ngay++;
                
                if (ngay > NgayCuaThang(thang, nam))
                {
                    if (thang < 12)
                    {
                        ngay = 1;
                        thang++;
                    }
                    else
                    {
                        ngay = 1;
                        thang = 1;
                        nam++;
                    }
                }
            }

            DateTime datetime = new DateTime(nam, thang, ngay);
            return datetime;
        }

        public DateTime TruocSoNgay(int SoNgay)
        {
            int cnt = 0;
            int ngay, thang, nam;
            ngay = this.ngay;
            thang = this.thang;
            nam = this.nam;

            while (cnt != SoNgay)
            {
                cnt++;
                ngay--;

                if (ngay < 1)
                {
                    if (thang > 1)
                    {
                        thang--;
                        ngay = NgayCuaThang(thang, nam);
                    }
                    else
                    {
                        ngay = 31;
                        thang = 12;
                        nam--;
                    }
                }
            }

            DateTime datetime = new DateTime(nam, thang, ngay);
            return datetime;
        }
    }
}
