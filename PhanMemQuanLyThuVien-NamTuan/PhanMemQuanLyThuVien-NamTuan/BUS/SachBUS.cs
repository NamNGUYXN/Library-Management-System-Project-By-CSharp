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
    public class SachBUS
    {
        public static DataTable GetData(string query = null, List<ParameterCSDL> LstParams = null)
        {
            if (query == null)
            {
                query = "SELECT * FROM Sach s INNER JOIN TheLoai tl";
                query += " ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb";
                query += " ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg";
                query += " ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1";
            }
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

        public static DataTable SearchData(string key, string value)
        {
            string query = "SELECT * FROM Sach s INNER JOIN TheLoai tl";
            query += " ON s.MaTL = tl.MaTL INNER JOIN NhaXuatBan nxb";
            query += " ON s.MaNXB = nxb.MaNXB INNER JOIN TacGia tg";
            query += " ON s.MaTG = tg.MaTG WHERE s.TrangThai = 1";
            query += " AND " + key + " LIKE @" + key;
            ParameterCSDL param = new ParameterCSDL(key, "%" + value + "%");
            List<ParameterCSDL> LstParam = new List<ParameterCSDL>();
            LstParam.Add(param);
            return SachDAO.GetData(query, LstParam);
        }
    }
}
