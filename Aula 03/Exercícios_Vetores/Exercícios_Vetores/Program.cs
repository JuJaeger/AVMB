using System;
using System.Runtime.Intrinsics.X86;

namespace Exercícios_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atividade 1
            // Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.
            /*

            Random random = new Random();
            int[] vetor = new int[10];
            int par = 0;
            int impar = 0;


            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 10);
                vetor[i] = randomNumber;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetor[i]);

                if (vetor[i] % 2 == 0)
                {
                    par++;
                }

                if (vetor[i] % 2 == 1)
                {
                    impar++;
                }
            }


            Console.WriteLine($"\n\nNo vetor tem {par} números pares e {impar} números impares!");
            */




            // Atividade 2
            // Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição,
            // armazenando o resultado em um outro vetor.
            /*

            Random random = new Random();
            int[] A = new int[20];
            int[] B = new int[20];
            int[] C = new int[20];

            Console.WriteLine("Vetor A: \n");
            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(0, 15);
                A[i] = randomNumber;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write(A[i]);
            }

            Console.WriteLine("\nVetor B: \n");
            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(0, 15);
                B[i] = randomNumber;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write(B[i]);
            }


            Console.WriteLine("\nVetor C: \n");

            for (int i = 0; i < 20; i++)
            {
                C[i] = A[i] + B[i];
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write(C[i]);
            }
            */




            // Atividade 3
            // Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

            /*
            Random random = new Random();
            int[] vetor = new int[20];
            int cont = 0;

            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(0, 15);
                vetor[i] = randomNumber;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write(vetor[i]);
            }


            Console.WriteLine("\n");
            for (int i = 0; i < 20; i++)
            {
                for (int j = 1; j < 20; j++)
                {
                    if (vetor[i] % j == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2)
                {
                    Console.WriteLine($"O número {vetor[i]} é primo.");
                }

                cont = 0;
            }
            */




            // Atividade 4
            // Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor.
            // Mostre o vetor resultante.

            /*
            Random random = new Random();
            int[] A = new int[20];
            int[] B = new int[20];
            int[] C = new int[20];

            Console.WriteLine("Vetor A:");
            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(0, 15);
                A[i] = randomNumber;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write(A[i]);
            }

            Console.WriteLine("\n\nVetor B:");
            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(0, 15);
                B[i] = randomNumber;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write(B[i]);
            }


            Console.WriteLine("\n\nVetor C:");

            for (int i = 0; i < 20; i++)
            {
                C[i] = A[i] * B[i];
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write(C[i]);
            }
            */




            // Atividade 5
            // Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

            /*
            Random random = new Random();
            int[] vetor = new int[80];
            int posição = 0;

            for (int i = 0; i < 80; i++)
            {
                int randomNumber = random.Next(0, 30);
                vetor[i] = randomNumber;
            }

            for (int i = 0; i < 80; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            int min = vetor[0];

            for (int i = 0; i < 80; i++)
            {
                if (vetor[i] < min)
                {
                    min = vetor[i];
                    posição = i;
                }
            }

            Console.WriteLine($"\n\nO menor valor do vetor é {min} e está presente na posição {posição}");
            */



            // Atividade 6
            // Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura.

            /*
            Random random = new Random();
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 9);
                vetor[i] = randomNumber;
            }

            Console.WriteLine("Ordem normal:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetor[i] + " ");
            }


            Console.WriteLine("\n\nOrdem inversa:");
            for (int i = 9; i > 0; i--)
            {
                Console.Write(vetor[i] + " ");
            }
            */



            // Atividade 7
            // Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares.

            /*
            Random random = new Random();
            int[] vetor = new int[10];


            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 9);
                vetor[i] = randomNumber;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetor[i]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write($"| {vetor[i]} |");
                }
            }


            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 1)
                {
                    Console.Write($"| {vetor[i]} |");
                }
            }
            */



            // Atividade 8
            // Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor.

            /*
            Random random = new Random();
            int[] vetor = new int[30];


            for (int i = 0; i < 30; i++)
            {
                int randomNumber = random.Next(-10, 15);
                vetor[i] = randomNumber;
            }

            for (int i = 0; i < 30; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Posição dos valores menores que zero:");

            for (int i = 0; i < 30; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.Write($"| {i + 1} |");
                }
            }
            */



            // Atividade 9
            // Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor.

            /*
            Random random = new Random();
            int[] vetor = new int[10];
            int[] auxiliar = new int[10];



            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 15);
                vetor[i] = randomNumber;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }

            Console.WriteLine("\n");

            int aux = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //verifica se a valor atual é menor que o próximo valor
                    if (vetor[j + 1] < vetor[j])
                    {
                        //inverte-se o valor caso a condição acima seja verdadeira
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Oredem Crescente");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }


            Console.WriteLine("\n");
            int aux2 = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //verifica se a valor atual é menor que o próximo valor
                    if (vetor[j + 1] > vetor[j])
                    {
                        //inverte-se o valor caso a condição acima seja verdadeira
                        aux2 = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux2;
                    }
                }
            }

            Console.WriteLine("Oredem Decrescente");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }
            */




            // atividade 10
            // Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

            /*
            Random random = new Random();
            int[] vetor = new int[20];



            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(0, 15);
                vetor[i] = randomNumber;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 20; i++)
            {
                if (vetor[i] == 0)
                {
                    vetor[i] = 2;
                }
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }
            */



            // Atividade 11
            // Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

            /*
            Random random = new Random();
            int[] vetor = new int[5];



            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(0, 9);
                vetor[i] = randomNumber;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }

            Console.WriteLine("\n");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write($"| {vetor[i]} |");
            }
            */



            // Atividade 12
            // Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor.
            // Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

            /*
            Random random = new Random();
            int[] vetor = new int[10];
            int var;
            int cont = 0;



            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 15);
                vetor[i] = randomNumber;
            }

            Console.WriteLine("Digite um número de 0 a 15:");
            var = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }

            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                if (var == vetor[i])
                {
                    cont++;
                    Console.Write($"O número digitado é encontrado na posição {i + 1}");
                }
            }

            Console.WriteLine("\n\n");
            if (cont == 0)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }
            */




            // Atividade 13
            // Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8.
            // O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.

            /*
            int[] vetor = new int[100];
            int dois = 0, quatro = 0, oito = 0;
            int parada = 0;


            Console.WriteLine("Digite -1 para sair!");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Digite um valor pra posição " + i);
                vetor[i] = int.Parse(Console.ReadLine());

                
                if (i == 100 || vetor[i] == -1)
                {
                    parada = i;
                    break;
                }

                if (vetor[i] == 2)
                {
                    dois++;
                }

                if (vetor[i] == 4)
                {
                    quatro++;
                }

                if (vetor[i] == 8)
                {
                    oito++;
                }
            }


            Console.WriteLine("\n");
            for (int i = 0; i < parada; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }

            Console.WriteLine("\n");

            Console.WriteLine($"Existem {dois} números 2, {quatro} números 4 e {oito} números 8!");
            */




            // Atividade 14
            // Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero, termine o algoritmo.
            // Se o código for 1, mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

           /*
            int[] vetor = new int[50];
            int escolha, parada = 0;


            Console.WriteLine("Digite 0, para parar!");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Digite um valor pra posição " + i);
                vetor[i] = int.Parse(Console.ReadLine());
                parada = i;

                if (vetor[i] == 0)
                {
                    parada = i;
                    break;
                }
            }


            Console.WriteLine("\nDigite 1 para mostrar o vetor na ordem escrita e 2 para a inversa.");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (escolha == 1)
            {
                for (int i = 0; i < parada + 1; i++)
                {
                    Console.Write("| " + vetor[i] + " |");
                }
            }


            if (escolha == 2)
            {
                for (int i = parada; i >= 0; i--)
                {
                    Console.Write("| " + vetor[i] + " |");
                }
            }

            if (escolha > 2 || escolha < 1)
            {
                Console.WriteLine("Valor inválido!");
            }
            */
            




            // Atividade 15
            // Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem.
            // Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo.
            // Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

            /*
            Random random = new Random();
            int[] vetor = new int[20];
            int[] inversa = new int[20];



            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(-10, 10);
                vetor[i] = randomNumber;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }

            Console.WriteLine("\n");

            for (int i = 19; i >= 0; i--)
            {
                inversa[i] = vetor[i];
                Console.Write("| " + inversa[i] + "| ");
            }
            */




            // Atividade 16
            // Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
            // •	A união de X com Y
            // •	A diferença entre X e Y
            // •	A interseção entre X e Y
            // Escreva o vetor resultado de cada uma das operações.

            /*
            Random random = new Random();
            int[] Y = new int[10];
            int[] X = new int[10];
            int[] soma = new int[10];
            int[] subtração = new int[10];
            int[] interseção = new int[10];
            int cont = 0, certo = 0;



            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(-10, 10);
                X[i] = randomNumber;
            }

            Console.WriteLine("Matriz X");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("|" + X[i] + "|");
            }



            Console.WriteLine("\n\nMatriz Y");
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(-10, 10);
                Y[i] = randomNumber;
            }


            for (int i = 0; i < 10; i++)
            {
                Console.Write("|" + Y[i] + "|");
            }


            Console.WriteLine("\n\nMatriz Soma");
            for (int i = 0; i < 10; i++)
            {
                soma[i] = X[i] + Y[i];
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("|" + soma[i] + "|");
            }




            Console.WriteLine("\n\nMatriz Subtração");
            for (int i = 0; i < 10; i++)
            {
                subtração[i] = X[i] - Y[i];
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("|" + subtração[i] + "|");
            }



            Console.WriteLine("\n\nMatriz Interseção");
            for (int i = 0; i < 10; i++)
            {
                if (X[i] == Y[i])
                {
                    interseção[i] = X[i];
                    certo++;
                    Console.Write("|" + interseção[i] + "| posição = " + (i + 1) + "; ");
                }

                else
                {
                    cont++;
                }
            }

            if (cont != 0 && certo == 0)
            {
                Console.WriteLine("Não existe interseção!");
            }
            */

















        }
    }
}