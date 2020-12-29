using System;

class Desafio {
    static void Main() {
      Console.WriteLine("Digite a quantidade de segundos: ");
      int seconds = int.Parse(Console.ReadLine());
      if (seconds > 0) 
      {
        int hours = 0;
        int minutes = 0;
      
        if (seconds >= 3600)
        {
          hours = seconds / 3600;
          seconds = seconds - (hours * 3600);
        }
        
        if (seconds >= 60)
        {
          minutes = seconds / 60;
          seconds = seconds - (minutes * 60);
        }
        
        Console.WriteLine($"{hours}:{minutes}:{seconds}");
      } else {
        Console.WriteLine("O valor digitado deve ser maior do que 0.")
      } 
    }
}