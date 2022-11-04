namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 7, y = 10;

            // Soma
            float soma = (x + y);
            Console.WriteLine("O resultado da soma é " + soma);

            // Subtração
            float subtracao = (x - y);
            Console.WriteLine("O resultado da subtração é " + subtracao);

            // Multiplicação
            float multiplicacao = (x * y);
            Console.WriteLine("Oresultado da multipliacação é " + multiplicacao);

            // Divisão
            float divisao = (x / y);
            Console.WriteLine("O resultado da divisão é " + divisao + "\n");


            // Área do Retângulo

            float h = 10, b = 5;
            float area_retangulo = (b * h);   




            Console.WriteLine("A área do retângulo é = " + area_retangulo + "\n");

            // Área do triângulo equilátero

            float area_triangulo = ((b * h) / 2);

            Console.WriteLine("A área do triângulo equilátero é = " + area_triangulo + "\n");


            // Área de um círculo com raio digitado por usuário

            double pi = 3.14;
            float raio;

            Console.WriteLine("Digite um valor para o raio:");
            raio = float.Parse(Console.ReadLine());

            Console.WriteLine("A área do círculo é = " + (pi * (raio * raio)) + "\n");

            // Ano que a pessoa nasceu

            int idade;

            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            int ano_nascimento = 2022 - idade;

            Console.WriteLine("Você nasceu em: " + ano_nascimento);
        }
    }
}