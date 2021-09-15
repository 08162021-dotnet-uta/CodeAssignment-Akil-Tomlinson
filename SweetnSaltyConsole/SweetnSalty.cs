using System;

namespace SweetnSaltyConsole
{
  class SweetnSalty
  {

    public void SweetnSaltyCounter()
    {

      int Sweet = 0; //counter for Sweet numbers
      int Salty = 0; //counter for Salty numbers
      int SweetnSalty = 0; //counter for SweetnSalty numbers

      for (int i = 1; i <= 1000; i++)
      {
        if (i % 10 == 0)
        {
          Console.WriteLine(" ");
        }

        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.Write("SweetnSalty ");
          SweetnSalty++;
        }
        else if (i % 3 == 0)
        {
          Console.Write("Sweet ");
          Sweet++;
        }
        else if (i % 5 == 0)
        {
          Console.Write("Salty ");
          Salty++;
        }
        else
        {
          Console.Write(i + " ");
        }

      }
      Console.WriteLine(" ");
      Console.WriteLine($"There are {Sweet} Sweet numbers");
      Console.WriteLine($"There are {Salty} Salty numbers");
      Console.WriteLine($"There are {SweetnSalty} SweetnSalty numbers");

    }

  }
}
