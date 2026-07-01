using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeFuncionarios
{
    public class FuncionarioEstagiario : Funcionarios
    {
        public double bolsaAuxilio {  get; set; }
        public double valeTransporte { get; set; }

        public override double CalcularSalario()
        {
            return bolsaAuxilio + valeTransporte;
        }

        public FuncionarioEstagiario(string nome, string cpf, string tipo)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
        }
        public override void ExibirDados()
        {
            Console.WriteLine("=== Estágiario ===");
            Console.WriteLine($"nome {Nome}");
            Console.WriteLine($"Cpf: {Cpf}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Salário líquido: {CalcularSalario():F2}");
        }
    }
}
