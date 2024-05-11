using PhanMemQuanLyThuVien_NamTuan.DAO;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class CTPhieuMuonTraBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null) query = "SELECT * FROM CTPhieuMuonTra";
            return SachDAO.GetData(query);
        }

        public static int InsertData()
        {
            return SachDAO.InsertData();
        }

        public static int UpdateData()
        {
            return SachDAO.UpdateData();
        }
    }
}
