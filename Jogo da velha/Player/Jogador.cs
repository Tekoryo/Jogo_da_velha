
namespace Jogo_da_velha;

internal class Jogador
{
    private string? jogador1 { get; set; }
    private string? jogador2 { get; set; }

   public void SetJogador(string EscolhaJogador)
    {
        jogador1 = EscolhaJogador.ToUpper();

        if (jogador1 == "X") jogador2 = "O";
        else jogador2 = "X";
        
    }
    public void GetJogador()
    {
        Console.WriteLine($"jogador 1: {jogador1}");
        Console.WriteLine($"jogador 2: {jogador2}");

    }
}
