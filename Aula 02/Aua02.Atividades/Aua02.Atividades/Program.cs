using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Aua02.Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atividade 01

            //1 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
            /*
            int a, b, c, d;

            int count = 0;

            Console.WriteLine("Digite o 1° número inteiro");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° número inteiro");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3° número inteiro");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 4° número inteiro");
            d = int.Parse(Console.ReadLine());

            float media = (a + b + c + d) / 4f;

            Console.WriteLine("A média é = " + media);

            if (a > media)
            {
                Console.WriteLine("Sou maior que a média: " + a);
            }
            else
            {
                count++;
            }

            if (b > media)
            {
                Console.WriteLine("Sou maior que a média: " + b);
            }
            else
            {
                count++;
            }

            if (c > media)
            {
                Console.WriteLine("Sou maior que a média: " + c);
            }
            else
            {
                count++;
            }

            if (d > media)
            {
                Console.WriteLine("Sou maior que a média: " + d);
            }
            else
            {
                count++;
            }

            if (count == 4)
            {
                Console.WriteLine("Sem valores maiores que a média");
            }
            */

            // Atividade 02

            // Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.

            /*
            int prof_01, prof_02;
            float salario01, salario02;

            Console.WriteLine("Prof 01, quantas horas vc trabalha?");
            prof_01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Prof 01, quanto vc ganha por hora?");
            salario01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Prof 02, quantas horas vc trabalha?");
            prof_02 = int.Parse(Console.ReadLine());

            Console.WriteLine("Prof 02, quanto vc ganha por hora?");
            salario02 = int.Parse(Console.ReadLine());

            float resultado01 = salario01 * prof_01;
            float resultado02 = salario02 * prof_02;

            float sal_mensal01 = resultado01 * 20;
            float sal_mensal02 = resultado02 * 20;

            Console.WriteLine("O salário por hora do 1° prof é = " + resultado01 + " e o o salário do 2° prof é = " + resultado02);
            Console.WriteLine("O salário mensal do 1° prof é = " + sal_mensal01 + " e o o salário do 2° prof é = " + sal_mensal02);

            if(sal_mensal01 > sal_mensal02)
            {
                Console.WriteLine("O 1° prof recebe mais!");
            }

            if (sal_mensal01 < sal_mensal02)
            {
                Console.WriteLine("O 2° prof recebe mais!");
            }
            */

            //Atividade 3

            //Escreva um programa que pede para o usuário digitar um valor entre 1 e 12, e então mostre na tela o mês correspondente. Caso o usuário digite um valor fora do intervalo, mostre uma mensagem indicando que é um mês inválido.

            /*
            int n;

            Console.WriteLine("Digite um número de 1 a 12:");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("O mês equivalente é Janeiro");
            }

            if (n == 2)
            {
                Console.WriteLine("O mês equivalente é Feveiro");
            }

            if (n == 3)
            {
                Console.WriteLine("O mês equivalente é Março");
            }

            if (n == 4)
            {
                Console.WriteLine("O mês equivalente é Abril");
            }

            if (n == 5)
            {
                Console.WriteLine("O mês equivalente é Maio");
            }

            if (n == 6)
            {
                Console.WriteLine("O mês equivalente é Junho");
            }

            if (n == 7)
            {
                Console.WriteLine("O mês equivalente é Julho");
            }

            if (n == 8)
            {
                Console.WriteLine("O mês equivalente é Agosto");
            }

            if (n == 9)
            {
                Console.WriteLine("O mês equivalente é Setembro");
            }

            if (n == 10)
            {
                Console.WriteLine("O mês equivalente é Outubro");
            }

            if (n == 11)
            {
                Console.WriteLine("O mês equivalente é Novembro");
            }

            if (n == 12)
            {
                Console.WriteLine("O mês equivalente é Dezembro");
            }

            if (n > 12 || n <= 0)
            {
                Console.WriteLine("Seu número é invalido!");
            }
            */


            // Atividade 4

            // Escreva um programa que leia um valor entre 0 e 9, e então escreva na tela o mesmo na forma literal.
            // Pergunte também se o usuário quer saber a forma literal em português, inglês ou espanhol.

            /*
            int num, idioma = 0;

            Console.WriteLine("Digite um número de 0 a 9:");
            num = int.Parse(Console.ReadLine());


            if (num == 0)
            {
                Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                idioma = int.Parse(Console.ReadLine());

                if (idioma == 1)
                {
                    Console.WriteLine("zero");
                }

                if (idioma == 2)
                {
                    Console.WriteLine("cero");
                }

                if (idioma == 3)
                {
                    Console.WriteLine("zero");
                }
            }

            if (num == 1)
            {
                Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                idioma = int.Parse(Console.ReadLine());

                if (idioma == 1)
                {
                    Console.WriteLine("one");
                }

                if (idioma == 2)
                {
                    Console.WriteLine("uno");
                }

                if (idioma == 3)
                {
                    Console.WriteLine("um");
                }
            }

            if (num == 2)
            {
                Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                idioma = int.Parse(Console.ReadLine());

                if (idioma == 1)
                {
                    Console.WriteLine("two");
                }

                if (idioma == 2)
                {
                    Console.WriteLine("dos");
                }

                if (idioma == 3)
                {
                    Console.WriteLine("dois");
                }
            }

            if (num == 3)
            {
                Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                idioma = int.Parse(Console.ReadLine());

                if (idioma == 1)
                {
                    Console.WriteLine("three");
                }

                if (idioma == 2)
                {
                    Console.WriteLine("tres");
                }

                if (idioma == 3)
                {
                    Console.WriteLine("três");
                }
            }

            if (num == 4)
            {
                Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                idioma = int.Parse(Console.ReadLine());

                if (idioma == 1)
                {
                    Console.WriteLine("for");
                }

                if (idioma == 2)
                {
                    Console.WriteLine("cuatro");
                }

                if (idioma == 3)
                {
                    Console.WriteLine("quatro");
                }
            }

            if (num == 5)
            {
                Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                idioma = int.Parse(Console.ReadLine());

                if (idioma == 1)
                {
                    Console.WriteLine("five");
                }

                if (idioma == 2)
                {
                    Console.WriteLine("cinco");
                }

                if (idioma == 3)
                {
                    Console.WriteLine("cinco");
                }
            }

            if (num == 6)
            {
                Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                idioma = int.Parse(Console.ReadLine());

                if (idioma == 1)
                {
                    Console.WriteLine("six");
                }

                if (idioma == 2)
                {
                    Console.WriteLine("seis");
                }

                if (idioma == 3)
                {
                    Console.WriteLine("seis");
                }
            }

            if (num == 7)
            {
                Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                idioma = int.Parse(Console.ReadLine());

                if (idioma == 1)
                {
                    Console.WriteLine("seven");
                }

                if (idioma == 2)
                {
                    Console.WriteLine("siete");
                }

                if (idioma == 3)
                {
                    Console.WriteLine("sete");
                }
            }

            if (num == 8)
            {
                Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                idioma = int.Parse(Console.ReadLine());

                if (idioma == 1)
                {
                    Console.WriteLine("eight");
                }

                if (idioma == 2)
                {
                    Console.WriteLine("ocho");
                }

                if (idioma == 3)
                {
                    Console.WriteLine("oito");
                }

                if (num == 9)
                {
                    Console.WriteLine("Quer ver o número em inglês(1), espanhol(2) ou português(3)?");
                    idioma = int.Parse(Console.ReadLine());

                    if (idioma == 1)
                    {
                        Console.WriteLine("nine");
                    }

                    if (idioma == 2)
                    {
                        Console.WriteLine("nueve");
                    }

                    if (idioma == 3)
                    {
                        Console.WriteLine("nove");
                    }
                }
            }
            */


            //Atividade 5 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //Escreva um programa que peça para o usuário digitar uma letra, e então o programa imprime na tela se a letra é uma vogal ou consoante.
            //Utilize no máximo 6 cases em um switch-case para resolver esse exercício. 


            /*
            char i;

            Console.WriteLine("Digite uma letra");
            i = char.Parse(Console.ReadLine());

            switch (i)
            {
                case 'a':
                    Console.WriteLine("É Vogal");
                    break;
                case 'e':
                    Console.WriteLine("É Vogal");
                    break;
                case 'i':
                    Console.WriteLine("É Vogal");
                    break;
                case 'o':
                    Console.WriteLine("É Vogal");
                    break;
                case 'u':
                    Console.WriteLine("É Vogal");
                    break;
                default:
                    Console.WriteLine("É uma consoante");
                    break;
            }
            */


            /*
            char letra;

            Console.WriteLine("Digite uma letra");
            letra = char.Parse(Console.ReadLine());

            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine("A letra " + letra + " é uma vogal");
            }

            else
            {
                Console.WriteLine("A letra " + letra + " é uma consoante");
            }
            */


            // Atividade 6

            //Fazer uma algoritmo que leia valores para as variáveis hora, minuto e segundo;
            //verificando e escrevendo se elas correspondem a um horário válido ou não.
            //Para um horário ser válido, a hora deve estar no intervalo de 0 a 23, o minuto e o segundo no intervalo de 0 a 59.


            /*
            int hora, min, seg;

            Console.WriteLine("Digite um número para hora:");
            hora = int.Parse(Console.ReadLine());

            if (hora > 23 || hora < 0)
            {
                Console.WriteLine("Hora inválida");
            }

            else
            {
                Console.WriteLine(hora + " É válida");
            }

            Console.WriteLine("Digite um número para minuto:");
            min = int.Parse(Console.ReadLine());

            if (min > 59 || min < 0)
            {
                Console.WriteLine("Minuto inválido");
            }

            else
            {
                Console.WriteLine(min + " É válida");
            }

            Console.WriteLine("Digite um número para segundo:");
            seg = int.Parse(Console.ReadLine());

            if (seg > 59 || seg < 0)
            {
                Console.WriteLine("Segundo inválida");
            }

            else
            {
                Console.WriteLine(seg + " É válida /n");
            }
            */



            // Atividade 7

            // Escreva um algoritmo para pesquisa de renda per capita que leia o valor da renda familiar e o número de integrantes da família.
            // Calcule o valor da renda per capita da família.

            /*
            float renda, per_capita;
            int integrantes;

            Console.WriteLine("Qual o valor de renda de sua família?");
            renda = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantos integrantes existem na sua família?");
            integrantes = int.Parse(Console.ReadLine());

            per_capita = renda / integrantes;

            Console.WriteLine(" A renda Per Capita da sua família é = " + per_capita);

            */

            // Atividade 8

            //Um comerciante calcula o lucro da venda baseado no valor da compra dos clientes de acordo com os itens a seguir:

            //•	Valor da Compra < R$ 10,00  então o Lucro é de 70 %

            //•	R$ 10,00 ≤ Valor da Compra < R$ 30,00 então o Lucro é de 50 %

            //•	R$ 30,00 ≤ Valor da Compra < R$ 50,00 então o Lucro é de 40 %

            //•	Valor da Compra ≥ R$ 50,00 então o Lucro é de 30 %

            //Criar um algoritmo que leia o valor da compra e imprima uma mensagem indicando de quantos % é o lucro e o valor.

            /*
            float valor, lucro, total;

            Console.WriteLine("Qual o valor de sua compra?");
            valor = float.Parse(Console.ReadLine());

            if (valor < 10)
            {
                lucro = (float)(valor * 0.7);
                total = valor + lucro;
                Console.WriteLine("Seu lucro é de 70%, ou seja, seu lucro é: " + lucro + " E seu valor total é = " + total);
            }

            if (valor >= 10 && valor < 30)
            {
                lucro = (float)(valor * 0.5);
                total = valor + lucro;
                Console.WriteLine("Seu lucro é de 50%, ou seja, seu lucro é: " + lucro + " E seu valor total é = " + total);
            }

            if (valor >= 30 && valor < 50)
            {
                lucro = (float)(valor * 0.4);
                total = valor + lucro;
                Console.WriteLine("Seu lucro é de 40%, ou seja, seu lucro é: " + lucro + " E seu valor total é = " + total);
            }

            if (valor >= 50)
            {
                lucro = (float)(valor * 0.3);
                total = valor + lucro;
                Console.WriteLine("Seu lucro é de 30%, ou seja, seu lucro é: " + lucro + " E seu valor total é = " + total);
            }
            */



            // Atividade 9

            // Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo.
            // Para que os lados formem um triângulo, todos os lados devem ser menores a soma dos outros dois lados.
            // Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).

            /*
            float a, b, c;

            Console.WriteLine("Digite três valores pros lados do triângulo:");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                Console.WriteLine("Os lados podem formar um triângulo");

                if (a == b && b == c)
                {
                    Console.WriteLine("O triângulo é equilátero");
                }

                else if(a == b || b == c || a == c)
                {
                    Console.WriteLine("O tríângulo é isóceles");
                }

                if (a != b && b != c)
                {
                    Console.WriteLine("O triângulo é escaleno");
                }
            }

            else
            {
                Console.WriteLine("Os lados digitados não podem formar um triângulo");
            }
            */



            // Exercício 10

            // Faça um programa que leia um número e apresente a tabuada deste número.
            /*
            int l;

            Console.WriteLine("Digite um número");
            l = int.Parse(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(l + " x " + i + " = " + l*i);
            }
            */


            // Atividade 11
            // Escreva um programa em C que gera números entre 1000 e 1999 e mostra aqueles que divididos por 11 dão resto 5.

            /*
            int i, d;

            for (i = 1000; i <= 1999; i++)
            {
                if (i % 11 == 5)
                {
                    Console.WriteLine(i + " - Sou divisível por 11 com resto = 5 \n");
                }

                else
                {
                    Console.WriteLine(i + "\n");
                }
            }
            */


            // Atividade 12

            // Dado um limite inferior e superior, calcule a soma de todos os números pares contidos nesse intervalo.

            /*
            int i, inferior, superior, soma;

            soma = 0;

            Console.WriteLine("Digite um número para ser o infeiror:");
            inferior = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número para ser o superior:");
            superior = int.Parse(Console.ReadLine());

            for (i = inferior; i <= superior; i++)
            {
                if (i % 2 == 0)
                {
                     soma = soma+ i;
                }
            }
            Console.WriteLine("A soma de todos os números pares é = " + soma);
            */


            // Atividade 13

            // Escreva um algoritmo que pergunte ao usuário qual o valor inicial da contagem, qual o valor final,
            // e se ele deseja pular os valores pares ou os valores ímpares. Após, faça um laço de repetição que mostre os valores desejados.

            /*
            int i, inicial, final, pulo, par, impar;
            par = 0;
            impar = 0;

            Console.WriteLine("Digite o valor inicial da sua contagem");
            inicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor final da sua contagem");
            final = int.Parse(Console.ReadLine());

            Console.WriteLine("Você deseja pular os números pares (1), impares (2) ou nenhum (3)?");
            pulo = int.Parse(Console.ReadLine());
            Console.Write("\n");

            if (pulo == 1)
            {
                for (i = inicial; i <= final; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            if (pulo == 2)
            {
                for (i = inicial; i <= final; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            if (pulo == 3)
            {
                for (i = inicial; i <= final; i++)
                {
                    Console.WriteLine(i);
                }
            }
            */



            // Atividade 14
            // Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. Considere que Polegada = Centímetro * 2,54.

            /*
            float i, cm;

            for (i = 1; i <= 20; i++)
            {
                for (cm = 1; cm <= 20; cm++)
                {
                    i = (float)(cm * 2.54);
                    Console.WriteLine(cm + " x 2.54 = " + i);
                }
            }
            */

            // Atividade 15
            // Escreva um programa que pergunte para o usuário os valores iniciais e finais da contagem, e então mostre todos os valores desse intervalo.

            /*
            int i, inicial, final;

            Console.WriteLine("Digite um valor inicial");
            inicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor final");
            final = int.Parse(Console.ReadLine());

            Console.WriteLine('\n');

            for (i = inicial; i <= final; i++)
            {
                Console.WriteLine(i);
            }
            */


            // Atividade 16
            // Modifique a questão anterior de modo que seja perguntado para o usuário se ele quer que os números apareçam em ordem crescente ou decrescente.
            /*

            int i, n01, n02;
            string ordem;

            Console.WriteLine("Digite o primeiro número");
            n01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n02 = int.Parse(Console.ReadLine());

            Console.WriteLine("Você deseja que os valores apareçam em ordem crescente ou decrescente?");
            ordem = Console.ReadLine();

            if (n01 < n02)
            { 
                if (ordem == "crescente")
                {
                    for (i = n01; i <= n02; i++)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (ordem == "decrescente")
                {
                    for (i = n02; i >= n01; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            if (n01 > n02)
            {
                if (ordem == "crescente")
                {
                    for (i = n02; i <= n01; i++)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (ordem == "decrescente")
                {
                    for (i = n01; i >= n02; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            */

            // Atividade 17
            // Utilize o comando break no código abaixo de modo que o laço pare em 5.
            /*

            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Volta número: " + i);
                if (i == 5)
                {
                    break;
                }
            }
            */

            // Atividade 18
            // Utilize o comando continue de modo que as voltas de número 5 e 7 sejam puladas no código da questão anterior.
            /*

            int i;

            for (i = 0; i < 10; i++)
            {
                if (i == 5 || i == 7)
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Volta número: " + i);
                }
            }
            */

            // Atividade 19
            // Faça um algoritmo para calcular e mostrar o resultado dos 50 primeiros elementos da série
            // 1000/1   -   997/2   +   994/3   -   991/4   +   ...



            float dividendo = 1000, resultado = 0;

            for (int divisor = 1; divisor <= 50; divisor++)
            {
                if (divisor % 2 == 1)
                {
                    resultado += dividendo / divisor;
                }

                else
                {
                    resultado -= dividendo / divisor;
                }

                dividendo -= 3;
            }

            Console.WriteLine("O resultado da expressão é " + resultado);
            


            // Atividade 20
            // Faça um programa que leia um número n e imprima se ele é primo ou não. (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)

            /*
            int n, l;

            Console.WriteLine("Digite um número:");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(n + " não é primo!");
            }

            if (n % 2 =)
            {
                Console.WriteLine(n + " É !");
            }
            */
        }
    }
}