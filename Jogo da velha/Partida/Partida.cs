namespace Jogo_da_velha;

internal class Partida
{
    Tabuleiro tabuleiro = new Tabuleiro();
    Jogador jogador = new Jogador();

    public void inicio()
    {
        tabuleiro.isGerador();
    }
}

