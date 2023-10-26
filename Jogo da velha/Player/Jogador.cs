
namespace Jogo_da_velha;

internal class Jogador
{
    private string? jogador1 { get; set; }
    private string? jogador2 { get; set; }
    private int Numerador = 1;
    
   public void SetJogador(string EscolhaJogador)
    {
        jogador1 = EscolhaJogador.ToUpper();

        if (jogador1 == "X") jogador2 = "O";
        else jogador2 = "X";
    }
    public string GetNomeJogador()
    {
        if(VezJogador()==1) return "jogador 1";
        else return "jogador 2";
    }
    public string GetSimboloJogador()
    {
        if (VezJogador()==1) return $"{jogador1}";
        else return $"{jogador2}";
    }
    public string GetNomeFinalJogador()
    {
        if (VezJogador()==1) return "jogador 2";
        else return "jogador 1";
    }
    public void SetNumerdorJogardo()
    {
        Numerador++;
    }
    public int GetNumerdorJogardo()
    {
        return Numerador;
    }
    public int VezJogador()
    {
        if (Numerador % 2 != 0) return 1;
        else return 0;
    }
  
    public void ResetJogador()
    {
        Numerador = 1;
    }
}
