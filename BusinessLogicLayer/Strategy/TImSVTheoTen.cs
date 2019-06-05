using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class TImSVTheoTen : ITim
    {
        public string TimSinhVien(string tukhoa)
        {
            string a = "TenSV LIKE '% " + tukhoa + "%'";
            return a;
        }
    }
}
