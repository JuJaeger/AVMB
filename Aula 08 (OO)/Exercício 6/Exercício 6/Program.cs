namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor l1 = new Motor();
            l1.associar("dhfd", 350, "fusca");
            Console.WriteLine(l1.retornar());
        }
    }
}