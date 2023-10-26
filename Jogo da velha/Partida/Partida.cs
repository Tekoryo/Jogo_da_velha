namespace Jogo_da_velha.Partida;

internal class Partida
{
    Tabuleiro tabuleiro = new Tabuleiro();
    private List<string> ResultadoPartidas = new List<string>();
    Jogador jogador = new Jogador(); 
    
    public void Comandos()
    {
        int x = 0;
        do
        {
            jogador.SetNumerdorJogardo();
            tabuleiro.IsTabuleiro();
            IsMovimentacao();
            x++;
        }while (x < 9);
        
        AddResultadoFinal();
        jogador.FimPartida();
    }    
    public void AddResultadoFinal()
    {
        string Resultado = jogador.GetNomeJogador();
        ResultadoPartidas.Add(Resultado);
    }
    public void ExibirResultadoPartida()
    {
        Console.WriteLine($"Resultado das partidas:");
        int i = 0;
        foreach ( var Resultado in ResultadoPartidas)
        {
            Console.WriteLine($"Resultado da partida {i+1}º: {Resultado}");
            i++;
        }
    }

    public void IsMovimentacao()
    {
        Console.WriteLine($"Vez do {jogador.GetNomeJogador()} do Simbolo {jogador.GetSimboloJogador()}: ");
        string? PosisaoEscolhida = Console.ReadLine();
        tabuleiro.Setmovimento(PosisaoEscolhida, jogador.GetSimboloJogador());
    }

    public void isJogador(string EscolhaJogador)
    {
        jogador.SetJogador(EscolhaJogador);
    }
}


