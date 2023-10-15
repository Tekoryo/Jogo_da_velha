using System;

namespace Jogo_da_velha;

internal class Tabuleiro
{
    private String[] Velha = new String[9];
    Jogador jogador = new Jogador();

    public void isGerador()
    {
        isDadosInicio();
        do
        {
            isTabuleiro();
            isMovimento();
            Console.Clear();
        } while (true);
    }    
    
    private void isTabuleiro()
    {
                        
            Console.Write($"     {0}     |     {1}    |     {2}    \n", Velha[0], Velha[1], Velha[2]);
            Console.Write($" __________|__________|__________ \n");
            Console.Write($"     {3}     |     {4}    |     {5}    \n", Velha[3], Velha[4], Velha[5]);
            Console.Write($" __________|__________|__________ \n");
            Console.Write($"     {6}     |     {7}    |     {8}    \n", Velha[6], Velha[7], Velha[8]);
            Console.Write($"           |          |           \n");

    }
    private void isMovimento()
    {
        string posicao = jogador.Jogada();
        for (int i = 0; i < Velha.GetLength(0); i++)
        {
            if (Velha[i]==posicao) Velha[i] = "x";
        }
    }

    private void isDadosInicio()
    {
        Velha[0] = "1";
        Velha[1] = "2";
        Velha[2] = "3";

        Velha[3] = "4";
        Velha[4] = "5";
        Velha[5] = "6";

        Velha[6] = "7";
        Velha[7] = "8";
        Velha[8] = "9";
    }
}
