namespace Jogo_da_velha;

internal class InteligenciaArtificial
{
    Random rnd = new Random();
    public string EscolhendoPosicao()
    {
        int Posicao = rnd.Next(1, 10);
        return $"{Posicao}";
    }
}
