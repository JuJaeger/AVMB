namespace Aula03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Digite 2 valores;");
            somar(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            int resultado = subtrair(8, 2);
            Console.WriteLine("Subtração resulta em " + resultado);
        }

        public static void somar(int a, int b)
        {
            Console.WriteLine("A soma é: " + (a + b));
        }

        public static int subtrair(int a, int b)
        {
            return a - b;
        }
         */


            /*

            double[] notas = new double[15];
            double media;
            int i;

            Console.WriteLine("---------- Leitura de Valores: ----------");
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite a nota do aluno " + i + ":");
                notas[i] = double.Parse(Console.ReadLine());
            }

            media = 0;
            Console.WriteLine("---------- Cálculo da media sendo feito: ----------");
            for (i = 0; i < 15; i++)
            {
                media += notas[i];
            }

            media = media / 15;

            Console.WriteLine("---------- Mostra a média: ----------");
            Console.WriteLine("A média de notas é igual " + media);
            */


            /*
            int[] vetor = new int[10];
            int i, maior;
            
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor " + i);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            maior = vetor[0];

            for (i = 1; i < 10; i++)
            {
                if (vetor[i] > maior);
            }

            Console.WriteLine("O maior valor do vetor é = " + maior);
            */


            /*
            int[] vetorA = new int[15], vetorB = new int[15];
            int i;

            Console.WriteLine("---------- Leitrura dos elementos A ----------");

            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o valor " + i);

                vetorA[i] = int.Parse(Console.ReadLine());

                if (vetorA[i] % 2 == 0)
                {
                    vetorB[i] = vetorA[i] * 5;
                }

                else
                {
                    vetorB[i] = vetorA[i] + 5;
                }
            }

            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("VetorB [" + i + "] = " + vetorB[i]);
            }
            */




            int i, j;
            int[,] A = new int[3, 4];

            for (i = 0; i < 3; i++)
            {// laço que percorre as linhas da matriz
                for (j = 0; j < 4; j++)
                {// laço que percorre as colunas da matriz
                    Console.WriteLine("Digite o elemento A[" + i + ", " + j + "]");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Mostrar
            for (i = 0; i < 3; i++)
            {// laço que percorre as linhas da matriz
                for (j = 0; j < 4; j++)
                {// laço que percorre as colunas da matriz
                    Console.WriteLine("A[" + i + ", " + j + "] = " + A[i, j]);
                }
            }


        }
    }
}