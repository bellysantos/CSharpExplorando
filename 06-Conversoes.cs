using System;

class Programa {
	static void Main(string[] args) {

	double salario = 3000.15;
	Console.WriteLine(salario);
	
	int salarioInteiro = (int)salario; // Casting (conversão): Transformou de double
	// para inteiro, sabendo que terá perda de informações
	Console.WriteLine(salarioInteiro);

	long x = 2000000000000; // Valores maiores de 64 bits
	Console.WriteLine(x);

	short y = 15000; // Guardar valores menores
	Console.WriteLine(y);

	float altura = 1.62f; // Pode ter uma impressão no tipo, por isso colocamos "f"
	// para dizer que realmente queremos trabalhar com tipo float
	Console.WriteLine(altura);

	// É importante saber como trabalhar com os tipos por conta de memória
  // e armazenamento de valores nas variáveis.

	Console.WriteLine("Tecle enter para fechar...");
	Console.ReadLine();
	}
}