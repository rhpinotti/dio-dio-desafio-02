namespace CalculadoraPartidasRankeadas;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            bool encerrar = false;

            while (!encerrar)
            {
                Console.Clear();
                
                Console.Write("Número de vitórias: ");
                if (!short.TryParse(Console.ReadLine(), out short vitorias))
                {
                    Console.WriteLine("\tValor inválido, valor máximo de 32.767.\n\tZerando as vitórias.");
                    vitorias = 0;
                }

                Console.Write("Número de derrotas: ");
                if (!short.TryParse(Console.ReadLine(), out short derrotas))
                {
                    Console.WriteLine("\tValor inválido, valor máximo de 32.767.\n\tZerando as derrotas.");
                    derrotas = 0;
                }

                var jogador = new Jogador(vitorias, derrotas);
                
                Console.WriteLine($"O Herói tem saldo de **{jogador.saldoVitorias}** está no nível de **{jogador.ObterClasseJogador()}**");

                Console.WriteLine("\n\n--> pressione qualquer tecla para continuar ou q para sair.");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                    encerrar = true;
            }
        }
        catch
        {
            Console.WriteLine("Ops...Não foi possível calcular o ranking, execute novamente o programa.");
        }
    }
}
