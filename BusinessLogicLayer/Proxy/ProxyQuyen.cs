using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ProxyQuyen : CheckQuyen
    {

        public int KiemtraAdmin(int quyen)
        {
            if (quyen == 1)
            {
                RealQuyen real = new RealQuyen();
                return real.Messs();
            }
            return 2;
        }
    }
}
