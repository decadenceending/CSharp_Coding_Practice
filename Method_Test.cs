using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RectangleArea
{
    static double GetRectangleArea(double width, double height)
    {
        double area = width * height;
        return area;
    }

    static void Main()
    {
        area=GetRectangleArea(5, 7);
        Console.WriteLine(area);
    }
}
