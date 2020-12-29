using System;
using System.Text.RegularExpressions;

    class Desafio
    {
        static void Main()
        {
            var correctPattern = new Regex("[A-Z]{3}-[0-9]{4}");
            Console.WriteLine("Digite a quantidade de placas que serão verificadas: ");
            int numberTests = int.Parse(Console.ReadLine());
            if (numberTests > 0)
            {
              for (int count = 1; count <= numberTests; count++)
              {
                  Console.WriteLine("Digite a placa: ");
                  string plate = Console.ReadLine();               
                  if(plate.Length == 8)
                  {
                      if (correctPattern.IsMatch(plate))
                      {
                          int lastNumber = int.Parse(plate.Substring(7));
                          switch (lastNumber)
                          {
                              case 1:
                              case 2:
                                  Console.WriteLine("SEGUNDA");
                                  break;
                              case 3:
                              case 4:
                                  Console.WriteLine("TERCA");
                                  break;
                              case 5:
                              case 6:
                                  Console.WriteLine("QUARTA");
                                  break;
                              case 7:
                              case 8:
                                  Console.WriteLine("QUINTA");
                                  break;
                              case 9:
                              case 0:
                                  Console.WriteLine("SEXTA");
                                  break;
                          }
                      } else {
                          Console.WriteLine("FALHA");
                      }
                  } else {
                      Console.WriteLine("FALHA");
                  }
              }
            } else {
              Console.WriteLine("O valor digitado deve ser maior do que 0.");
            }
        }
    }
