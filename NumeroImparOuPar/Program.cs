namespace NumeroImparOuPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero Inteiro:");

            string Entrada = Console.ReadLine();
            try
            {

                if (int.TryParse(Entrada, out int numero))

                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("O numero é Par!");
                    }
                    else
                    {
                        Console.WriteLine("O numero é Impar!");
                    }


            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine("Erro: O numero é invaido! Digite apenas valores numéricos inteiros.");
                }
                Console.WriteLine("\n Pressione qualquer tecla para sair");
                Console.ReadLine();


            }
        }

    }
}
