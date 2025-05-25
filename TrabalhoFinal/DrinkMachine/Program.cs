namespace E2DrinkMachine
{
    // Clareza no código, indentação e comentários no programa são de grande importância.
    // A entrada de dados deve ser sempre validada.

    /* Elabore um programa que permita simular o funcionamento de uma máquina de venda de vários tipos de bebidas quentes (café, chocolate e chá).
     * O custo de cada produto é o seguinte:
     *      Café - 0,25€
     *      Cappuccino – 0,30€
     *      Chocolate – 0,35€
     *      Chá – 0,20€

     * •  Deverá ser apresentado um menu de opções para que o utilizador possa escolher a sua bebida.
     * •  A máquina aceita apenas moedas de 0.05€, 0.10€, 0.20€, 0.50€, 1€ e 2€.
     * •  Pode comprar mais do que uma bebida.
     * •  O troco devolvido deve conter o menor número possível de moedas e explicitar quais as moedas devolvidas.
     * •  A máquina continuará em funcionamento após efetuada a compra. 
     
    // reconhecer carateres não ASCII Console.OutputEncoding = System.Text.Encoding.UTF8;
     */
    internal class Program
    {
        // Constantes para os preços das bebidas
        const double PRECO_CAFE = 0.25, PRECO_CAPPUCCINO = 0.30, PRECO_CHOCOLATE = 0.35, PRECO_CHA = 0.20;

        // Array para armazenar os valores das moedas aceites
        private static double[] moedasAceites = [0.05, 0.10, 0.20, 0.50, 1.00, 2.00];

        static void Main(string[] args)
        {
            // Configurar a codificação do console para UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Exibir mensagem de boas-vindas
            Console.WriteLine("Bem-vindo à Máquina de Bebidas Quentes!");

            bool continuar = true;
            while (continuar)
            {
                // Exibir o menu de opções
                Console.WriteLine("\nEscolha uma bebida:" +
                    "\n1. Café - 0,25€" +
                    "\n2. Cappuccino - 0,30€" +
                    "\n3. Chocolate - 0,35€" +
                    "\n4. Chá - 0,20€");

                int opcao;

                // Loop para garantir que a opção é válida
                do
                {
                    Console.Write("Escolha uma opção (-1 para sair): ");
                } while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < -1 || opcao > 4));

                if (opcao == -1)
                {
                    Console.WriteLine("Obrigado por usar a Máquina de Bebidas Quentes! Até logo!");
                    break;
                }

                switch (opcao)
                {
                    case 1:
                        ProcessarCompra(PRECO_CAFE, "Café");
                        break;
                    case 2:
                        ProcessarCompra(PRECO_CAPPUCCINO, "Cappuccino");
                        break;
                    case 3:
                        ProcessarCompra(PRECO_CHOCOLATE, "Chocolate");
                        break;
                    case 4:
                        ProcessarCompra(PRECO_CHA, "Chá");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
                        break;
                } // end switch
            } // end while
        } // end Main()


        private static void ProcessarCompra(double preco, string bebida)
        {
            Console.WriteLine($"Você escolheu {bebida}. O preço é {preco:0.00} €.");

            // Inicializar o total inserido
            double totalInserido = 0.0;

            // Solicitar ao usuário que insira moedas até atingir o preço da bebida
            while (totalInserido < preco)
            {
                Console.WriteLine("Insira uma moeda (0.05€, 0.10€, 0.20€, 0.50€, 1€, 2€): ");
                double moeda = 0.0;
                // Verifica se a moeda inserida é válida, tanto em tipo, quanto as moedas aceites
                while (!double.TryParse(Console.ReadLine(), out moeda) || !moedasAceites.Contains(moeda))
                {
                    Console.WriteLine("Moeda inválida! Por favor, insira uma moeda válida.");
                } // end while

                // Adiciona a moeda ao total inserido
                totalInserido += moeda;
                Console.WriteLine($"Total inserido: {totalInserido:0.00} €\t {bebida}: {preco:0.00} €");

            } // end while
            if (totalInserido > preco)
            {
                double troco = totalInserido - preco;
                DevolverTroco(troco);
            }
            else
            {
                Console.WriteLine("Compra realizada com sucesso! Não há troco a devolver.");
            } // end if
        } // end ProcessarCompra()

        private static void DevolverTroco(double troco)
        {
            Console.WriteLine($"\nCompra realizada com sucesso! Seu troco é {troco:0.00} €." +
                $"\nMoedas devolvidas:");

            // Percorrer as moedas aceites do maior para o menor
            foreach (double moeda in moedasAceites.OrderByDescending(m => m))
            {
                int moedasParaDevolver = 0;

                // Enquanto o troco for maior ou igual à moeda, adiciona a moeda à lista de devolução
                while (troco >= moeda)
                {
                    troco = Math.Round(troco - moeda, 2); // Arredonda para evitar erros de precisão
                    moedasParaDevolver++;
                } // end while

                if (moedasParaDevolver > 0)
                {
                    Console.WriteLine($"{moeda:0.00} €");
                } // end if
            } // end foreach

            Console.WriteLine("Troco devolvido com sucesso!" +
                "\nA máquina continua em funcionamento");

            // Retorna ao menu principal
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        } // end DevolverTroco()

    } // end Program
} // end namespace DrinkMachine
