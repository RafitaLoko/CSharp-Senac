using System.Security.Cryptography.X509Certificates;

namespace OrientacaoAObjeto
{
    internal class Program
    {
        private static object cw;

        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Rafael", new DateTime (2006, 8, 30), 1.83, "123123121231", true);
            


            Console.WriteLine("Informações de Pessoa 1");
            Console.WriteLine($"Nome: {pessoa1.Nome}");
            Console.WriteLine($"Data de Nascimento: {pessoa1.DataDeNascimento}");
            Console.WriteLine($"Altura: {pessoa1.Altura}");
            Console.WriteLine($"Cpf: {pessoa1.Cpf}");
            Console.WriteLine($"Está ativo: {pessoa1.IsAtivo}");
            pessoa1.SeComunicar();


            Console.WriteLine("");
            
            Console.WriteLine($"Novo nome da pessoa1 é: {pessoa1.Nome}");



            Pessoa pessoa2 = new Pessoa("Lucas ariel", new DateTime (2006, 6, 17), 1.78, "676767676767", true);
            


            Console.WriteLine("");
            Console.WriteLine("Informações de Pessoa 2");
            Console.WriteLine($"Nome: {pessoa2.Nome}");
            Console.WriteLine($"Idade: {pessoa2.DataDeNascimento}");
            Console.WriteLine($"Altura: {pessoa2.Altura}");
            Console.WriteLine($"Cpf: {pessoa2.Cpf}");
            Console.WriteLine($"Está ativo: {pessoa2.IsAtivo}");
            pessoa2.SeComunicar();


            Cachorro cachorro1 = new Cachorro("Scooby", new DateTime (2010, 4, 21), 15.4, "Labrador", true);


            Console.WriteLine("");
            Console.WriteLine($"Informações do Cachorro");
            Console.WriteLine($"Nome do cachorro: {cachorro1.Nome}");
            Console.WriteLine($"Data de nascimento: {cachorro1.DataDeNascimento}");
            Console.WriteLine($"Peso do cachorro: {cachorro1.Peso}");
            Console.WriteLine($"Raça do cachorro: {cachorro1.Raca}");
            Console.WriteLine($"É adestrado? {cachorro1.Adestrado}");




            Pedido pedido1 = new Pedido(pessoa1, 100.99, DateTime.Now, true);


            Console.WriteLine($"");
            Console.WriteLine($"Informações do Pedido");
            Console.WriteLine($"Nome do cliente: {pedido1.Cliente.Nome}");
            Console.WriteLine($"Valor do pedido: {pedido1.ValorTotal}");
            Console.WriteLine($"Data do pedido: {pedido1.DataDoServico}");
            Console.WriteLine($"O pedido foi pago: {pedido1.IsPago }");

            var pedido2 = new Pedido(pessoa2, DateTime.Now, 267.00, "Cliente vai buscar o cachorro as 15:00");

            Console.WriteLine($"");
            Console.WriteLine($"Informações do Pedido 2");
            Console.WriteLine($"Nome do cliente: {pedido2.Cliente.Nome}");
            Console.WriteLine($"Valor do pedido: {pedido2.ValorTotal}");
            Console.WriteLine($"Data do pedido: {pedido2.DataDoServico}");
            Console.WriteLine($"Observação: {pedido2.Observacao}");





        }


    }
}
