using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basla2
{
    public class Lokasyon
    {
        public int Satir { get; set; }
        public int Sutun { get; set; }

        public Lokasyon(int satir, int sutun)
        {
            Satir = satir;
            Sutun = sutun;
        }
    }

   

}
