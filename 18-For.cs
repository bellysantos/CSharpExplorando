using System;

class Programa {
	static void Main(string[] args) {
	
		// Calcular poupança
		
		/* Rendimento de 0.5% ao mês = 0.005
		investimento = investimento + (investimento * 0.005);
		Console.WriteLine(investimento); 

		while(mes <= 12)
			{
				investimento = investimento + (investimento * 0.005);
				Console.WriteLine("No mês " + mes + " rendeu: " + investimento);
				mes++;
			}
		*/
		
		double investimento = 1000;
		for(int mes = 1; mes <= 12; mes++)
		{
		    investimento *= 1.005;
			Console.WriteLine("No mês " + mes + " rendeu: " + investimento);
		}

		Console.WriteLine("Tecle enter para fechar...");
		Console.ReadLine();
	}
}