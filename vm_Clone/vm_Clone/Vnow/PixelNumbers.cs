using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VmosoBKW
{
  //4*5 2 dimension array for each number
  public class PixelNumbers
  {
    public static int[,] pixelOne = new int[,] {{3,0},{2,1},{3,1},{1,2},{3,2},{3,3},{3,4}};

    public static int[,] pixelTwo = new int[,] { { 1, 0 }, { 2, 0 }, { 0, 1 }, { 3, 1 }, { 2, 2 }, { 1, 3 }, { 0, 4 }, { 1, 4 }, { 2, 4 }, { 3, 4 } };

    public static int[,] pixelThree = new int[,] { { 1, 0 }, { 2, 0 }, { 0, 1 }, { 3, 1 }, { 2, 2 }, { 0, 3 }, { 3, 3 }, { 1, 4 }, { 2, 4 } };

    public static int[,] pixelFour = new int[,] { { 2, 0 }, { 3, 0 }, { 1, 1 }, { 3, 1 }, { 0, 2 }, { 1, 2 }, { 2, 2 }, { 3, 2 }, { 3, 3 }, { 3, 4 } };

    public static int[,] pixelFive = new int[,] { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 0, 1 }, { 1, 1 }, { 2, 1 }, { 3, 2 }, { 0, 3 }, { 3, 3 }, { 1, 4 }, { 2, 4 } };

    public static int[,] pixelSix = new int[,] { { 2, 0 }, { 1, 1 }, { 0, 2 }, { 1, 2 }, { 2, 2 }, { 0, 3 }, { 3, 3 }, { 1, 4 }, { 2, 4 } };

    public static int[,] pixelSeven = new int[,] { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 3, 1 }, { 2, 2 }, { 1, 3 }, { 0, 4 } };

    public static int[,] pixelEight = new int[,] { { 1, 0 }, { 2, 0 }, { 0, 1 }, { 3, 1 }, { 1, 2 }, { 2, 2 }, { 0, 3 }, { 3, 3 }, { 1, 4 }, { 2, 4 } };

    public static int[,] pixelNine = new int[,] { { 1, 0 }, { 2, 0 }, { 0, 1 }, { 3, 1 }, { 1, 2 }, { 2, 2 }, { 3, 2 }, { 2, 3 }, { 1, 4 } };

    public static int[,] pixelZero = new int[,] { { 1, 0 }, { 2, 0 }, { 0, 1 }, { 3, 1 }, { 0, 2 }, { 3, 2 }, { 0, 3 }, { 3, 3 }, { 1, 4 }, { 2, 4 } };

    public static int[,] pixelPlus = new int[,] { { 1, 0 }, { 0, 1 }, { 1, 1 }, { 2, 1 }, { 1, 2 } };
  }
}
