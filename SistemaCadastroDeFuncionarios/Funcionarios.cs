using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeFuncionarios
{
    public class Funcionarios 
    {
        public string Nome {  get; protected set; }
        public string Cpf { get; protected set; }
            public string Tipo { get; set; }

       public virtual double CalcularSalario()
        {
            return 0;
        }
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cpf: {Cpf}");
            Console.WriteLine($"Tipo: {Tipo}");
        }
    
    }
}
