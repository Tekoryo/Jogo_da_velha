
namespace Jogo_da_velha.Partida;

internal class VerificacaoVitoria
{
    private string[] VericadorVelha = new String[9];
    private Jogador player = new Jogador();
  
    public void IsDados(string[] XorO, Jogador Player)
    {
        for (int i = 0;i < VericadorVelha.GetLength(0); i++) VericadorVelha[i] = XorO[i];
        player = Player;
    }
    private int IsVitoria()
    {
  
        for (int i = 0; i <VericadorVelha.GetLength(0);i+=3) if (VericadorVelha[i]==VericadorVelha[i+1] && VericadorVelha[i]==VericadorVelha[i+2]) return 1;

        for (int i = 0; i <3; i++) if (VericadorVelha[i]==VericadorVelha[i+3] && VericadorVelha[i+3]==VericadorVelha[i+6]) return 1;

        if (VericadorVelha[0]==VericadorVelha[4] && VericadorVelha[4]==VericadorVelha[8]) return 1;
        else if (VericadorVelha[2]==VericadorVelha[4] && VericadorVelha[4]==VericadorVelha[6]) return 1;

        if (player.GetContadorMovimento()==10)
        {
            return -1;
        }

        return 0;

    }
    public int SetIsVitoria()
    {
        if (IsVitoria() ==1) return 1;
        else if(IsVitoria()==-1) return -1;
        return 0;
    }
    public void IsVitoiraDe(int FimPartida)
    {
        string Vitoria = player.VezDoJogador(0);

        if (FimPartida==1) Console.WriteLine($"Vitoria do {Vitoria}");
        else Console.WriteLine($"O jogo terminou em empate!");
        Thread.Sleep(1000);
    }
}

