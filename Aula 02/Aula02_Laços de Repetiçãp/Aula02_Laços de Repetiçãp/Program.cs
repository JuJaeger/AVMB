namespace Aula02_Laços_de_Repetiçãp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            int inicio, fim;

            Console.WriteLine("Digite um número pro início e pro fim:");
            inicio = int.Parse(Console.ReadLine());
            fim = int.Parse(Console.ReadLine());

            if (inicio < fim)
            {
                for (int i = inicio; i <= fim; i++)
                {
                    Console.WriteLine(i);
                }
            }

            else
            {
                for (int i = fim; i <= inicio; i++)
                {
                    Console.WriteLine(i);
                }
            }
            */


            // Exercío 2
            /*

            int x;

            Console.WriteLine("Digite um número inteiro");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 100; i = i + x)
            {
                Console.WriteLine(i);
            }
            */


            // Exercício 3

            /*
            int i, op;
            for ( i = 0; true; i++)
            {
                Console.WriteLine("Que Continuar?  /n Digite 0 para sair!");
                op = int.Parse(Console.ReadLine());
                if (op == 0)
                {
                    Console.WriteLine("Obrigado pela presença neste lindo laço de repetição!");
                    break;
                }
            }
            */

            // Exercício 4

            /*

            int i, op;
            for (i = 0; true; i++)
            {
                Console.WriteLine("digite sua opção:");
                op = int.Parse(Console.ReadLine());
                if (op > 4 || op < 1)
                {
                    Console.WriteLine("Digite um valor entre 1 e 4!!! \n");
                    continue;
                }
                else
                {
                    Console.WriteLine("Opção " + op + " escolhida!");
                    break;

                }
            }

            switch (op)
             {
                case 1:
                    Console.WriteLine("Primeira Opção");
                    break;

                case 2:
                    Console.WriteLine("Segunda Opção");
                    break;

                case 3:
                    Console.WriteLine("Terceira Opção");
                    break;

                case 4:
                    Console.WriteLine("Quarta Opção");
                    break;
             }
            */

            // Exercício 5

            /*
            float i, n;
            double media = 0, nota;
            Console.WriteLine("Cálculo da média de notas da turma em uma avaliação /n");
            Console.WriteLine("Quantos alunos realizaram a avaliação? ");
            n = float.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite a nota do aluno " + i);
                nota = float.Parse(Console.ReadLine());
                media += nota;
            }
            media = media / n;
            Console.WriteLine($"\n A média final da turma é " + media);
            */


            // Exercício 6
            /*
            int i, j;
            for (i = 0; i < 20; i ++)
            {
                Console.WriteLine("i: " + i);
                for (j = 0; j < 10; j++)
                {
                    Console.WriteLine("    j: " + j);
                }
            }
            */


            // Exercício 7

            int i, j, k;
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("i: " + i);
                for (j = 0; j < 10; j++)
                {
                    Console.WriteLine("    j: " + j);
                    for (k = 0; k < 15; k++)
                    {
                        Console.WriteLine("                 k: " + k);
                    }
                }
            }
        }
    }
}