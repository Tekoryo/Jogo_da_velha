
namespace Jogo_da_velha.Partida;

internal class VerificacaoVitoria
{
    
    private string[] VericadorVelha = new string[9];
    private List<string> PartidasJogadas = new List<string>();
    private Jogador jogador = new Jogador();
      
    public void IsDados(string[] XorO, Jogador Player)
    {
        for (int i = 0;i < VericadorVelha.GetLength(0); i++) VericadorVelha[i] = XorO[i];
        jogador = Player;
    }
    private int IsVitoria()
    {
  
        for (int i = 0; i <VericadorVelha.GetLength(0);i+=3) if (VericadorVelha[i]==VericadorVelha[i+1] && VericadorVelha[i]==VericadorVelha[i+2]) return 1;

        for (int i = 0; i <3; i++) if (VericadorVelha[i]==VericadorVelha[i+3] && VericadorVelha[i+3]==VericadorVelha[i+6]) return 1;

        if (VericadorVelha[0]==VericadorVelha[4] && VericadorVelha[4]==VericadorVelha[8]) return 1;
        else if (VericadorVelha[2]==VericadorVelha[4] && VericadorVelha[4]==VericadorVelha[6]) return 1;

        if (jogador.GetContadorMovimento()==10)
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
        string Vitoria= jogador.IdJogadorVitoria();

        if (FimPartida==1)
        {
            Console.WriteLine($"Vitoria do {Vitoria}");
            PartidasJogadas.Add(Vitoria);
        }
        else
        {
            Console.WriteLine($"O jogo terminou em empate!");
            PartidasJogadas.Add("EMPATE!");
        }
        PartidasJogadas.Add(Vitoria);
        Thread.Sleep(1000);
    }
    
    public void ExibirResultadosPartidas()
    {
        Console.WriteLine($"RESULTADO DE TODAS AS PARTIDAS:");
        int i = 1;
        foreach (var partidas in PartidasJogadas)
        {
            Console.WriteLine($"Resultado Partida {i}º: {partidas}");
            i++;
        }
        
        Console.ReadKey();
    }
}

