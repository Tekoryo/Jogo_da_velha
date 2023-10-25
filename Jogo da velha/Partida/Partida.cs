namespace Jogo_da_velha.Partida;

internal class Partida
{
    Tabuleiro tabuleiro = new Tabuleiro();
    private List<string> ResultadoPartidas = new List<string>();
    Jogador jogador = new Jogador(); 
    
    public void Comandos()
    {
        Console.WriteLine($"Esta funcionando!");
        jogador.GetJogador();
        AddResultadoFinal();
    }    
    public void AddResultadoFinal()
    {
        string Resultado = "Jogador 1!";
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

    public void isJogador(string EscolhaJogador)
    {
        jogador.SetJogador(EscolhaJogador);
    }
}


