namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar variáveis
            float n1, n2;
            string nome, input;
            int idade;

            // Leitura
            Console.Write("Por favor insira o nome: ");
            nome = Console.ReadLine();

            Console.Write("Por favor insira a idade: ");
            input = Console.ReadLine();
            idade = int.Parse(input);

            Console.Write("Por favor insira o primeiro valor: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Por favor insira o segundo valor: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            // Saída
            Console.WriteLine("====== Resultados ======");
            Console.WriteLine($"{nome} tem {idade} anos.");
            Console.WriteLine($"Soma de {n1} e {n2}: {n1 + n2}");
        }
    }
}
