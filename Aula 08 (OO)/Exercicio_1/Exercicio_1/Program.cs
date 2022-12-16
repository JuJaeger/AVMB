namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agora, partiu testar a classe lampada!");
            Lampada l1 = new Lampada(); //Lampada() é o construtor
            Console.WriteLine(l1.ligada);

            l1.acesa();
            Console.WriteLine(l1.ligada + "acesa");

            l1.meia_luz();
            Console.WriteLine(l1.ligada + "meia-luz");

            l1.acesa();
            Console.WriteLine(l1.ligada + "acesa");

            l1.apagada();
            Console.WriteLine(l1.ligada + "apagada");
        }
    }
}