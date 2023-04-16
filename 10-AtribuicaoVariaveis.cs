using System;

class Programa {
	static void Main(string[] args) {

		int idade = 30;
		int idadeAna = idade;
		Console.WriteLine(idadeAna);

		idade = 25;
		Console.WriteLine(idade);

		// O computador não volta atrás para entender a lógica de troca de variáveis

		Console.WriteLine("Tecle enter para fechar...");
		Console.ReadLine();
	}
}