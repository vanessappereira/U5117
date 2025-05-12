namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7, num2 = 3;
            int quocienteInt = num1 / num2;

            Console.WriteLine($"{num1}/{num2}={quocienteInt}");
            Console.WriteLine($"{num1}/{num2}={num1 / num2}");

            float num3 = 7;
            float quocienteReal = num1 / num2;
            Console.WriteLine($"{num1}/{num2}={quocienteReal}");


            quocienteReal = num3 / num2;
            Console.WriteLine($"\n{num3}/{num2}={quocienteReal}");

            // Resto da divisão inteira
            int resto = num1 % num2;
            Console.WriteLine($"\n{num1}%{num2}={resto}");

            // Operador incremento ++ 
            int n1 = 4, n2 = 4;

            // Primeiro incrementa e depois imprime
            Console.WriteLine("\n\t Incremento como prefixo");
            Console.WriteLine($"n1 = {n1} ++n1 = {++n1}");

            // Primeiro imprime e depois incrementa n2
            Console.WriteLine("\n\t Incremento como sufixo");
            Console.WriteLine($"n2= {n2} n2++ = {n2++}");
            Console.WriteLine($"n2++= {n2}");
        }
    }
}
