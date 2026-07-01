namespace SistemaCadastroDeFuncionarios
{
    public class Program 
    {
        static void Main(string[] args)
        {
           List<Funcionarios> funcionarios = new List<Funcionarios>();

            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n === Sistema de RH ===");

                Console.WriteLine("1 - Cadastrar Funcionario");
                Console.WriteLine("2 - Listar Funcionarios");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                   case 1:
                        Console.WriteLine("\n Tipo de funcionamento");
                        Console.WriteLine("1 - Clt");
                        Console.WriteLine("2 - Estagiário");
                        Console.WriteLine("3 - Terceirizado");
                        Console.WriteLine("Escolha: ");

                        int tipo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Cpf: ");
                        string cpf = Console.ReadLine();

                        if (tipo == 1)
                        {
                            try
                            {
                                Console.WriteLine("Salário Base: ");
                                double salario = double.Parse(Console.ReadLine());

                                var f = new FuncionarioClt(nome, cpf, "Clt");
                                f.SalarioBase = salario;

                                funcionarios.Add(f);
                                Console.WriteLine("Funcionário cadastrado! ");






                            }
                            catch
                            {
                                Console.WriteLine("Valor Inválido. ");
                            }
                        }
                        else if (tipo == 2)
                        {
                            try
                            {
                                Console.WriteLine("Bolsa Auxilio");
                                double bolsa = double.Parse(Console.ReadLine());


                                Console.WriteLine("Vale transporte: ");
                                double vt = double.Parse(Console.ReadLine());

                                var f = new FuncionarioEstagiario(nome, cpf, "Estagiario");
                                f.bolsaAuxilio = bolsa;
                                f.valeTransporte = vt;

                                funcionarios.Add(f);

                                Console.WriteLine("Funcionario Cadastrado!");

                            }
                            catch { Console.WriteLine("Valor invalido!"); }

                        }
                        else if (tipo == 3)
                        {
                            try
                            {
                                Console.WriteLine("Horas trabalhadas: ");

                                double horas = double.Parse(Console.ReadLine());

                                Console.WriteLine("Valor da hora: ");

                                double valor = double.Parse(Console.ReadLine());

                                var f = new FuncionarioTerceirizado(nome, cpf, "Terceirizado");
                                f.HorasTrabalhadas = horas;
                                f.ValorHora = valor;

                                funcionarios.Add(f);
                                Console.WriteLine("Funcionario CAdastrado!");


                            }
                            catch { Console.WriteLine("Valor invalido. "); }


                        }
                            break;

                            case 2:
                                Console.WriteLine("\n ==== Lista de funcionarios ==== ");

                                if (funcionarios.Count == 0)
                                {
                                    Console.WriteLine("Nenhum Funcionario cadastrado");
                                }
                                else
                                {
                                    foreach (var f in funcionarios)
                                    {
                                        f.ExibirDados();

                                        Console.WriteLine("-------------------");

                                    }
                                }
                                break;

                                case 3:
                                Console.WriteLine("Sistema encerrado. ");
                                break;

                            default:
                                Console.WriteLine("Opção invalido.");
                                break;
                        }


                        
                    

                   
            }
        }
    }
}
