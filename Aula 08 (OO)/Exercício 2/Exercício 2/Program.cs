namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro();

            Console.WriteLine("Autor:");
            l1.autor = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Editora:");
            l1.editora = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Genero:");
            l1.genero = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("paginas:");
            l1.paginas = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Cor das páginas:");
            l1.cor_pagina = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Capítulos:");
            l1.capitulos = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Autor: " + l1.autor);
            Console.WriteLine("Editora: " + l1.editora);
            Console.WriteLine("Gênero: " + l1.genero);
            Console.WriteLine("Páginas: " + l1.paginas);
            Console.WriteLine("Cor das páginas: " + l1.cor_pagina);
            Console.WriteLine("Número de Cápitulos: " + l1.capitulos);
        }
    }
}