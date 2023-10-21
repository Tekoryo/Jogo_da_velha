using System.Numerics;

namespace Jogo_da_velha;

internal class Jogador
{
    private string? Jogador1;
    private string? Jogador2;
    private int NumeroMovimento=1;
 

    public void SetContadorMovimento()
    {
        NumeroMovimento++;
    }
    public int GetContadorMovimento()
    {
       return NumeroMovimento;
    }
    public string GetIsJogador(int ID)
    {
        if(ID == 1)return Jogador1;
        else return Jogador2;
       
    }
    public void TipoPlayer(string Player1)
    {
        string Player2;
       
        if (Player1 == "x") Player2 = "o";
        else Player2 = "x";

        Jogador1 = Player1.ToUpper();
        Jogador2 = Player2.ToUpper();
    }

    public string IsJogada()
    {
        Console.WriteLine("\n Sua Jogada:");
        string posicao = Console.ReadLine()!;
        return posicao;        
    }

    public string IsJogador() 
    {        
        if (NumeroMovimento % 2 == 0) return GetIsJogador(2);
        else return GetIsJogador(1);
    } 
    public string VezDoJogador(int Indentificador)
    {
        
        if (Indentificador == 1)
        {
            if (IsJogador()==GetIsJogador(2)) return $"Jogador 2 {GetIsJogador(2)}";
            else return $"Jogador 1 {GetIsJogador(1)}";
        }
        else
        {
            if (IsJogador()==GetIsJogador(2)) return $"Jogador 1";
            else return $"Jogador 2";

        }
       
    }
}
