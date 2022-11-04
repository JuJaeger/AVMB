namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positivo!");
            }

            else if (num < 0)
            {
                Console.WriteLine("Negativo!");
            }

            else
            {
                Console.WriteLine("Zero!");
            }

            // ***************************


        }
    }
}