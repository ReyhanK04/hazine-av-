using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basla2
{
    public class Oyuncu
    {
        private int oyuncuSatir;
        private int oyuncuSutun;
        private int eskiSatir;
        private int eskiSutun;
        private int gridSize;

        private List<Point> playerPath = new List<Point>();

        public Oyuncu( int gridSize)
        {
            oyuncuSatir = 0;
            oyuncuSutun = 0;
            eskiSatir = oyuncuSatir;
            eskiSutun = oyuncuSutun;
            this.gridSize = gridSize;
        }

        public void HareketEt(Keys tus, int boyut)
        {
            eskiSatir = oyuncuSatir;
            eskiSutun = oyuncuSutun;

            switch (tus)
            {
                case Keys.Up:
                    oyuncuSatir = Math.Max(oyuncuSatir - 1, 0);
                    break;
                case Keys.Down:
                    oyuncuSatir = Math.Min(oyuncuSatir + 1, boyut - 1);
                    break;
                case Keys.Left:
                    oyuncuSutun = Math.Max(oyuncuSutun - 1, 0);
                    break;
                case Keys.Right:
                    oyuncuSutun = Math.Min(oyuncuSutun + 1, boyut - 1);
                    break;
            }

            playerPath.Add(new Point(oyuncuSutun, oyuncuSatir));

           
        }

        public void Ciz(Graphics g, Image image)
        {
            int x = oyuncuSutun * gridSize;
            int y = oyuncuSatir * gridSize;

            g.DrawImage(image, x, y, gridSize, gridSize);

            //DrawPath(playerPath, g);
        }

        
    }
}
