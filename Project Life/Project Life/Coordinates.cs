using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Project_Life
{
    [Serializable]
    // Класс координат проверки окрестностей выбранной клетки
    public class Coordinates
    {
        public int x;
        public int y;
        public int startx;
        public int starty;
        public int endx;
        public int endy;

        public void getCoordinates(Creature c)
        {
            x = c.x;
            y = c.y;
            startx = x - 1;
            starty = y - 1;
            endx = x + 1;
            endy = y + 1;
            if (x == 0)
                startx++;
            if (y == 0)
                starty++;
            if (x == 49)
                endx--;
            if (y == 32)
                endy--;
        }
    }
}
