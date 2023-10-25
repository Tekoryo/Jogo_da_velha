using Jogo_da_velha.Partida;


Partida partida = new Partida();

void menu()
{
    string NPartida = "s";
    do {
        NovaPartida();

        Console.WriteLine("Quer mais uma partida? [s/n]");
        NPartida = Console.ReadLine();
    } while(NPartida!="n");    
        
}
void NovaPartida()
{
    partida.IsPartida();

}

Console.WriteLine("Jogo da Velha!");
menu();
Console.WriteLine("Fim!");