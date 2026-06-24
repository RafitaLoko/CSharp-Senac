using System.Net.WebSockets;

namespace lacosDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("---------Exemplo FOR---------");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Numero {i}");

            //}

            //Console.WriteLine("");
            //Console.WriteLine("---- Exemplo do WHILE ----");
            //int contador = 1;
            //while (contador <= 10)
            //{
            //    Console.WriteLine($"Contador {contador}");
            //    contador++;
            //}
            //Console.WriteLine();

            //Console.WriteLine("---- Exemplo do DO WHILE ----");
            //int contadorDoWhile = 1;
            //do
            //{
            //    Console.WriteLine($"ContadorDoWhile {contadorDoWhile}");
            //    contadorDoWhile++;
            //} while (contadorDoWhile <= 15);

            Console.WriteLine("");
            Console.WriteLine("---- Exemplo FOREACH ----");
            string[] frutas = {"Maça", "banana", "Laranja", "Uva", "Pera" };

            foreach (string fruta in frutas)
            {
                Console.WriteLine($"Fruta: {fruta}");
            }
            Console.WriteLine("");

            Console.WriteLine("---- Exemplo BREAK e CONTINUE ----");

            for (int i = 0; i < 10; i++)
            {
                if ( i == 3)
                {
                    continue;
                }

                if (i == 8)
                {
                    break;
                }

                Console.WriteLine($"i: {i}");
            }



        }
    }
}
