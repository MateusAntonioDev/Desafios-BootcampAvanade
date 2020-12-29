using System;
    class Desafio
    {
        static void Main()
        {
            Console.WriteLine("Quantas pizzas tem disponíveis?");
            int availablePizzas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas saladas estão disponíveis?");
            int availableSalads = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas massas tem disponíveis?");
            int availablePastas = int.Parse(Console.ReadLine());

            Barrier();

            Console.WriteLine("Quantas pizzas foram solicitadas?");
            int requestedPizzas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas saladas foram solicitadas?");
            int requestedSalads = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas massas foram solicitadas?");
            int requestedPastas = int.Parse(Console.ReadLine());

            Barrier();

            int pizzasNotReceived = 0;
            int saladsNotReceived = 0;
            int pastasNotReceived = 0;

            if ( requestedPizzas > availablePizzas)
            {
                pizzasNotReceived = (requestedPizzas - availablePizzas);
            }
            
            if (requestedSalads > availableSalads)
            {
                saladsNotReceived = (requestedSalads - availableSalads);
            }
            
            if (requestedPastas > availablePastas)
            {
                pastasNotReceived = (requestedPastas - availablePastas);
            }

            int result = pizzasNotReceived + saladsNotReceived + pastasNotReceived;
            Console.WriteLine($"{result} clientes não vão ser atendidos por falta de estoque. Ficou em falta {pizzasNotReceived} pizzas, {saladsNotReceived} saladas e {pastasNotReceived} massas");
        }

        static void Barrier()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
        }
    }

