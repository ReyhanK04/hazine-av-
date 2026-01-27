using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace basla2
{
    public class duvar_Engel : Engeller 
    {
        public override void Paint(Graphics g, int gridSize, List<Point> konumlar, Image image, bool isVisible)
        {

            if (!isVisible)
            {
                foreach (Point konum in konumlar)
                {
                    int x = konum.X * gridSize;
                    int y = konum.Y * gridSize;

                    g.DrawImage(image, x, y, 10 * gridSize, gridSize);
                }


            }

        }

    }
}
