namespace E1ValorComissao
{
    // Clareza no código, indentação e comentários no programa são de grande importância.
    // A entrada de dados deve ser sempre validada.

    /* Elabore um programa que receba o valor total das vendas, o nome 
     * e calcule a comissão de cada vendedor, mediante a seguinte tabela de comissões:
     * 
     * Tabela de comissões:  
     *  Total de vendas       		        Comissão  
     *      Abaixo de 20000                 0% 
     *      Entre 20000 e 40000 inclusive   5%  
     *      Entre 40000 e 60000 inclusive   10%  
     *      Entre 60000 e 80000 inclusive   15%  
     *      Acima de 80000                  20%  
     *      
     * Existem apenas dez vendedores. Calcule e apresente:  
     *  •  Os nomes dos vendedores e os valores das comissões a receber.  
     *  •  O total das vendas de todos os vendedores.  
     *  •  O maior valor de comissão a receber e quem o receberá.  
     *  •  O menor valor de comissão a receber e quem o receberá. 
     *  
     *  Obter as informações a partir de um menu de opções. */
    internal class Program
    {
        const int LIMITE_VENDEDORES = 10;
        static string[] nomes = new string[LIMITE_VENDEDORES];
        static double[] vendas = new double[LIMITE_VENDEDORES];
        static int totalVendedores = 0;

        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine(" Sistema de Comissões de Vendedores\n" +
                    "   1. Adicionar vendedor\n" +
                    "   2. Mostrar vendedores\n" +
                    "   3. Mostrar total de vendas\n" +
                    "   4. Calcular comissões\n" +
                    "   5. Verificar comissões");
                Console.Write("Escolha uma opção (-1 para sair): ");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida! Digite um número válido.");
                }
                switch (opcao)
                {
                    case 1:
                        AdicionarVendedor();
                        break;
                    case 2:
                        MostrarVendedores();
                        break;
                    case 3:
                        TotalDeVendas();
                        break;
                    case 4:
                        CalcularComissoes();
                        break;
                    case 5:
                        VerificarComissoes();
                        break;
                    case -1:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Escolha entre 1 e 5, ou -1 para sair.");
                        break;
                }
            } while (opcao != -1);
        } // end Main()

        private static void AdicionarVendedor()
        {
            // reconhecer carateres não ASCII
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Verificar se o total de vendedores registados não excede o programado 
            if (totalVendedores >= LIMITE_VENDEDORES)
            {
                Console.WriteLine("Limite de vendedores antingido!");
                return;
            }

            // Solicitar ao utilizador o nome e o valor das vendas do vendedor
            Console.WriteLine("Digite o nome do vendedor: ");
            nomes[totalVendedores] = Console.ReadLine(); // Cada vendedor tem sua posição identificada por totalVendedores

            Console.WriteLine("Digite o valor total das vendas: ");

            // Verificar se o número é double e se é maior que zero
            while (!double.TryParse(Console.ReadLine(), out vendas[totalVendedores]) || vendas[totalVendedores] < 0)
            {
                Console.WriteLine("Valor inválido! Digite um número positivo.");
            }
            // adiciona posição ao total de vendedores
            totalVendedores++;

            Console.WriteLine("Vendedor adicionado com sucesso!");
        } // end AdicionarVendedor()

        private static void MostrarVendedores()
        {
            // reconhecer carateres não ASCII
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Os nomes dos vendedores e os valores das comissões a receber
            if (totalVendedores == 0)
            {
                Console.WriteLine("Nenhum vendedor registado.");
                return;
            }
            Console.WriteLine("\n====================================");
            Console.WriteLine("Vendedores e suas vendas:");
            Console.WriteLine("====================================");
            Console.WriteLine("Nome\t|\tVendas\t|\tComissão");
            Console.WriteLine("------------------------------------");

            for (int i = 0; i < totalVendedores; i++)
            {
                double comissao = CalcularComissao(vendas[i]);
                Console.WriteLine($"{nomes[i]}\t|\t{vendas[i]:C2} €\t|\t{comissao:C2} €");
            }
        } // end MostrarVendedores()

        private static void TotalDeVendas()
        {
            // reconhecer carateres não ASCII
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // O total de vendas de todos os vendedores
            if (totalVendedores == 0)
            {
                Console.WriteLine("Nenhum vendedor registado.");
                return;
            }

            double total = 0;
            for (int i = 0; i < totalVendedores; i++)
            {
                total += vendas[i];
            }

            Console.WriteLine($"\nTotal de vendas do grupo: {total:C2} €");


        } // end TotalDeVendas()

        private static void CalcularComissoes()
        {
            // reconhecer carateres não ASCII
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            if (totalVendedores == 0)
            {
                Console.WriteLine("Nenhum vendedor registado.");
                return;
            }

            Console.WriteLine("\nComissões dos vendedores:");
            for (int i = 0; i < totalVendedores; i++)
            {
                double comissao = CalcularComissao(vendas[i]);
                Console.WriteLine($"{nomes[i]} - Comissão: {comissao:C2} €");
            }

        } // end CalcularComissoes()

        // Método auxiliar para calcular comissão com base na tabela fornecida
        private static double CalcularComissao(double vendas)
        {
            // Abaixo de 20000 = 0%
            if (vendas < 20000)
                return 0;

            // Entre 20000 e 40000 = 5%
            if (vendas >= 20000 || vendas <= 40000)
                return vendas * 0.05;

            // Entre 40000 e 60000 = 10%
            if (vendas >= 40000 || vendas <= 60000)
                return vendas * 0.10;

            // Entre 60000 e 80000 = 15%
            if (vendas >= 60000 || vendas <= 80000)
                return vendas * 0.15;

            // Acima de 80000 = 20%
            return vendas * 0.20;
        }

        private static void VerificarComissoes()
        {
            // O maior valor de comissão a receber e quem o receberá.  
            // O menor valor de comissão a receber e quem o receberá.

            // reconhecer carateres não ASCII
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double maiorComissao = 0, menorComissao = double.MaxValue;
            string vendedorMaiorComissao = "", vendedorMenorComissao = "";

            if (totalVendedores == 0)
            {
                Console.WriteLine("Nenhum vendedor registado.");
                return;
            }
            for (int i = 0; i < totalVendedores; i++)
            {
                double comissao = CalcularComissao(vendas[i]);
                if (comissao > maiorComissao)
                {
                    maiorComissao = comissao;
                    vendedorMaiorComissao = nomes[i];
                }
                if (comissao < menorComissao && comissao > 0) // Ignora comissões de 0
                {
                    menorComissao = comissao;
                    vendedorMenorComissao = nomes[i];
                }
            }

            Console.WriteLine($"\n\tMaior comissão: {maiorComissao:C2} € ({vendedorMaiorComissao})" +
                $"\n\tMenor comissão: {menorComissao:C2} € ({vendedorMenorComissao})");

        } // end VerificarComissoes()

    } // end class Program
} // end namespace ValorComissao
