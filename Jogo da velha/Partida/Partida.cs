namespace Jogo_da_velha.Partida;

internal class Partida
{
    Tabuleiro tabuleiro = new Tabuleiro();
    Jogador player = new Jogador();
    VerificacaoVitoria verificacao = new VerificacaoVitoria();

    public void IsPartida()
    {
        tabuleiro.SetIsVerificarVitoria();
        tabuleiro.SetIsDadosInicio();
        TipoJogador();
        do
        {           
            Console.WriteLine($"Vez do {player.VezDoJogador(1)}:");            
            tabuleiro.IsJogador(player);            
            tabuleiro.IsVerificador(verificacao);            
            tabuleiro.isGerenciador();
            
        } while (IsVerificacao());
         
        if(verificacao.SetIsVitoria()==1) verificacao.IsVitoiraDe(1);
        else if(verificacao.SetIsVitoria()==-1) verificacao.IsVitoiraDe(-1);
    }
    private void TipoJogador()
    {
        Console.WriteLine("Qual Voce Escolhe Player1: [X/O]?");
        string Player1 = Console.ReadLine()!;
        player.TipoPlayer(Player1);
    }
    
    private bool IsVerificacao()
    {
        if (verificacao.SetIsVitoria()==1) return false;
        else if (verificacao.SetIsVitoria()==-1) return false;
        return true;
    }

}

