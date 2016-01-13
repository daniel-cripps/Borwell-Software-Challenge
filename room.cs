using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace room
{
  class MainClass
  {
    static int CalculateArea(int width, int length)
    {
      return width * length;
    }

    static int CalculateWallArea(int width, int length, int height)
    {
      return 2 * CalculateArea(length, height) + 2 * CalculateArea(width, height);
    }

    static int CalculateVolume(int width, int length, int height)
    {
      return width * length * height;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Enter Room Width:");
      int roomWidth = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter Room Length:");
      int roomLength = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter Room Height:");
      int roomHeight = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Room Floor Area is " + CalculateArea(roomWidth,roomLength) + "m^2");
      Console.WriteLine("Amount of Paint is " + CalculatePaintAmount(roomWidth, roomLength, roomHeight) + "m^2 worth");
      Console.WriteLine("Volume of Room is " + CalculateVolume(roomWidth, roomLength, roomHeight) + "m^3 worth");
      Console.Write("Press any key to continue");
      Console.ReadKey();
    }
  }
}
