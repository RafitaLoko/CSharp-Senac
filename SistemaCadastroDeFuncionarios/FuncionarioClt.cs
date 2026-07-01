using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeFuncionarios
{
    public class FuncionarioClt : Funcionarios
    {
        public double SalarioBase { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase;
        }

        public FuncionarioClt(string nome, string cpf, string tipo)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
        }

        public override void ExibirDados()
        {
            Console.WriteLine("=== Dados do Funcionário ===");
            Console.WriteLine($"nome {Nome}");
            Console.WriteLine($"Cpf: {Cpf}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Salário líquido: {CalcularSalario():F2}");
        }
    }
}
