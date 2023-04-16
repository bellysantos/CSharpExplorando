using System;

class Programa {
	static void Main(string[] args) {

	char letra = 'a'; // Deve-se tomar cuidado com a diferença entre aspas "" e ''
	Console.WriteLine(letra);

	// O computador entende que o char é um número e não um caractere de um fato.
	// Basta verificar na tabela ASCII então...

	letra = (char)65; // A vale 65 na tabela ASCII
	Console.WriteLine(letra);

	letra = (char)(65 + 1); // B vale 66 na tabela ASCII
	Console.WriteLine(letra);

	Console.WriteLine("Tecle enter para fechar...");
	Console.ReadLine();
	}
}