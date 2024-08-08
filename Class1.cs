using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Rectangle
    {
        public int x;
        public int y;
        public Rectangle(int x, int y=0)
        {
            this.x = x;
            this.y = y;
        }
        public  int  CalArea(int x,int y)
        {
            return x * y;
        }
        public int CalPerimeter(int x, int y)
        {
            return 2*(x + y);
        }

    }
 
}
