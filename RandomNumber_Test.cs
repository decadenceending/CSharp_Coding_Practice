using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomNumbersTest
{
  static double Rnd()
  {
    Random rand = new Random();
    double U = rand.NextDouble();
    return U;
  }
  static void Main()
  {
    double U=Rnd();
    Console.WriteLine(U);
  }
}
