using System;

class Programa
{
    static void Main(String[] args)
    {
        for(int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 1; coluna < 6; coluna++)
            {
                Console.Write(coluna);
                if(coluna > linha)
                    break;
            }
            Console.WriteLine();
        }
    }
}