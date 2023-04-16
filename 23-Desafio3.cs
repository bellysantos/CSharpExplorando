using System;

class Program
{
    static void Main(string[] args)
    {
        for (int n = 1; n <= 10; n++)
        {
            int fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine("O fatorial de " + n + " é " + fatorial);
        }
    }
}