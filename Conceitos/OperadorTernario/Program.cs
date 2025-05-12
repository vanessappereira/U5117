namespace OperadorTernario
{
    internal class Program
    {
        // Operador Ternário ou operador condicional
        // sintaxe:    condicao ? ExpressaoSeVerdadeira : ExpressãoSeFalso
        static void Main(string[] args)
        {
            int numero = 2;

            string str = numero % 2 == 0 ? $"Resultado: {numero} é par" :
                $"Resultado: {numero} é impar";

            Console.WriteLine(str);
        }
    }
}
