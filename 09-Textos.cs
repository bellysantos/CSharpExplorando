using System;

class Programa {
	static void Main(string[] args) {
		
		string primeiraFrase = "Alura - Cursos de Tecnologia ";
		Console.WriteLine(primeiraFrase + 2022);

		string vazia = "";
		Console.WriteLine(vazia);

		char letra = ' ';
		Console.WriteLine(letra); // Char vazia 

		string cursos = @"Cursos disponíveis:
- Go
- C#
- Java
- Python";
		Console.WriteLine(cursos);

		Console.WriteLine("\nTecle enter para fechar...");
		Console.ReadLine();
	}
}