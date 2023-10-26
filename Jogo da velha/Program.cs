
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

    partida.isJogador(EscolhendoJogadores());

    Console.Clear();
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
string EscolhendoJogadores()
{
    Console.WriteLine($"============= X ou O =============");
    Console.Write("Escolha: ");
    string? EscolhaJogador = Console.ReadLine();
    ContraIA();
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
void ContraIA()
{
    Console.WriteLine($"==================================\n");
    Console.Write("Deseja Ir contra uma IA? [S/n] ");
    string? ContraIA = Console.ReadLine();
    partida.IaAtiva(ContraIA.ToUpper());
}
void TituloJogo()
{
    Console.WriteLine($"#### JOGO DA VELHA ####\n");
}
