using System;

namespace String_manipulation
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] highScores = { "LENA 100000", "MICKE 23004", "MARTIN 2000" };

      //   string[] names = highScores.Split(' ');
      string space = string.Join("\n", highScores);
      Console.WriteLine(space);
    }
  }
}
