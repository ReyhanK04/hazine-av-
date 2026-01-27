using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basla2
{
    public  class ari_Engel : hareketliEngeller
    {
        public override void hareketli_Paint(Graphics g, int gridSize, int engelSatir, int engelSutun, Image image, bool isVisible)
        {
            if (!isVisible)
            {
                int x = engelSatir * gridSize;
                int y = engelSutun * gridSize;

                g.DrawImage(image, x, y, 2 * gridSize, 2 * gridSize);
            }
        }

       

    }
}
