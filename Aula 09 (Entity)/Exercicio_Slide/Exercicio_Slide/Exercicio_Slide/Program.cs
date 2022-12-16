using EntityCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_Slide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:\n" +
                "1) Para criar um Aluno\n" +
                "2) Para alterar o nome do Aluno\n" +
                "3) Para inserir um Curso\n" +
                "4) Para excluir um Aluno\n" +
                "5) Para consultar Tuso\n" +
                "6) Para consultar pelo ID\n");

            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Inserir o nome do Aluno");
                        Aluno p = new Aluno();
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("\n");

                        Console.WriteLine("Informe um Curso:");
                        string emailTemp = Console.ReadLine();

                        p.Cursos = new List<Curso>()
                        {
                            new Curso()
                            {
                                curso = emailTemp
                            }
                        };

                        contexto.Alunos.Add(p);
                        contexto.SaveChanges();

                        Console.WriteLine("\n");
                        Console.WriteLine("Pessoa inserida com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;


                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID do Aluno:");
                        int id = int.Parse(Console.ReadLine());

                        Aluno pAlt = contexto.Alunos.Find(id);

                        Console.WriteLine("Informe o nome correto:");
                        pAlt.Nome = Console.ReadLine();

                        contexto.Alunos.Update(pAlt);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;


                case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID do Aluno:");
                        int id = int.Parse(Console.ReadLine());
                        Aluno p = contexto.Alunos.Find(id);

                        Console.WriteLine("Informe o novo Curso:");
                        string emailTemp = Console.ReadLine();

                        p.Cursos = new List<Curso>()
                        {
                            new Curso()
                            {
                                curso = emailTemp
                            }
                        };

                        contexto.Alunos.Update(p);
                        contexto.SaveChanges();
                        Console.WriteLine("\n");
                        Console.WriteLine("Inserido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;


                case 4:
                    try
                    {
                        Console.WriteLine("Informe o ID do Aluno");
                        int id = int.Parse(Console.ReadLine());
                        Aluno p = contexto.Alunos.Find(id);

                        Console.WriteLine("Confirmar a exclusão de " + p.Nome);
                        Console.WriteLine("E dos seus cursos:");

                        foreach (Curso item in p.Cursos)
                        {
                            Console.WriteLine("\t" + item.curso);
                        }

                        Console.WriteLine("1 para SIM e outra tecla para NÃO");

                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Alunos.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine("\n");
                            Console.WriteLine(p.Nome + " excluída com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;


                case 5:
                    try
                    {
                        List<Aluno> lista = (from Aluno p in contexto.Alunos select p).Include(pes => pes.Cursos).ToList<Aluno>();

                        foreach (Aluno item in lista)
                        {
                            Console.WriteLine(item.Nome);

                            foreach (Curso itemE in item.Cursos)
                            {
                                Console.WriteLine("\t" + itemE.curso);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;


                case 6:
                    try
                    {
                        Console.WriteLine("Informe o id do Aluno\n");
                        int idAluno = int.Parse(Console.ReadLine());
                        Aluno aluno = contexto.Alunos
                                .Include(p => p.Cursos)
                                .FirstOrDefault(x => x.Id == idAluno);
                        Console.WriteLine(aluno.Nome);

                        if (aluno.Cursos != null)
                        {
                            foreach (Curso item in aluno.Cursos)
                            {
                                Console.WriteLine("      " + item.curso);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
        }
    }
}