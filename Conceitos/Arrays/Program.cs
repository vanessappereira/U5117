namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Array - estrutura de dados que armazena um conjunto de elementos do mesmo tipo */

            // Declaração de um array de inteiros
            int[] numeros1;

            // Inicialização de um array de inteiros com 5 elementos
            int[] numeros2 = new int[5];

            // Inicialização de um array de inteiros com valores predefinidos
            int[] numeros3 = { 1, 2, 3, 4, 5 };

            // Atribuição de valores ao array numeros2
            numeros2[0] = 10;
            numeros2[1] = 20;
            numeros2[2] = 30;
            numeros2[3] = 40;
            numeros2[4] = 50;

            // Random para gerar números aleatórios
            Random rand = new Random();

            // Inicializa o array numeros1 com 5 elementos e atribui valores aleatórios
            numeros1 = new int[8];
            for (int i = 0; i < numeros1.Length; i++)
            {
                numeros1[i] = rand.Next(1, 101); // Atribui um valor aleatório entre 1 e 100
            }

            // Exibe o tamanho do array
            Console.WriteLine("Tamanho do array numeros1: " + numeros1.Length);
            Console.WriteLine("Tamanho do array numeros2: " + numeros2.Length);
            Console.WriteLine("Tamanho do array numeros3: " + numeros3.Length);

            // Exibe os valores do array numeros1
            Console.WriteLine("\nValores do array numeros1:");
            for (int i = 0; i < numeros1.Length; i++)
            {
                Console.WriteLine($"numeros1[{i}] = {numeros1[i]}");
            }

            // Exibe os valores do array numeros2
            Console.WriteLine("\nValores do array numeros2:");
            foreach (int valor2 in numeros2)
            {
                Console.WriteLine($"numero = {valor2}");
            }

            // Exibe os valores do array numeros3
            Console.WriteLine("\nValores do array numeros3:");
            for (int i = 0; i < numeros3.Length; i++)
            {
                Console.WriteLine($"numeros3[{i}] = {numeros3[i]}");
            }

            // Ordena o array numeros1 em ordem crescente
            Console.WriteLine("\nArray numeros1 ordenado:");
            foreach (int valor1 in numeros1)
            {
                Console.WriteLine(valor1);
            }

            // Inverte a ordem do array numeros1
            Console.WriteLine("\nArray numeros1 ordenado em ordem decrescente:");
            Array.Reverse(numeros1);
            foreach (int valor1 in numeros1)
            {
                Console.WriteLine(valor1);
            }

            // Copia os primeiros 5 elementos de numeros1 para numeros2
            Array.Copy(numeros1, numeros2, 5);
            Console.WriteLine("\nArray numeros2 após cópia:");
            foreach (int valor2 in numeros2)
            {
                Console.WriteLine(valor2);
            }

        }
    }
}
