using System;

class Programa {
	static void Main(string[] args) {

		double salario;
		salario = 3000.10;
		Console.WriteLine(salario);

		double idade;
		idade = 7.0 / 5; 
		Console.WriteLine(idade);

		// idade = 7.0 / 5 resultará em 1.4, mas se não fosse adicionado o .0,
		// o double iria reconhecer o valor como inteiro, deixando apenas 1.

		Console.WriteLine("Tecle enter para fechar...");
		Console.ReadLine();
	}
}