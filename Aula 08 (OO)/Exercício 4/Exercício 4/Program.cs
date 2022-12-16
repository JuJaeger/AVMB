namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa l1 = new Pessoa();

            Console.WriteLine("Nome:");
            l1.nome = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Idade:");
            l1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Genero:");
            l1.genero = Console.ReadLine();

            Console.WriteLine("Nacionalidade:");
            l1.nacionalidade = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Profissão:");
            l1.profissao = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("CPF:");
            l1.cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Número de irmãos:");
            l1.n_irmaos = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Nome: " + l1.nome);
            Console.WriteLine("Idade: " + l1.idade);
            Console.WriteLine("Gênero: " + l1.genero);
            Console.WriteLine("Nacionalidade: " + l1.nacionalidade);
            Console.WriteLine("Profissão: " + l1.profissao);
            Console.WriteLine("CPF: " + l1.cpf);
            Console.WriteLine("Número de irmãos: " + l1.n_irmaos);
        }
    }
}