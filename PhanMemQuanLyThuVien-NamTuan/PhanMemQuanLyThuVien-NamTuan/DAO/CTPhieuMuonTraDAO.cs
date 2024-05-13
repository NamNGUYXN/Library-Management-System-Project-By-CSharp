using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.DAO
{
    public class CTPhieuMuonTraDAO
    {
        public static DataTable GetData(string query, List<ParameterCSDL> LstParams)
        {
            return DataProvider.GetData(query, LstParams);
        }

        public static int InsertData(string query, List<ParameterCSDL> LstParams)
        {
            return DataProvider.ExcuteSQL(query, LstParams);
        }
    }
}
