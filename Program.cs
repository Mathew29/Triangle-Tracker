using System;

namespace TriangleTracker {

  public class Program
  {
    public static void Main ()
    {


      Console.WriteLine("Enter your first line's length");
      int sideOne = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter your second line's length");
      int sideTwo = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter your third line's length");
      int sideThree = int.Parse(Console.ReadLine());

      if ((sideOne + sideTwo) < sideThree || (sideOne + sideThree) < sideTwo || (sideTwo + sideThree) < sideOne)
      {
        Console.WriteLine("This is not a Triangle. WE WANT TRIANGLES!!!!");
      }
      else if (sideOne == sideTwo && sideTwo == sideThree)
      {
        Console.WriteLine("This is a Equilateral Triangle");
      }
      else if (sideOne == sideTwo || sideTwo == sideThree || sideOne == sideThree)
      {
        Console.WriteLine("This is a Isosceles");
      }
      else if (sideOne != sideTwo && sideTwo != sideThree)
      {
        Console.WriteLine("You got yourself a Scalene Triangle");
      }
      else
      {
        Console.WriteLine("Take your Square garbage out of here");
      }
    }
  }
}
