using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numberOddNumbers = 10; 
        int counterDrawings = 0; 

        Console.Write("Version 1: ");
        for (int i = 0; i < numberOddNumbers; i++)
        {
            int drawnNumber;
            do
            {
                drawnNumber = random.Next(-8, 9);
                counterDrawings++;
            } while (drawnNumber % 2 != 0);

            Console.Write(drawnNumber);

            if (i < numberOddNumbers - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Number of draws made: " + counterDrawings);
    }
}
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numberOddNumbers = 10; 
        int counterDrawings = 0; 

        Console.Write("Version 2: ");
        for (int i = 0; i < numberOddNumbers; i++)
        {
            int drawnNumber = random.Next(-4, 5) * 2;
            counterDrawings++;

            Console.Write(drawnNumber);

            if (i < numberOddNumbers - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Number of draws made: " + counterDrawings);
    }
}
