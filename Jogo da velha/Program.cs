
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
    TituloJogo();

    partida.isJogador(EscolhendoJogador());
    Console.Clear();
    do
    {
        TituloJogo();
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
    Console.WriteLine($"==================================\n");
    Console.Write("Deseja ter mais uma partida? [S/n] ");
    string? Finalizar = Console.ReadLine().ToUpper();
    
    if (Finalizar!="N") return true;
    else return false;
}
void TituloJogo()
{
    Console.WriteLine($"#### JOGO DA VELHA ####\n");
}
