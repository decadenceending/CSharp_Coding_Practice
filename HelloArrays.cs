using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HelloArrays
{
  static void Main()
  {
    int[,] array2D = new int[4,2] {
       { 1, 2 },
       { 3, 4 },
       { 5, 6 },
       { 7, 8 } };
    System.Console.WriteLine(array2D);
  }
}
