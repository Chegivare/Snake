using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallist;

        public Walls(int mapWidth, int mapHeight)
        {
            wallist = new List<Figure>();
            HorizontalLine upline = new HorizontalLine(0, mapWidth - 3, 0, '+');
            HorizontalLine botline = new HorizontalLine(0, mapWidth - 3, mapHeight - 2 , '+');
            VerticalLine leftline = new VerticalLine(0, 0, mapHeight - 2, '+');
            VerticalLine rightline = new VerticalLine(mapWidth - 3, 0, mapHeight - 2, '+');

            wallist.Add(upline);
            wallist.Add(botline);
            wallist.Add(leftline);
            wallist.Add(rightline);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallist)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallist)
            {
                wall.Drow();
            }
        }
    }
}
