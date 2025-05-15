namespace ExerciciosMetodos
{
    internal class Program
    {
        /*  Elabore um procedimento que mostre as raízes quadradas dos
         *  inteiros de um dado intervalo. O programa principal deverá
         *  invocar este procedimento para mostrar as raízes quadradas
         *  dos números inteiros compreendidos no intervalo dado pelo 
         *  utilizador. 
         *  Parâmetro   Tipo    Significado
                Inf     int     Limite inferior do intervalo
                Sup     int     Limite superior do intervalo
         */
        static void Main(string[] args)
        {
            int inferior, superior;

            inferior = LerValor("\n\tDigite o valor do limite inferior:  ", 0);
            superior = LerValor("\n\tDigite o valor do limite superior:  ", inferior + 1);

            CalcularRaizQuadrada(inferior, superior);
        }

        static int LerValor(string str, int limite)
        {
            int valor;

            while (true)
            {
                Console.Write(str);
                if (int.TryParse(Console.ReadLine(), out valor) && valor >= limite)
                    break;
            }
            return valor;
        }

        static void CalcularRaizQuadrada(int inf, int sup)
        {
            for (int i = inf; i <= sup; i++)
            {
                Console.WriteLine($"\n\tRaiz quadrada de {i} = {Math.Sqrt(i)}");
                if (i % 10 == 0)
                {
                    Console.Write("\n\tPrima tecla para continuar...   ");
                    Console.ReadKey();
                }
            }

        }
    }
}
