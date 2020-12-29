using System;
class Desafio
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de dias: ")
        int day = int.Parse(Console.ReadLine());
        if (day > 0)
        {
            int year = 0;
            int month = 0;

            if (day >= 365)
            {
                year = day / 365;
                day = day - (year * 365);
            }

            if (day >= 30)
            {
                month = day / 30;
                day = day - (month * 30);
            }

            Console.WriteLine($"{year} ano(s)\n{month} mes(es)\n{day} dia(s)");
        }
        else
        {
            Console.WriteLine("O valor digitado deve ser maior do que 0");
        }
    }
}