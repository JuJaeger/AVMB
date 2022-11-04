namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Digite um número:");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine("O valor digitedo é " + valor);
                Console.WriteLine("50 dividido pelo valor resulta em " + (50/valor));
            }

            catch(FormatException ex)
            {
                Console.WriteLine("Digite apenas números!!");
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\n");
                Console.WriteLine("Comando opcional, executa sempre após um try ou após um catch.");
            }
        }
    }
}