using PhanMemQuanLyThuVien_NamTuan.DAO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan.BUS
{
    public class DoDuLieu
    {
        public static void DoDuLieucbo(string column, string table, ComboBox cbo)
        {
            DataProvider.DoDuLieu(column, table, cbo);
        }
    }
}
