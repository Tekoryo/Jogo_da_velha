
using System;

namespace Jogo_da_velha;

internal class Mapa
{
    private String[,] Velha = new String[3, 3];
    
    public void Criacao()
    {
        Velha[0, 0] = "1";
        Velha[0, 1] = "2";
        Velha[0, 2] = "3";

        Velha[1, 0] = "4";
        Velha[1, 1] = "5";
        Velha[1, 2] = "6";

        Velha[2, 0] = "7";
        Velha[2, 1] = "8";
        Velha[2, 2] = "9";

        do
        {
            isMapa();
            Jogada();
        } while (true);
        
    }    

    private void isMapa()
    {
       
            int pulaLinha = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (pulaLinha == 3)
                    {
                        Console.Write("\n");
                        pulaLinha = 0;
                    }
                    if (Velha[i, j] == Velha[i, 1])
                    {
                        Console.Write($" | {Velha[i, j]} | ");
                    }
                    else
                    {
                        Console.Write(Velha[i, j]);
                    }
                    pulaLinha++;
                }
            }
    }
    private void Jogada()
    {
        Console.WriteLine("\n Sua Jogada:");
        string posicao = Console.ReadLine();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(Velha[i, j]);
                if (Velha[i, j] == posicao) Velha[i, j] = "X";
            }
        }
        Console.Clear();
    }
}
