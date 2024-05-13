using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.DTO
{
    public class SachHong
    {
        public string MaSach { get; set; }
        public string MoTa { get; set; }

        public SachHong()
        {
            MaSach = "";
            MoTa = "";
        }

        public SachHong(string MaSach, string MoTa)
        {
            this.MaSach = MaSach;
            this.MoTa = MoTa;
        }
    }
}
