using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyThuVien_NamTuan.DTO
{
    public class ParameterCSDL
    {
        public string KeyCSDL { get; set; }
        public string ValueCSDL { get; set; }

        public ParameterCSDL()
        {
            KeyCSDL = "";
            ValueCSDL = "";
        }

        public ParameterCSDL(string KeyCSDL, string ValueCSDL)
        {
            this.KeyCSDL = KeyCSDL;
            this.ValueCSDL = ValueCSDL;
        }
    }
}
