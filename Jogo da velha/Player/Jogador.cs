namespace Jogo_da_velha;

internal class Jogador
{
    public string Jogada()
    {
        Console.WriteLine("\n Sua Jogada:");
        string posicao = Console.ReadLine()!;
        return posicao;
        
    }

}
