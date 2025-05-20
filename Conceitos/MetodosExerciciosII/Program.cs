namespace MetodosExerciciosII
{
    internal class Program
    {
        static void Main()
        {
            double deposito = LerDeposito();
            int anos = LerAnos();
            double taxaJuro = LerTaxaJuro();

            ExibirEvolucaoDeposito(deposito, taxaJuro, anos);
        }

        static double LerDeposito()
        {
            double deposito;
            do
            {
                Console.Write("Digite o valor do depósito inicial (mínimo 1000€): ");
            } while (!double.TryParse(Console.ReadLine(), out deposito) || deposito < 1000);
            return deposito;
        }

        static int LerAnos()
        {
            int anos;
            do
            {
                Console.Write("Digite o número de anos (mínimo 4, máximo 10): ");
            } while (!int.TryParse(Console.ReadLine(), out anos) || anos < 4 || anos > 10);
            return anos;
        }

        static double LerTaxaJuro()
        {
            double taxaJuro;
            do
            {
                Console.Write("Digite a taxa de juro inicial (% entre 5.0 e 8.0): ");
            } while (!double.TryParse(Console.ReadLine(), out taxaJuro) || taxaJuro < 5.0 || taxaJuro > 8.0);
            return taxaJuro;
        }

        static void ExibirEvolucaoDeposito(double deposito, double taxaJuro, int anos)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("\n=== Evolução do Depósito Bancário ===");
            Console.WriteLine("Ano |  Capital Inicial  | Taxa de Juro (%) |  Juros   | Capital Final");

            for (int ano = 1; ano <= anos; ano++)
            {
                double juros = deposito * (taxaJuro / 100);
                double capitalFinal = deposito + juros;

                Console.WriteLine($"{ano,3} | {deposito,15:F2} € |   {taxaJuro,14:F2} | {juros,6:F2} € | {capitalFinal,13:F2} €");

                deposito = capitalFinal;
                if (taxaJuro > 5.0) taxaJuro -= 0.5;
            }
        }
    }
}
