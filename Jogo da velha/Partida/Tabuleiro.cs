using System;

namespace Jogo_da_velha;

internal class Tabuleiro
{
    private String[] Velha = new String[9];
    Jogador jogador = new Jogador();
    
    public void IsJogador(Jogador x)
    {
        jogador=x;
    }
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
                        
            Console.Write($"     {Velha[0]}     |     {Velha[1]}    |     {Velha[2]}    \n");
            Console.Write($" __________|__________|__________ \n");
            Console.Write($"     {Velha[3]}     |     {Velha[4]}    |     {Velha[5]}    \n");
            Console.Write($" __________|__________|__________ \n");
            Console.Write($"     {Velha[6]}     |     {Velha[7]}    |     {Velha[8]}    \n");
            Console.Write($"           |          |           \n");

    }
    private void isMovimento()
    {
        string posicao = jogador.Jogada();
        for (int i = 0; i < Velha.GetLength(0); i++)
        {
            if (Velha[i]==posicao) Velha[i] = jogador.IsJogador();
        }
    }

    private void isDadosInicio()
    {
        for (int i = 0;i < Velha.GetLength(0);i++)
        {
            int numero = i + 1;
            Velha[i] = numero.ToString();
        }
    }
}
