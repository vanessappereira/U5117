namespace MatrizExemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matriz - estrutura de dados que armazena
            // um conjunto de elementos do mesmo tipo em duas dimensões (linhas e colunas)

            /* Declaração de uma matriz de inteiros */
            int[,] matriz; // Referencia, não reserva memória

            // Inicialização de uma matriz de inteiros com valores predefinidos
            int[,] matriz1 = { { 3, 6 }, { 2, 14 }, { 23, 8 } };

            // Cria uma matriz 2x3 (2 linhas e 3 colunas)
            int[,] matriz2 = new int[2, 3];

            // Atribui valores à matriz3
            matriz2[1, 2] = 100;

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {

                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.WriteLine($"Elemento [{i}, {j}]: ");


                }
            }

        }
    }
}
