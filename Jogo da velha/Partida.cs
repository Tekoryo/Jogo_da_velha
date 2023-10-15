using Jogo_da_velha;
namespace Jogo_da_velha;

internal class Partida
{
    Mapa mapa = new Mapa();

    public void inicio()
    {
        mapa.isGerador();
    }
}
