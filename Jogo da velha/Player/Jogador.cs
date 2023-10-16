using System.Numerics;

namespace Jogo_da_velha;

internal class Jogador
{
    private string? Jogador1;
    private string? Jogador2;
    private int NumeroMovimento=1;
    private int JogadorAtual;

    public void SetContadorMovimento()
    {
        NumeroMovimento++;
    }
    public int GetContadorMovimento()
    {
       return NumeroMovimento;
    }
    public string GetIsJogador1()
    {
        JogadorAtual=1;
        return Jogador1;
    }
    public string GetIsJogador2()
    {
        JogadorAtual=2;
        return Jogador2;
    }
    public void TipoPlayer(string Player1)
    {
        string Player2;
       
        if (Player1 == "x") Player2 = "o";
        else Player2 = "x";

        Jogador1 = Player1.ToUpper();
        Jogador2 = Player2.ToUpper();
    }

    public string Jogada()
    {
        Console.WriteLine("\n Sua Jogada:");
        string posicao = Console.ReadLine()!;
        return posicao;
        
    }

    public string IsJogador() 
    {
        if (NumeroMovimento % 2 == 0) return GetIsJogador2();
        else return GetIsJogador1();
    }
    public string VezDoJogador(int x)
    {
        string Partida = " ";
        if (x == 1)
        {
            if(JogadorAtual==2) Partida = GetIsJogador1().ToUpper();
            else Partida = GetIsJogador2().ToUpper();
        }

        if (JogadorAtual==2) return $"Jogador 2 {Partida}";
        else return $"Jogador 1 {Partida}";
    }
}
