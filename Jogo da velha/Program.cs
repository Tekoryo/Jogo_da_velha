
using Jogo_da_velha.Partida;

Partida partida = new Partida();
try
{
    menu();
}
catch (Exception e)
{
    Console.WriteLine($"Temos um problema: {e.Message}");
}
void menu()
{
    //Titulo
    
    partida.isJogador(EscolhendoJogador());
    do
    {
        Partidas();
                
    } while (FinalizandoPartida()!);
    partida.ExibirResultadoPartida();
}
void Partidas()
{
    
    
    partida.Comandos();
}
string EscolhendoJogador()
{
    Console.WriteLine($"============= X ou O =============");
    Console.Write("Escolha: ");
    string? EscolhaJogador = Console.ReadLine();    
    return EscolhaJogador;
}
bool FinalizandoPartida()
{
    Console.WriteLine($"==================================");
    Console.Write("Deseja Finalizar a partida? [S/n] ");
    string? Finalizar = Console.ReadLine().ToUpper();
    
    if (Finalizar!="N") return true;
    else return false;

}
