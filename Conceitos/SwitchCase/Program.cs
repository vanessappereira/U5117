namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 4, n2 = 6;

            switch (n1 > n2)
            {
                case true: Console.WriteLine($"\n{n1} é maior"); break;
                case false:
                    switch (n2 > n1)
                    {
                        case true: Console.WriteLine($"\n{n2} é maior"); break;
                        case false: Console.WriteLine($"\n{n1} e {n2} são iguais"); break;
                    }
                    break;
            }
        }
    }
}
