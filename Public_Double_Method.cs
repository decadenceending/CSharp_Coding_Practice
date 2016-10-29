using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
  class RectangleArea
  {
    public int GetRectangleArea(int width, int height)
    {
      int area = width * height;
      return area;
    }

    public int ModifyArea(int dist)
    {
      int area=GetRectangleArea(5,7);
      return area*dist;
    }

    static void Main()
    {
      int distance=new RectangleArea().ModifyArea(7);
      Console.WriteLine(distance);
    }
  }
}
