using System;

class Programa
{
    static void Main(string[] args)
    {
      double salario = 3300.00;

      if(salario >= 1900.00 && salario <= 2800.00)
      {
        Console.WriteLine("O IR é de 7.5%");
        Console.WriteLine("Pode deduzir na declaração o valor de R$ 142");
      }
  
      else if(salario >= 2800.01 && salario <= 3751.00)
      {
        Console.WriteLine("O IR é de 15%");
        Console.WriteLine("Pode deduzir R$ 350");
      }
  
      else if(salario >= 3751.01 && salario <= 4664.00)
      {
        Console.WriteLine("O IR é 22.5%");
        Console.WriteLine("Pode deduzir R$ 636");
      }
    }
}