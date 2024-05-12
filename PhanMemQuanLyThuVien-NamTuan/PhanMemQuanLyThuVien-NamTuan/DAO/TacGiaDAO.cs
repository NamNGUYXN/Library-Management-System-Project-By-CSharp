using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.DAO
{
    public class TacGiaDAO
    {
        public static DataTable GetData(string query, List<ParameterCSDL> LstParams)
        {
            return DataProvider.GetData(query, LstParams);
        }

        public static int InsertData(string query, List<ParameterCSDL> LstParams)
        {
            return DataProvider.ExcuteSQL(query, LstParams);
        }

        public static int UpdateData(string query, List<ParameterCSDL> LstParams)
        {
            return DataProvider.ExcuteSQL(query, LstParams);
        }

        public static int DeleteData(string query)
        {
            return DataProvider.ExcuteSQL(query);
        }
    }
}
