using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da moto mais veloz: ");
            string fastMotorcycle = Console.ReadLine();
            Console.WriteLine("Digite o nome da moto mais lenta: ");
            string slowMotorcycle = Console.ReadLine();
            Barrier();

            Console.WriteLine($"Digite a distância em quilômetros entre a {fastMotorcycle} e a {slowMotorcycle} : ");
            float distance = float.Parse(Console.ReadLine());
            while (distance < 0) 
            {
                Console.WriteLine("Digite um valor positivo: ");
                distance = float.Parse(Console.ReadLine());
            }
            float time = distance * 2 ;
            Barrier();

            Console.WriteLine($"O tempo para a {fastMotorcycle} ficar a {distance}KM da {slowMotorcycle} é {time} minutos");

        }
        static void Barrier()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("");
        }
    }

