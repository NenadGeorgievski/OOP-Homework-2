using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Table
{
    public class CoffeeTable : Table
    {
        public int coffeeTableHeight;
        public int coffeeTableWidth;
        public CoffeeTable(int width, int height) : base(width, height)
        {
            coffeeTableHeight = height; 
            coffeeTableWidth = width;
        }

        public void showData()
        {
            Console.WriteLine($"Coffee table: width is {Width}, and the height is {Height}");
        }
    }
}
