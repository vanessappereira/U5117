namespace VariaveisConstantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variaveis tipos primitivos
            int numint1, numint2;
            float numreal; // real com 5 a 6 casas de precisão
            double numDouble; // real com 15 casas de precisão

            // Declaração e inicialização de variaveis
            int n1 = 125;
            float n2 = 2548.58F;
            double n3 = 2548.58;
            decimal n4 = 2548.58M;
            float n5 = 1.5463E8f; // notação cientifica 1,5463 x 10^8 = 154630000

            // 1 - Usando operador de concatenação
            Console.WriteLine("\nValor de n1 = " + n1 + "Valor de n3 = " + n3);

            // 2 - Usando índice numerado pela ordem da variavel no output
            Console.WriteLine("\n Valor de n1 = {0} \t Valor de n3 = {1}", n1, n3);

            // 3 - Usando o operador $
            Console.WriteLine($"\nValor de n1 = {n1} \t Valor de n3 = {n3}");

            // Espaço ocupado em memória por cada um dos tipos
            Console.WriteLine("Espaço ocupado em memória por cada um dos tipos");
            Console.WriteLine($"\n Tamanho do int: {sizeof(int)}");
            Console.WriteLine($"\n Tamanho do float: {sizeof(float)}");
            Console.WriteLine($"\n Tamanho do double: {sizeof(double)}");
            Console.WriteLine($"\n Tamanho do decimal: {sizeof(decimal)}");
            Console.WriteLine($"\n Tamanho do char: {sizeof(char)}");
            Console.WriteLine($"\n Tamanho do bool: {sizeof(bool)}");
        }
    }
}
