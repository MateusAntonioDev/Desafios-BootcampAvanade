using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas divisões você deseja que sejam realizadas? ");
            int limit = int.Parse(Console.ReadLine());
            if (limit > 0) 
            {
                for (int count = 0; count < limit; count++)
                {
                    Console.Write("Digite o dividendo: ");
                    float number1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite o divisor: ");
                    float number2 = float.Parse(Console.ReadLine());

                    if (number2 != 0)
                    {
                        float result = Division(number1, number2);
                        Console.WriteLine($"A divisão entre {number1} e {number2} é igual a: {result.ToString("n1")}");
                        Barrier();
                    } else {
                        Console.WriteLine("Não é possível executar uma divisão, se o divisor for 0.");
                    }
                }
            } else {
                Console.WriteLine("O valor digitado deve ser positivo.");
            }
            

        }

        static float Division(float number1, float number2)
        {
            float divisionResult = number1 / number2;
            return divisionResult;
        }

        static void Barrier()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("");
        }
    }