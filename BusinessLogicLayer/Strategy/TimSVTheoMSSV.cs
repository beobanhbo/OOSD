using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class TimSVTheoMSSV : ITim
    {
        public string TimSinhVien(string tukhoa)
        {
            string a = "IDSV = " + tukhoa;
            return a;
        }
    }
}
