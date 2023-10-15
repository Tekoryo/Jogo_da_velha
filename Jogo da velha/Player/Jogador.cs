namespace Jogo_da_velha;

internal class Jogador
{
    private string Joagador1;
    private string Joagador2;
    private int NumeroMovimento=0;

    public void ContadorMovimento()
    {
        NumeroMovimento++;
        
    }
    public void printN()
    {
        Console.WriteLine(NumeroMovimento);
    }
    public void TipoPlayer(String Player1)
    {
        string Player2;
       
        if (Player1 == "X" || Player1 == "x") Player2 = "O";
        else Player2 = "X";

        Joagador1 = Player1;
        Joagador2 = Player2;
    }

    public string Jogada()
    {
        Console.WriteLine("\n Sua Jogada:");
        string posicao = Console.ReadLine()!;
        return posicao;
        
    }

    public string IsJogador() 
    {
        if (NumeroMovimento % 2 == 0) return Joagador1;
        else return Joagador2;
    }
}
