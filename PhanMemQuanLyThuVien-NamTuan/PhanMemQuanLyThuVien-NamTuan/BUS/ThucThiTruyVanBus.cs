using PhanMemQuanLyThuVien_NamTuan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class ThucThiTruyVanBus
    {
        public static DataTable LayDuLieu(string query)
        {
            return DataProvider.LayDuLieu(query);
        }

        public static int ThaoTacDuLieu(string query)
        {  
            return DataProvider.ThaoTacDuLieu(query);
        }
    }
}
