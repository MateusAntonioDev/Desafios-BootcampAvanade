using System;
    class Desafio
    {
        static void Main()
        {
            Console.WriteLine("Quantas voltas?");
            int numberLaps = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas placas?");
            int numberPlates = int.Parse(Console.ReadLine());

            int total = numberLaps * numberPlates;

            if (numberLaps > 0 && numberPlates > 0)
            {
                for (int count = 10; count < 100; count += 10)
                {
                    double result = (double)total / 100 * count;
                    Console.WriteLine($"{count}% = {Math.Ceiling(result)} ");
                }
            } else {
              Console.WriteLine("Os valores digitados devem ser maior do que 0.");
            }        
        }
    }

