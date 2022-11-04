using System;
using System.Collections.Concurrent;

namespace Exercícios_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atividade 1
            // Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna.
            // Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            /*
            int i, j;
            int[,] A = new int[5, 3];

            for (i = 0; i < 5; i++)
            {// laço que percorre as linhas da matriz
                for (j = 0; j < 3; j++)
                {// laço que percorre as colunas da matriz
                    if (j == 0)
                    {
                        Console.WriteLine("Digite o elemento A[" + i + ", " + j + "]");
                        A[i, j] = int.Parse(Console.ReadLine());
                    }

                    if (j == 1)
                    {
                        A[i, j] = A[i, 0] + 10; 
                    }

                    if (j == 2)
                    {
                        A[i, j] = A[i, 0] * 2;
                    }
                }

            // Mostrar
            for (i = 0; i < 3; i++)
            {// laço que percorre as linhas da matriz
                for (j = 0; j < 3; j++)
                {// laço que percorre as colunas da matriz
                    Console.WriteLine("A[" + i + ", " + j + "] = " + A[i, j]);
                }
            }
            */

            // Forma mais fácil

            /*
            int i, j;
            int[,] matriz = new int[5, 3];

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um número:");
                matriz[i, 0] = int.Parse(Console.ReadLine());
                matriz[i, 1] = matriz[i, 0] + 10;
                matriz[i, 2] = matriz[i, 0] * 2;

                Console.WriteLine(matriz[i, 0] + " / " + matriz[i,1] + " / " + matriz[i, 2]);
            }
            */



            // Atividade 2
            // Solicite ao usuário, preencher uma Matriz 3x3

            //Informe ao usuário:
            //*A soma dos elementos de cada linha

            // -Ex: Linha 1: 30

            //Linha 2: 17
            //* A soma dos elementos de cada coluna

            //-Ex: Coluna 1: 23

            //Coluna 2: 36


            /*
            int i, j;
            int[,] matriz = new int[3, 3];
            int lin1 = 0;
            int lin2 = 0;
            int lin3 = 0;
            int col1 = 0;
            int col2 = 0;
            int col3 = 0;

            for (i = 0; i < 3; i++)
            {// Percorrer as linhas
                for (j = 0; j < 3; j++)
                {// Percorre as colunas
                    Console.WriteLine("Digite um valor pra linha " + i + " e coluna " + j);
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (i == 0)
                    {
                        lin1 += matriz[i, j];
                    }

                    if (i == 1)
                    {
                        lin2 += matriz[i, j];
                    }

                    if (i == 2)
                    {
                        lin3 += matriz[i, j];
                    }

                    if (j == 0)
                    {
                        col1 += matriz[i, j];
                    }

                    if (j == 1)
                    {
                        col2 += matriz[i, j];
                    }

                    if (j == 2)
                    {
                        col3 += matriz[i, j];
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("************* Linhas *************");
            Console.WriteLine("Linha 1 = " + lin1);
            Console.WriteLine("Linha 2 = " + lin2);
            Console.WriteLine("Linha 3 = " + lin3);

            Console.WriteLine("************* Colunas *************");
            Console.WriteLine("Coluna 1 = " + col1);
            Console.WriteLine("Coluna 2 = " + col2);
            Console.WriteLine("Coluna 3 = " + col3);
            */


            // Atividade 3
            // Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            /*
            int i, j;
            int[,] matriz = new int[4, 4];

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite o elemento pra linha " + i + " e coluna " + j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Matriz[" + i + ", " + j + "] = " + matriz[i, j]);
                    }
                }
            }
            */


            // Atividade 4
            // Popule uma matriz 5x5 e informe:
            // -Quantos números são pares
            // - Quantos números são impares
            // - Quantos números são positivos
            // - Quantos números são negativos
            // - Quantos zeros existem!

            /*
            int i, j;
            int[,] matriz = new int[5, 5];
            int par = 0;
            int impar = 0;
            int nulo = 0;
            int positivo = 0;
            int negativo = 0;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite o elemento pra linha " + i + " e coluna " + j);
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] % 2 == 0)
                    {
                        par = par + 1;
                    }

                    if (matriz[i, j] % 2 == 1)
                    {
                        impar = impar + 1;
                    }

                    if (matriz[i, j] > 0)
                    {
                        positivo = positivo + 1;
                    }

                    if (matriz[i, j] < 0)
                    {
                        negativo = negativo + 1;
                    }

                    if (matriz[i, j] == 0)
                    {
                        nulo = nulo + 1;
                    }
                }
            }

            Console.WriteLine("Exitem " + par + " números pares");
            Console.WriteLine("Exitem " + impar + " números impares");
            Console.WriteLine("Exitem " + positivo + " números positivos");
            Console.WriteLine("Exitem " + negativo + " números negativos");
            Console.WriteLine("Exitem " + nulo + " números zeros");
            */


            // Atividade 5
            // Leia duas matrizes 2x3 de números double. 
            // Imprima a soma destas duas matrizes.

            /*
            int i, j, a, b;
            double[,] matriz1 = new double[2, 3];
            double[,] matriz2 = new double[2, 3];
            double soma1 = 0;
            double soma2 = 0;

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite o elemento pra linha " + i + " e coluna " + j + " da Matriz1");
                    matriz1[i, j] = double.Parse(Console.ReadLine());

                    soma1 += matriz1[i, j];
                }
            }

            for (a = 0; a < 2; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    Console.WriteLine("Digite o elemento pra linha " + a + " e coluna " + b + " da Matriz2");
                    matriz1[a, b] = double.Parse(Console.ReadLine());

                    soma2 += matriz1[a, b];
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("A soma da Matriz1 (" + soma1 + ") com a Matriz2 (" + soma2 + ") é = " + (soma1 + soma2));
            */


            // Atividade 6
            // Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
            // Random random = new Random();
            // int randomNumber = random.Next(0, 100);
            /*

            Random random = new Random();
            int i, j;
            int[,] M = new int[4, 4];

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    int randomNumber = random.Next(0, 9);
                    M[i, j] = randomNumber;
                }
            }

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            // Declarar o primeiro número como se fosse o maior!
            int num = M[0, 0];

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (M[i, j] > num)
                    {
                        num = M[i, j];
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("O maior número da Matriz M é: " + num);
            */



            // Atividade 7
            // Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            /*
            Random random = new Random();
            int i, j, a, b, x, y;
            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] C = new int[3, 3];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    int randomNumber = random.Next(0, 20);
                    A[i, j] = randomNumber;
                }
            }

            Console.WriteLine("Matriz A");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("\n");


            Console.WriteLine("Matriz B");
            for (a = 0; a < 3; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    int randomNumber = random.Next(0, 20);
                    B[a, b] = randomNumber;
                }
            }


            for (a = 0; a < 3; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    Console.Write(B[a, b] + " ");
                }
                Console.WriteLine(" ");
            }




            Console.WriteLine("\n");


            Console.WriteLine("Matriz C");
            for (x = 0; x < 3; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    C[x, y] = (A[x, y] - B[x, y]);
                }
            }

            for (x = 0; x < 3; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    Console.Write(C[x, y] + " ");
                }
                Console.WriteLine(" ");
            }
            */





            // Atividade 8
            // Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            /*

            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite um valor para linha " + i + " e coluna " + j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Matriz direta:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Matriz inversa:");
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            */



            // Atividade 9
            // Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
            // Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

            /*
            Random random = new Random();
            int[,] matriz = new int[3, 3];
            int variavel;
            int cont = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int randomNumber = random.Next(0, 20);
                    matriz[i, j] = randomNumber;
                }
            }


            Console.WriteLine("Digite um número de 0 a 20 para ver se está na matriz!");
            variavel = int.Parse(Console.ReadLine());


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (variavel == matriz[i, j])
                    {
                        cont++;
                    }
                }
            }

            if (cont != 0)
            {
                Console.WriteLine("O número existe no vetor " + cont + " vezes!");
            }

            else
            {
                Console.WriteLine("Número inexistente");
            }


            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            */


            // Atividade 10
            // Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

            /*
            int media;
            int somaA = 0;
            int somaB = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            Random random = new Random();
            int[,] A = new int[4, 4];
            int[,] B = new int[4, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int randomNumber = random.Next(0, 20);
                    A[i, j] = randomNumber;
                    somaA += A[i, j];
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int randomNumber = random.Next(0, 20);
                    B[i, j] = randomNumber;
                    somaB += B[i, j];
                }
            }

            // Média
            media = (somaA + somaB) / 18;


            // Aparecer Matrizes:

            // Matriz A

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


            // Matriz B

            Console.WriteLine("\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


            // Descobrir quantos estão acima, abaixo ou na média
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (A[i, j] > media || B[i, j] > media)
                    {
                        count1++;
                    }

                    if (A[i, j] < media || B[i, j] < media)
                    {
                        count2++;
                    }

                    if (A[i, j] == media || B[i, j] == media)
                    {
                        count3 ++;
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("A média é igual a " + media);
            Console.WriteLine("Existem " + count1 + " acima da média!");
            Console.WriteLine("Existem " + count2 + " abaixo da média!");
            Console.WriteLine("Existem " + count3 + " na média!");
            */


            // Atividade 11
            // Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

            /*
            Random random = new Random();
            double[,] A = new double[3, 3];
            double[,] resultante = new double[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int randomNumber = random.Next(0, 20);
                    A[i, j] = randomNumber;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("\n");
            // Matriz resultante
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultante[i, j] = A[i, j] / (i+j);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Math.Round(resultante[i, j], 2) + " ");
                }
                Console.WriteLine(" ");
            }
            */



            // Atividade 12
            // Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

            /*
            Random random = new Random();
            int[,] matriz = new int[4, 3];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int randomNumber = random.Next(0, 20);
                    matriz[i, j] = randomNumber;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
            */


            // Atividade 13
            // Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal
            // principal é igual a soma dos elementos da diagonal secundária.

            /*
            Random random = new Random();
            int[,] matriz = new int[5, 5];
            int principal = 0;
            int secundaria = 0;


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int randomNumber = random.Next(0, 20);
                    matriz[i, j] = randomNumber;
                }
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        principal += matriz[i, j];
                    }

                    if ((i+j) == 4)
                    {
                        secundaria += matriz[i, j];
                    }

                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("\n");
            if (principal == secundaria)
            {
                Console.WriteLine("A soma dos elementos da diagonal principal (" + principal + ") é IGUAL da diagonal secundária (" + secundaria + ")");
            }

            else
            {
                Console.WriteLine("A soma dos elementos da diagonal principal (" + principal + ") é DIFERENTE da diagonal secundária (" + secundaria + ")");
            }
            */



            // Atividade 14
            // Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita)
            // são os mesmos da diagonal secundária (direita pra esquerda).


            /*
            Random random = new Random();
            int[,] matriz = new int[5, 5];
            int[] principal = new int[5];
            int[] secundaria = new int[5];
            int cont = 0;


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int randomNumber = random.Next(0, 10);
                    matriz[i, j] = randomNumber;
                }
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


            Console.Write("\nApresentando os elementos da diagonal principal ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        principal[i] = matriz[i, j];
                        Console.Write(principal[i]);
                    }
                }
            }


            Console.Write("\nApresentando os elementos da diagonal secundária ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) == 4)
                    {
                        secundaria[i] = matriz[i, j];
                        Console.Write(secundaria[i]);
                    }
                }
            }

            Console.WriteLine("\n");
            for (int i = 0; i < 5; i++)
            {
                if (principal[i] == secundaria[i])
                {
                    cont++;
                }

                else
                {
                    Console.WriteLine("A diagonal principal NÃO é igual a secundária!");
                    break;
                }

                if (cont == 5)
                {
                    Console.WriteLine("A diagonal principal é igual a secundária!");
                }
            }
            */


            // Atividade 15
            // Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

            /*
            Random random = new Random();
            int[,] A = new int[4, 4];
            int[,] B = new int[4, 4];
            int[,] C = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int randomNumber = random.Next(0, 10);
                    A[i, j] = randomNumber;
                }
            }

            Console.WriteLine("Matriz A \n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine(" ");
            }



            Console.WriteLine("\nMatriz B \n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int randomNumber = random.Next(0, 10);
                    B[i, j] = randomNumber;
                }
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("\nMatriz C: \n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            */




            // Atividade 16
            // Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

            /*
            Random random = new Random();
            int[,] matriz = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int randomNumber = random.Next(0, 10);
                    matriz[i, j] = randomNumber;
                }
            }

            Console.WriteLine("Matriz direta \n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("\nMatriz inversa \n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[j, i] + " ");
                }
                Console.WriteLine(" ");
            }
            */



            // Atividade 17
            // Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax,
            // ou seja,o menor elemento da linha onde se encontra o maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.

            Random random = new Random();
            int[,] matriz = new int[10, 10];
            int linha = 0, coluna = 0;
            

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int randomNumber = random.Next(0, 35);
                    matriz[i, j] = randomNumber;
                }
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            // Declarar o primeiro número como se fosse o maior!
            int num = matriz[0, 0];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] > num)
                    {
                        num = matriz[i, j];
                        linha = i;
                        coluna = j;
                    }
                }
            }


            // Menor número
            int menor = matriz[linha, 0];
            for (int j = 0; j < 10; j++)
            {
                if (matriz[linha, j] < menor)
                {
                    menor = matriz[linha, j];
                    coluna = j;
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine($"O número minimax da matriz é: {menor}, presente na linha {linha + 1} e coluna {coluna + 1}.");








        }
    }
}