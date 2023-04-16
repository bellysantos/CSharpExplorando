using System;

class Programa {
	static void Main(string[] args) {
	
		// Calcular poupança
		double investimento = 1000;
		int mes = 1;

		/* Rendimento de 0.5% ao mês = 0.005
		investimento = investimento + (investimento * 0.005);
		Console.WriteLine(investimento); */

		while(mes <= 12)
			{
				investimento = investimento + (investimento * 0.005);
				Console.WriteLine("No mês " + mes + " rendeu: " + investimento);
				mes++;
			}

		Console.WriteLine("Tecle enter para fechar...");
		Console.ReadLine();
	}
}