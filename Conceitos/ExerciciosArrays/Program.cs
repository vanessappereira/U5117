namespace ExerciciosArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] stock = {
            { 150,   0, 100,   0, 150 },
            { 200, 300, 230, 100, 200 },
            { 250, 300,   0, 200, 300 },
            { 300, 400, 250, 300, 200 },
            { 350, 200, 400, 250, 200 }
            };

            MostrarStock(stock);

            while (true)
            {
                Console.Write("\nDigite o número do armazém (0 a 4, ou -1 para sair): ");
                int linha = int.Parse(Console.ReadLine());

                if (linha == -1)
                    break;

                if (linha < 0 || linha > 4)
                {
                    Console.WriteLine("Armazém inválido! Tente novamente.");
                    continue;
                } // end if

                Console.Write("Digite o número do produto (0 a 4): ");
                int coluna = int.Parse(Console.ReadLine());

                if (coluna < 0 || coluna > 4)
                {
                    Console.WriteLine("Produto inválido! Tente novamente.");
                    continue;
                }

                Console.WriteLine($"Digite a quantidade do produto a ser retirada: ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade > stock[linha, coluna])
                {
                    Console.WriteLine("Stock insuficiente para atender o pedido.");
                    continue;
                }// end if

                stock[linha, coluna] -= quantidade;
                Console.WriteLine($"Retirado {quantidade} do produto {coluna} do armazém {linha}.\n" +
                    $"Stock atualizado do produto: {stock[linha, coluna]}");

            } // end while

            Console.WriteLine("\nStock final após retirada: ");
            MostrarStock(stock);

        } // end Main


        static void MostrarStock(int[,] stock)
        {
            Console.WriteLine("\nStock atualizado:");

            Console.WriteLine("         | Produto 0 | Produto 1 | Produto 2 | Produto 3 | Produto 4 |");
            Console.WriteLine("-----------------------------------------------------------------------");

            for (int i = 0; i < stock.GetLength(0); i++)
            {
                Console.Write($"Armazém {i} | ");

                for (int j = 0; j < stock.GetLength(1); j++)
                {
                    Console.Write($"{stock[i, j],9} | ");
                } // end for

                Console.WriteLine();
            } // end for

        } // end MostrarStock

    } // end Program
} // end namespace
