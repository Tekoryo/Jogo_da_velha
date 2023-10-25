
using Jogo_da_velha.Partida;

Partida partida = new Partida();


void menu()
{
    //Titulo
    int teste = 0;
    EscolhendoJogador();
    do
    {
        // Partidas();
        teste++;
        
    } while (teste!=2);
    partida.ExibirResultadoPartida();
}
void Partidas()
{
    partida.Comandos();
}
void EscolhendoJogador()
{
    Console.WriteLine($"=========== X ou O ===========");
    Console.Write("Escolha: ");
    string? EscolhaJogador = Console.ReadLine();
}
try
{
    menu();
}
catch (Exception e)
{
    Console.WriteLine($"Temos um problema: {e.Message}");
}