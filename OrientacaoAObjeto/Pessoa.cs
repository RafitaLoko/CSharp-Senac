using System.Security.Cryptography.X509Certificates;

namespace OrientacaoAObjeto
{
    public class Pessoa : Animal
    {
        public Pessoa(string nome, DateTime dataDeNascimento, double altura, string cpf, bool isAtivo  )
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Altura = altura;
            Cpf = cpf;
            IsAtivo = isAtivo;

        }




       

       

       

        public string Cpf { get; private set; }

        public string Rg { get; private set; }

        public string Telefone { get; set; }

        public string Email { get;  set; }

      

        public override void SeComunicar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        public void Caminhando()
        {
            Console.WriteLine($"Pessoa caminhando ");
        }
    }
}
