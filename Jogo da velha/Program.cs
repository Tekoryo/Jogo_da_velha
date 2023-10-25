using Jogo_da_velha.Partida;


Partida partida = new Partida();
VerificacaoVitoria verificacao = new VerificacaoVitoria();

partida.IsVerificador(verificacao);
void menu()
{
    string? NPartida = "s";

    do
    {
        NovaPartida(); 

        Console.WriteLine("Quer mais uma partida? [s/n]");
        NPartida = Console.ReadLine();
        if (NPartida=="n") break;
    } while (true);
        verificacao. ExibirResultadosPartidas();
}
void NovaPartida()
{
    partida.IsPartida();

}

Console.WriteLine("Jogo da Velha!");
menu();
Console.WriteLine("Fim!");