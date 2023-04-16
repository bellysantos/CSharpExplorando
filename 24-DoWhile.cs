/* do
	{
	  //bloco de código
	} while (condição); */

using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        
        do
            {
                numero++;
                Console.WriteLine(numero);
            } while (numero < 10);
    }
}