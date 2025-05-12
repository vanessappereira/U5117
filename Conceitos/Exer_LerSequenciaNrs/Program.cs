namespace Exer_LerSequenciaNrs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ler uma sequência de números inteiros positivos (a sequência termina com 0)
             * Apresentar a média desses valores
             * Quantos deles são números pares */

            uint num = 1, soma = 0; // unsigned int - só valores positivos
            byte totalnrs = 0, totalPares = 0; // unsigned byte 0 a 255

            Console.WriteLine("\nDigite uma sequência de números inteiros positivos (termine com 0): ");
        inicio:
            while (num != 0)
            {
                // Verificar se o nr é positivo e inteiro
                if (!uint.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Número inválido! Digite apenas inteiros positivos.");
                    num = 1;
                    goto inicio;
                }

                // Terminar sequência
                if (num == 0)
                    break;

                // Realizar o cálculo
                soma += num;
                totalnrs++;

                // Verificar se é par
                if (num % 2 == 0)
                    totalPares++;
            }
            // Verificar se o total de nrs é maior que zero
            if (totalnrs > 0)
            {
                // Realizar a média
                double media = (double)soma / totalnrs;
                Console.WriteLine($"\nMédia dos valores inseridos: {media:F2}");
                Console.WriteLine($"Quantidade de números pares: {totalPares}");
            }
            else
            {
                Console.WriteLine("\nNenhum número válido foi inserido.");
            }
        }
    }
}
