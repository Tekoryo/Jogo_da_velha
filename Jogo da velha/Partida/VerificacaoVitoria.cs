
namespace Jogo_da_velha.Partida;

internal class VerificacaoVitoria
{
    private int jogadas = 0;
    public bool FinalizandoPartida()
    {
        if (jogadas < 8) return false;
        else return true;
    }
    //Desenvolver o sistema de vitoria e de impate!
}