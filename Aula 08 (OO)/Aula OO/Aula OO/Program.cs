namespace Aula_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agora, partiu testar a classe lampada!");
            Lampada l1 = new Lampada();
            l1.potencia = 200;
            Console.WriteLine(l1.potencia);
            Console.WriteLine(l1.ligada);
            l1.ligar();
            Console.WriteLine(l1.ligada);
            l1.ligar();
            Console.WriteLine(l1.ligada);
            l1.desligar();
            Console.WriteLine(l1.ligada);
            l1.desligar();
            Console.WriteLine(l1.ligada);
        }
    }
}