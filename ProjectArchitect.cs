using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Rectangle: " + Rectangle(2500, 1500));
      Console.WriteLine("Circles: " + Circles(375));
      Console.WriteLine("Triangles: " + Triangles(750, 500));
      double totalArea = Rectangle(2500, 1500) + Circles(375) * 0.5 + Triangles(750, 500);
      Console.WriteLine("Result: " + res);
      double totalCost = totalArea * 180;
      Console.WriteLine($"The cost of total area is: {Math.Round(area, 2)} pesos");
    }

    static double Rectangle(double length, double width)
    {
      return length * width;
    }

    static double Circles(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    static double Triangles(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}
