using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.Modelos
{
    public class Dependente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Parentesco {  get; set; }

        public int IdFuncionario { get; set; }


    }
}
