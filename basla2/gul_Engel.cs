using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basla2
{
    public class gul_Engel : Engeller
    {
        public override void Paint(Graphics g, int gridSize, List<Point> konumlar, Image image, bool isVisible)
        {
            if (!isVisible)
            {
                foreach (Point konum in konumlar)
                {
                    int x = konum.X * gridSize;
                    int y = konum.Y * gridSize;

                    g.DrawImage(image, x, y, 3 * gridSize, 3 * gridSize);
                }

            }

        }

    }
}
