namespace Jogo_da_velha.Partida;

internal class Partida 
{
    Tabuleiro tabuleiro = new Tabuleiro();
    Jogador jogador = new Jogador(); 
    VerificacaoVitoria verificacao = new VerificacaoVitoria();
    private List<string> ResultadoPartidas = new List<string>();
    
    public void Comandos()
    {
        do
        {
            Console.WriteLine($"#### JOGO DA VELHA ####\n");

            tabuleiro.IsTabuleiro();
            IsMovimentacao();
            if(tabuleiro.IsMovimentoValido()) jogador.SetNumerdorJogardo();

        } while (verificacao.FinalizandoPartida(jogador.GetNumerdorJogardo())!);
        
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
        Thread.Sleep(1000);
        Console.Clear();
    }

    public void isJogador(string EscolhaJogador)
    {
        jogador.SetJogador(EscolhaJogador);
    }


}


