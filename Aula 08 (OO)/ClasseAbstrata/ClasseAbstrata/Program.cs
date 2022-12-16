namespace ClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro cao = new Cachorro();
            Gato gato = new Gato();
            cao.treinar();
            gato.treinar();
        }
    }
}