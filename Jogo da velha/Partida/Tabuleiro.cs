
namespace Jogo_da_velha.Partida;

internal class Tabuleiro
{
    private string[] PosicaoTabuleiro = new string[9];

    public Tabuleiro()
    {
        isDadosInicio();
    }

    public void Setmovimento(string PosicaoEscolhida, string SimboloJogador)
    {
        for (int i = 0; i < PosicaoTabuleiro.GetLength(0); i++)
        {

            if (PosicaoTabuleiro[i]==PosicaoEscolhida)
            {
                if (PosicaoTabuleiro[i]!="X" || PosicaoTabuleiro[i]!="O")
                {
                    PosicaoTabuleiro[i] = SimboloJogador;
                    return;
                }
            }
            else if (i==PosicaoTabuleiro.Length-1)
            {
                Console.WriteLine($"Desculpe, Tente em outra posição");
            }
        }
    }
    public void IsTabuleiro()
    {
        Console.Write($"     {PosicaoTabuleiro[0]}     |     {PosicaoTabuleiro[1]}    |     {PosicaoTabuleiro[2]}    \n");
        Console.Write($" __________|__________|__________ \n");
        Console.Write($"     {PosicaoTabuleiro[3]}     |     {PosicaoTabuleiro[4]}    |     {PosicaoTabuleiro[5]}    \n");
        Console.Write($" __________|__________|__________ \n");
        Console.Write($"     {PosicaoTabuleiro[6]}     |     {PosicaoTabuleiro[7]}    |     {PosicaoTabuleiro[8]}    \n");
        Console.Write($"           |          |           \n");
    }
    private void isDadosInicio()
    {
        for (int i = 0; i < PosicaoTabuleiro.GetLength(0); i++)
        {
            int numero = i + 1;
            PosicaoTabuleiro[i] = numero.ToString();
        }
    }
  
}
