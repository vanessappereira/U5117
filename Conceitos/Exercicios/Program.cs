namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ConverterSegundos();
            Frutaria();
            ParOuImpar();
            PositivoOuNegativo(); 
            Tabuada();
            TrocarValor();
            MediaPondNotaAluno(); */
        }

        public static void ConverterSegundos()
        {
            int duracao;

            Console.Write("\nDuração do evento em segundos: ");
            duracao = int.Parse(Console.ReadLine());

            versao1(duracao);
            versao2(duracao);
        }

        public static void versao1(int duracao)
        {
            int h, m, s, aux;

            s = duracao % 60;
            aux = duracao / 60;
            m = aux % 60;
            h = aux / 60;

            Console.WriteLine($"\nDuração V1: {duracao} segundos " +
                $"\n\tHoras {h}, minutos {m}, segundos {s}");
        }

        public static void versao2(int duracao)
        {
            int h, m, s;
            s = duracao % 60;
            m = (duracao / 60) % 60;
            h = (duracao / 60) / 60;

            Console.WriteLine($"\nDuração V2: {duracao} segundos " +
                $"\n\tHoras {h}, minutos {m}, segundos {s}");
        }

        public static void Frutaria()
        {
            double PRECOKG_BANANAS = 0.99, PRECOEMB_UVAS = 2.99, PERCENTPOUP = 0.1;
            double qtdBananas, faturacao, poupanca;
            int qtdUvas;

            Console.Write("\nQuantidade de Bananas (kg):  ");
            qtdBananas = float.Parse(Console.ReadLine());

            Console.Write("\nQuantidade de uvas (embalagens):  ");
            qtdUvas = int.Parse(Console.ReadLine());

            // Processamento
            faturacao = qtdBananas * PRECOKG_BANANAS + qtdUvas * PRECOEMB_UVAS;
            poupanca = faturacao * PERCENTPOUP;

            // reconhecer carateres não ASCII
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine($"\nFaturou: {faturacao.ToString("C2")}" +
                                $"\tPoupança: {poupanca.ToString("C2")}");

            Console.WriteLine($"\nFaturou: {faturacao:0.00} €\tPoupança: {poupanca:0.00} €");
        }

        public static void ParOuImpar()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
        }

        public static void PositivoOuNegativo()
        {
        inicio:
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine($"Resultado: {numero / 2}");
            }
            else
            {
                Console.WriteLine($"Resultado: {Math.Pow(numero, 2)}");
            }
            goto inicio;
        }

        public static void Tabuada()
        {
            byte num, contadorWhile = 1, contadorDoWhile = 1, contadorFor;

            // Ler e validar o número
            while (true)
            {
                Console.WriteLine("Digite um número para ver a tabuada: (max: 255) ");
                if (byte.TryParse(Console.ReadLine(), out num) && num != 0)
                    break;
                else
                    Console.WriteLine("Número inválido! Digite apenas inteiros positivos.");
            }
            Console.WriteLine($"Tabuada do {num}:");

            // Tabuada com loop while
            Console.WriteLine("________ Tabuada loop While ________");

            while (contadorWhile <= 10)
            {
                Console.WriteLine($"{num} x {contadorWhile} = {num * contadorWhile}");
                contadorWhile++;
            }

            // Tabuada com do while
            Console.WriteLine("\n________ Tabuada loop Do While ________");

            do
            {
                Console.WriteLine($"{num} x {contadorDoWhile} = {num * contadorDoWhile}");
                contadorDoWhile++;
            } while (contadorDoWhile <= 10);

            // Tabuada com for
            Console.WriteLine("\n________ Tabuada loop For ________");
            Console.WriteLine($"Tabuada do {num} em ordem crescente:");

            for (contadorFor = 1; contadorFor <= 10; contadorFor++)
            {
                Console.WriteLine($"{num} x {contadorFor} = {num * contadorFor}");
            }

            Console.WriteLine($"\nTabuada do {num} em ordem crescente:");
            for (contadorFor = 10; contadorFor >= 1; contadorFor--)
            {
                Console.WriteLine($"{num} x {contadorFor} = {num * contadorFor}");
            }
        }

        public static void TrocarValor()
        {
            ushort num1, num2, soma = 0, aux;

            // Ler e validar o número
            while (true)
            {
                Console.Write("Digite o primeiro valor: ");
                if (ushort.TryParse(Console.ReadLine(), out num1) && num1 > 0)
                    break;
                else
                    Console.WriteLine("Número inválido! Digite apenas inteiros positivos.");
            }

            while (true)
            {
                Console.Write("Digite o segundo valor: ");
                if (ushort.TryParse(Console.ReadLine(), out num2) && num2 > 0)
                    break;
                else
                    Console.WriteLine("Número inválido! Digite apenas inteiros positivos.");
            }

            // Trocar os valores 
            if (num1 > num2)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            }
            // Somar os valores
            for (ushort i = num1; i <= num2; i++)
            {
                soma += i;
            }
            Console.WriteLine($"\nA soma dos números no intervalo de {num1} a {num2} é: {soma}");
        }

        public static void MediaPondNotaAluno()
        {
            // Declaração de variáveis
            double notaMin = 0, notaMax = 20, nota1, nota2, nota3, media;
            int codigo;

            Console.Write("Digite o código do aluno: ");
            codigo = int.Parse(Console.ReadLine());

            // Entrada da nota 1 (validando entre 0 e 20)
            do
            {
                Console.Write("Digite a nota 1 (0 a 20): ");
                nota1 = double.Parse(Console.ReadLine());
            } while (nota1 < notaMin || nota1 > notaMax);

            // Entrada da nota 2 (validando entre 0 e 20)
            do
            {
                Console.Write("Digite a nota 2 (0 a 20): ");
                nota2 = double.Parse(Console.ReadLine());
            } while (nota2 < notaMin || nota2 > notaMax);

            // Entrada da nota 3 (validando entre 0 e 20)
            do
            {
                Console.Write("Digite a nota 3 (0 a 20): ");
                nota3 = double.Parse(Console.ReadLine());
            } while (nota3 < notaMin || nota3 > notaMax);

            // Verificar qual é a maior nota e calcular a média ponderada
            if (nota1 > nota2 && nota1 > nota3)
                media = (nota1 * 4 + (nota2 + nota3) * 3) / 10;
            else if (nota2 > nota3)
                media = (nota2 * 4 + (nota1 + nota3) * 3) / 10;
            else
                media = (nota3 * 4 + (nota1 + nota2) * 3) / 10;


            // Exibir resultado da classificação do aluno
            if (media >= 10)
                Console.WriteLine($"Aluno nº {codigo} APROVADO com {media:F2} valores.");
            else
                Console.WriteLine($"Aluno nº {codigo} REPROVADO com {media:F2} valores.");
            /*
            Formadora:
                float nota;
            
                for (int i = 1; i < 4; i++){
                    while (true){
                        Console.WriteLine($"Digite a nota {i}: (0 a 20):   ");                
                        if (nota = float.TryParse(Console.ReadLine(), out nota) && nota >= notaMin && nota <= notaMax)
                            break;
                        else
                            Console.WriteLine($"Nota {i} inválida! Digite apenas valores entre 0 e 20.");
                    } //End while

                    float n = (i == 1) ? nota1 = nota : (i == 2) ? nota2 = nota : nota3 = nota;
                } //End for

                 // Exibir resultado da classificação do aluno
                 if (media >= 10)
                     Console.WriteLine($"Aluno nº {codigo} APROVADO com {media:F2} valores.");
                 else
                     Console.WriteLine($"Aluno nº {codigo} REPROVADO com {media:F2} valores.");            
             */
        }
    }
}
