namespace Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                StreamWriter sw = new StreamWriter("C:\\arquivo\\teste.txt"); // Passa o caminho do arquivo e o nome do arquivo para o Construtor StreamWriter
                sw.WriteLine("Estou escrevendo um texto aqui..."); // Escreve uma linha de texto no StreamWriter
                sw.WriteLine("E posso ter uma segunda linha!"); // Escreve outra linha de texto no StreamWriter
                sw.Close();
            */

            string line;
            try
            {
                // Passa o caminho do arquivo e o nome do arquivo para i construtor StreamReader
                StreamReader sr = new StreamReader("C:\\arquivo\\teste.txt");
                line = sr.ReadLine(); // Lê a primeira linha do arquivo

                while (line != null) // Continua lendo enquanto não encontra o final do arquivo
                {
                    Console.WriteLine(line); // Apresenta a linha lida no Console
                    line = sr.ReadLine(); // E efetua a leitura da próxima linha do arquivo
                }
                sr.Close(); // Fecha o arquivo
                Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }

            finally
            {
                Console.WriteLine("Executando o bloco finally");
            }



        }
    }
}