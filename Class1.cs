using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Rectangle
    {
        public int x;
        public int y;
        Rectangle(int x, int y=0)
        {
            this.x = x;
            this.y = y;
        }
        static int  CalArea(int x,int y)
        {
            return x * y;
        }
        static int CalRectangle(int x, int y)
        {
            return x + y;
        }
    }
    internal class Class1
    {
    }
}
