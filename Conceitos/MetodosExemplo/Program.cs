namespace MetodosExemplo
{
    internal class Program
    {
        /**
         * Em C#, o método Main pode ter várias assinaturas válidas
         * static void Main() // Sem parâmetros
         * static void Main(string[] args) // Com parâmetros
         *
         */
        static void Main()
        {
            int num1 = 10, num2 = 20, numero;
            float num3 = 25.8f;

            TrocaPorValor(num1, num2);
            Console.WriteLine($"\n\tTroca por valor: \n\tnum1 = {num1} \tnum2 = {num2}");

            TrocaPorReferencia(ref num1, ref num2);
            Console.WriteLine($"\n\tTroca por Referência: \n\tnum1 = {num1} \tnum2 = {num2}");

            float resultado = SomaValores(num1, num3);
            Console.WriteLine($"\n\tResultado = {resultado}");

            Console.WriteLine($"\n\tValor alterado = {MudarValor()}");
            Console.WriteLine($"\n\tValor alterado = {MudarValor(5)}");

            Console.WriteLine($"\n\tCálculos = {Calculos(5, 10, out numero)}");
            Console.WriteLine($"\n\tnumero = {numero}");

        }

        /* Passagem de parâmetros por valor - É feita uma cópia dos argumentos (na chamada do método), 
         * para os parâmetros do método (são variáveis locais que apenas existem durante a execução 
         * do método). Qualquer alteração realizada nesses parâmetros não se reflete nos argumentos. */
        static void TrocaPorValor(int num1, int num2)
        {
            int aux = num1;
            num1 = num2;
            num2 = aux;
        }

        /* Passagem de parâmetros por referência - É passado o endereço de memória dos argumentos 
         * do método. Qualquer alteração realizada nos parâmetros do método reflete-se 
         * nas variáveis passadas como argumentos. */
        static void TrocaPorReferencia(ref int n1, ref int n2)
        {
            int aux = n1;
            n1 = n2;
            n2 = aux;
        }

        /* Com valor de retorno e passagem de parâmetros */
        static float SomaValores(int num1, float num2)
        {
            return num1 + num2;
        }

        /* Método com parâmetro por defeito inicializado */
        static int MudarValor(int n = 100)
        {
            int x = n + 1000;
            return x;
        }

        static int Calculos(int n1, int n2, out int n3)
        {
            int x = 10;
            n3 = x * x;
            int soma = n1 + n2;
            return soma;
        }

    } // End of class Program
} // End of namespace MetodosExemplo
