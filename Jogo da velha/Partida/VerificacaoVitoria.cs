
namespace Jogo_da_velha.Partida;

internal class VerificacaoVitoria
{
    private string[] VerificadorPosicao = new string[9];
    private int jogadas = 0;
    public bool FinalizandoPartida(int NumeroJogadas)
    {
        jogadas=NumeroJogadas;
        if (jogadas ==10)
        {
            jogadas = 0;

            return false;
        }
        else
        {
            return true;
        }
    }
    public int CheckResultado()
    {

        // Vitoria

        for (int i = 0; i <VerificadorPosicao.GetLength(0); i+=3) if (VerificadorPosicao[i]==VerificadorPosicao[i+1] && VerificadorPosicao[i]==VerificadorPosicao[i+2]) return 1;

        for (int i = 0; i <3; i++) if (VerificadorPosicao[i]==VerificadorPosicao[i+3] && VerificadorPosicao[i+3]==VerificadorPosicao[i+6]) return 1;

        if (VerificadorPosicao[0]==VerificadorPosicao[4] && VerificadorPosicao[4]==VerificadorPosicao[8]) return 1;
        else if (VerificadorPosicao[2]==VerificadorPosicao[4] && VerificadorPosicao[4]==VerificadorPosicao[6]) return 1;

        // empate

        if (jogadas==8)
        {
            return -1;
        }

        return 0;
    }

}   