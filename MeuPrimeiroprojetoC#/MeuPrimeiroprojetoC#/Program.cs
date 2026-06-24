namespace MeuPrimeiroprojetoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Meu nome é Rafael");

            int idade = 19;
            

            string nome = "Rafael";
            

            string sobrenome = "de Carvalho Wendland";
            

            double altura = 1.83;
            

            char letra = 'a';
            Console.WriteLine(letra);

            bool ehProfessor = false;


            //Console.WriteLine($"Meu nome é {nome} {sobrenome}. ");
            //Console.WriteLine($"tenho {idade} anos de idade.");
            //Console.WriteLine($"Sou professor: {ehProfessor}.");
            //Console.WriteLine($"tenho {altura} de altura.");


            string nomeCompleto = ObterNomeCompleto(nome, sobrenome);
            Console.WriteLine($"Meu nome é {nomeCompleto}");
        }
        static string ObterNomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }
        public static void ExibirSeEhProfessorEAltura(bool ehprofessor, double altura)
        {
            Console.WriteLine($"Sou Professor: {ehprofessor}.");
            Console.WriteLine($"Tenho {altura} de altura.");
        }
    }
}
