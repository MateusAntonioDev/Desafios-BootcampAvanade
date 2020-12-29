using System;

class Desafio
{
    static void Main()
    {
        Console.WriteLine("Digite quantos minutos faltam para o final do expediente: ");
        int minutesLeft = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite quantos presentes faltam ser fabricados: ");
        int giftLeft = int.Parse(Console.ReadLine());

        int minutesGiftLeft = 0 ;

        for (int count = 1; count <= giftLeft; count++)
        {
            Console.WriteLine($"Digite quantos minutos são necessários para fabricar o {count}º presente: ");
            int gift = int.Parse(Console.ReadLine());
            minutesGiftLeft += gift ;
        }

        if (minutesLeft > 0 && minutesGiftLeft > 0)
        {

            if (minutesLeft >= minutesGiftLeft)
            {
                Console.Write("Farei hoje!");
            }
            else
            {
                Console.Write("Deixa para amanha!");
            }
        }
        else
        {
            Console.WriteLine("Os valores digitados devem ser maior do que 0");
        }
    }
}