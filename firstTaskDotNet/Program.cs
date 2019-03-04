using System;
using TestLib;

namespace firstTaskDotNet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter you name:");
      var name = Console.ReadLine();

      Console.WriteLine(Class1.GenerateOutString(name));
      Console.ReadKey();
    }
  }
}
