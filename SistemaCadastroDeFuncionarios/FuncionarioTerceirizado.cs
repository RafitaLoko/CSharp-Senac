namespace SistemaCadastroDeFuncionarios
{
    public class FuncionarioTerceirizado : Funcionarios
    {
        public double HorasTrabalhadas {  get; set; }
        public double ValorHora { get; set; }

        public FuncionarioTerceirizado(string nome, string cpf, string tipo)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
        }

        public override void ExibirDados()
        {
            
                Console.WriteLine("=== Terceirizado ===");
                Console.WriteLine($"nome {Nome}");
                Console.WriteLine($"Cpf: {Cpf}");
                Console.WriteLine($"Tipo: {Tipo}");
                Console.WriteLine($"Salário líquido: {CalcularSalario():F2}");
            
        }

    }
}
