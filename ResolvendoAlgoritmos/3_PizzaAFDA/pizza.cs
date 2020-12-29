using System;

class Desafio
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de pessoas que irão a pizzaria: ");
        int numberPeople = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de datas consideradas: ");
        int numberDates = int.Parse(Console.ReadLine());
        if (numberPeople > 0 && numberDates > 0)
        {
            string datesConsidered = "";
            bool everybodyCan = true;

            for (int count = 1; count <= numberDates; count++)
            {
                Console.WriteLine($"Digite a {count}ª data no formato dd/mm/aaaa, e logo após deverá ser digitado para cada pessoa, 1 se ela pode ir nesta data, ou 0 se ela não pode ir. ");
                Console.WriteLine("Ex :  28/12/2020 0 1 1 0 1");
                string[] dateCan = Console.ReadLine().Trim().Split(' ');
                datesConsidered = dateCan[0];
                everybodyCan = true;
                for (int count2 = 1; count2 <= numberPeople; count2++)
                {
                    int peopleCan = int.Parse(dateCan[count2]);
                    if (peopleCan == 0)
                    {
                        everybodyCan = false;
                        break;
                    }
                }
                if (everybodyCan)
                {
                    Console.WriteLine($"A data mais próxima que todos podem ir é: {datesConsidered}");
                    break;
                }
            }
            if (!everybodyCan)
            {
                Console.WriteLine("Pizza antes do Final do Ano.");
            }
        } else {
            Console.WriteLine("Os valores digitados devem ser maior do que 0.");
        }
    }
}