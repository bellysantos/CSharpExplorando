using System;

class Programa {
	static void Main(string[] args) {
	
        Console.WriteLine("Sem break");
		for(int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
		{
		    for(int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
		    {
		        Console.Write("*");
		    }
		    
		    Console.WriteLine();
		}
		
		Console.WriteLine("\nCom break");
		for(int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
		{
		    for(int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
		    {
		        Console.Write("*");
		        if(contadorColunas > contadorLinhas)
		            break;
		    }
		    
		    Console.WriteLine();
		}
		
		Console.WriteLine("Tecle enter para fechar...");
		Console.ReadLine();
	}
}