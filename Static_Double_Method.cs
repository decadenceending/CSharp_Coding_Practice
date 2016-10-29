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

    static double NextStep(double city1,double city2)
    {
      double area=GetRectangleArea(6,1);
      double step= city1*city2*area;
      return step;
    }
    static void Main()
    {
      double step=NextStep(2,3);
      Console.WriteLine(step);
    }
}
