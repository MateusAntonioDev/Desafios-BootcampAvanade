using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas mandiocas Chico vai comer? ");
            int chico = 300 * Int32.Parse(Console.ReadLine());
            Console.Write("Quantas mandiocas Bento vai comer? ");
            int bento = 1500 * Int32.Parse(Console.ReadLine());
            Console.Write("Quantas mandiocas Bernardo vai comer? ");
            int bernardo = 600 * Int32.Parse(Console.ReadLine());
            Console.Write("Quantas mandiocas Marina vai comer? ");
            int marina = 1000 * Int32.Parse(Console.ReadLine());
            Console.Write("Quantas mandiocas Iara vai comer? ");
            int iara = 150 * Int32.Parse(Console.ReadLine());
            int marlene = 225;

            int total = chico + bento + bernardo + marina + iara + marlene;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"Marlene deve preparar {total} gramas de mandioca");
        }
    }
}
