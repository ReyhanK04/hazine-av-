using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basla2
{
    public abstract class Engeller
    {
        public abstract void Paint(Graphics g, int gridSize, List<Point> konumlar, Image image, bool isVisible);

       

    }
}
