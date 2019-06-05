using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ContextClass
    {
        private ITim itim;
        public ContextClass(ITim itim)
        {
            this.itim = itim;
        }
        public string TimKiemTheoTuKhoa(string tukhoa)
        {
            return itim.TimSinhVien(tukhoa);
        }
    }
}
