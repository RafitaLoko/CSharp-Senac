using System.ComponentModel.Design;

namespace CadastroDeAlunos
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            IList<string> Alunos = new List<string>();

            int opcao = 0;

            while (opcao != 4)
            {
               
                Console.WriteLine("\n ==== Cadastro de alunos ====");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Remover aluno");
                Console.WriteLine("3 - Listar aluno");
                Console.WriteLine("4 - Encerrar Programa.");
                Console.WriteLine("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção invalida");
                    continue;
                }

                switch (opcao)
                {
                    case 1:


                        Aluno a = new Alunos();

                        Console.Write("Nome: ");
                        a.Nome = Console.ReadLine();

                        Console.Write("CPF: ");
                        a.Cpf = Console.ReadLine();

                        if (alunos.Exists(x => x.Cpf == a.Cpf))
                        {
                            Console.WriteLine("Cpf já cadastrado!");
                            break;
                        }

                        Console.Write("Data de Nascimento: ");

                        a.DataNascimento = DateTime.Parse(Console.ReadLine());

                        Alunos.Add(a);
                        break;





                        Console.WriteLine("Aluno cadastrado com sucesso");

                        break;

                    case 2:
                        Console.WriteLine("Digite o nome do aluno que deseja remover");
                        string remover = Console.ReadLine();



                        if (Alunos.Remove(remover))
                        {
                            Console.WriteLine("Aluno removido com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado");
                        }
                        break;
                        Console.Write("Cpf: ");
                        string cpf = Console.ReadLine();

                        Alunos.Remove(Alunos.Find(x => x.Cpf == cpf));
                        break;

                    case 3:
                        Console.WriteLine("\n === Lista de Alunos ===");
                        if (Alunos.Count == 0)
                        {
                            Console.WriteLine("Nenhum aluno cadastrado");
                        }
                        else
                        {
                            foreach (string aluno in Alunos)
                            {
                                Console.WriteLine(aluno);
                            }
                        }
                        break;

                        foreach (alunos aluno in alunos)
                            Console.WriteLine($"{aluno.Nome} | {aluno.Cpf} | {aluno.Idade()} anos ");
                        break;

                    case 4:
                        Console.WriteLine("Programa Encerrado");
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                
                }

                
                }



            }



            
        }
        

    }

