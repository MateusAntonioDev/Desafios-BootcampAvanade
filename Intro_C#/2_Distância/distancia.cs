using System;
    class Desafio
    {
        static void Main()
        {
            Console.WriteLine("Digite o nome da moto mais veloz: ");
            string fastMotorcycle = Console.ReadLine();
            Console.WriteLine("Digite o nome da moto mais lenta: ");
            string slowMotorcycle = Console.ReadLine();
            Barrier();

            Console.WriteLine($"Digite a distância em quilômetros entre a {fastMotorcycle} e a {slowMotorcycle} : ");
            float distance = float.Parse(Console.ReadLine());
            if (distance > 0)
            {
                float time = distance * 2 ;
                Barrier();

                Console.WriteLine($"O tempo para a {fastMotorcycle} ficar a {distance}KM da {slowMotorcycle} é {time} minutos");
            } else {
                Console.WriteLine("O valor digitado deve ser maior que 0");
            }

            

        }
        static void Barrier()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("");
        }
    }

