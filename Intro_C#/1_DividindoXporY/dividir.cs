using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas divisões você deseja que sejam realizadas? ");
            sbyte limit = sbyte.Parse(Console.ReadLine());
            while (limit < 0)
            {
                Barrier();
                Console.WriteLine("Você deve digitar um valor positivo: ");
                limit = sbyte.Parse(Console.ReadLine());
            }
            Barrier();
            for (byte count = 0; count < limit; count++)
            {
                Console.Write("Digite o dividendo: ");
                float number1 = float.Parse(Console.ReadLine());
                Console.Write("Digite o divisor: ");
                float number2 = float.Parse(Console.ReadLine());

                while (number2 == 0) 
                {
                    Console.WriteLine("Não é possível executar uma divisão, se o divisor for 0.");
                    Console.Write("Digite um divisor válido: ");
                    number2 = float.Parse(Console.ReadLine());
                } 
                
                float result = Division(number1, number2);
                
                Console.WriteLine($"A divisão entre {number1} e {number2} é igual a: {result.ToString("n1")}");
                Barrier();

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