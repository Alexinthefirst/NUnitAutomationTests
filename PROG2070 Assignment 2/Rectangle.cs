using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_Assignment_2
{
    public class Rectangle
    {

        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int nLength, int nWidth)
        {
            length = nLength;
            width = nWidth;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int nLength)
        {
            length = nLength;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int nWidth)
        {
            width = nWidth;
            return width;
        }

        public int GetPerimeter()
        {
            int perimeter = (length * 2) + (width * 2);
            return perimeter;
        }

        public int GetArea()
        {
            int area = length * width;
            return area;
        }
    }
}
