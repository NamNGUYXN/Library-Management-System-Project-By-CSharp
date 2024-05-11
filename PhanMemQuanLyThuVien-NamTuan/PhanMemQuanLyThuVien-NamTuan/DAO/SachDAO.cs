using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.DAO
{
    public class SachDAO
    {
        public static DataTable GetData(string query, List<ParameterCSDL> LstParam = null)
        {
            return DataProvider.GetData(query, LstParam);
        }

        public static int InsertData()
        {
            return 0;
        }

        public static int UpdateData()
        {
            return 0;
        }
    }
}
