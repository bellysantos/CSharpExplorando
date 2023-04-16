using System;

class Programa {
		static void Main(string[] args) {
		
			int idadeJoao = 16;
			int quantidadePessoas = 2;

			if(idadeJoao >= 18 || quantidadePessoas > 1) 
				{
					Console.WriteLine("Ele tem 18 anos ou mais ou está acompanhado. Pode entrar");
				}
			else 
				{
					Console.WriteLine("Não pode entrar");
				}

			int idadeAna = 19;
			int quantidadeGrupo = 2;
			bool acompanhada = quantidadeGrupo > 1;

			if(idadeAna >=18 && acompanhada)
				{
					Console.WriteLine("Ela tem 18 anos ou mais e está acompanhada. Pode entrar");
				}
			else
				{
					Console.WriteLine("Não pode entrar");
				}

			Console.WriteLine("Tecle enter para fechar...");
			Console.ReadLine();
	}
}