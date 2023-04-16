using System;
  class Programa {
    static void Main(string[] args) {

    int idadeJoana = 16;
    int quantidadePessoas = 2;
    bool acompanhada = quantidadePessoas > 1;
    string textoAdicional;

    if(acompanhada == true) 
      {
        textoAdicional = "Joana está acompanhada.";
    } 
    else 
      {
        textoAdicional = "Joana não está acompanhada.";
    }

    if(idadeJoana >= 18 || acompanhada) {
        Console.WriteLine(textoAdicional + " Ela tem 18 anos ou mais. Pode entrar!");
      
    } else {
        Console.WriteLine(textoAdicional + " Não tem 18 anos ou mais. Não pode entrar");
    }

    Console.WriteLine("Tecle enter para fechar...");
    Console.ReadLine(); 

		// Tomar cuiado com a criação de variáveis e escopo, pois depende do contexto.
    }
  }