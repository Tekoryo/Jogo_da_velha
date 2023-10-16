using System;
using System.Security.AccessControl;

namespace Jogo_da_velha.Partida;

internal class Tabuleiro
{
    private String[] Velha = new String[9];
    Jogador jogador = new Jogador();
    VerificacaoVitoria verificacao = new VerificacaoVitoria();

    
    private void IsVerificarVitoria()
    {
        verificacao.IsDados(Velha,jogador);
    }
    public void SetIsVerificarVitoria()
    {
        IsVerificarVitoria();
    }
    public void isGerenciador()
    {
        
            isTabuleiro();
            isMovimento();
            IsVerificarVitoria();
            Thread.Sleep(500);
            Console.Clear();
        
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
            if (Velha[i]==posicao)
            {
                if (Velha[i]!="x" || Velha[i]!="o")
                {
                    Velha[i] = jogador.IsJogador();
                    jogador.SetContadorMovimento();
                }
                else Console.WriteLine($"Desculpe, Tente em outra posição");
                
                Thread.Sleep(1000);
            }
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
    public void SetIsDadosInicio()
    {
        isDadosInicio();
    }
    public void IsJogador(Jogador Player)
    {
        jogador=Player;
    }
    public void IsVerificador(VerificacaoVitoria Verificador)
    {
        verificacao=Verificador;
    }
}
