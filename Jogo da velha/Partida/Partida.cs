namespace Jogo_da_velha;

internal class Partida
{
    Tabuleiro tabuleiro = new Tabuleiro();
    Jogador jogador = new Jogador();

    public void inicio()
    {
        TipoJogador();
        
        
        tabuleiro.IsJogador(jogador);
        tabuleiro.isGerador();
    }
    private void TipoJogador()
    {
        Console.WriteLine("Qual Voce Escolhe Player1: [X/O]?");
        String Player1 = Console.ReadLine()!;
        jogador.TipoPlayer(Player1);
    }
    
}

