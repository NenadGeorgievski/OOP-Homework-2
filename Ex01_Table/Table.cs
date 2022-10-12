using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Table
{
    public class Table
    {
        public int Width;
        public int Height;

        public Table(int width, int height)        {
            Width = width;
            Height = height;
        }

        public void showData()
        {
            Console.WriteLine($"The width of the table is {Width}, and the height of the table is {Height}. " );
        }

    }
}
