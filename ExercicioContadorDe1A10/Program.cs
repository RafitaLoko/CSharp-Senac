namespace ExercicioContadorDe1A10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Numero: {i}");

                double raiz = Math.Sqrt(i);

                Console.WriteLine($"A Raiz Quadrada de {i} é {raiz:F2}");
            }
           
            

        }
    }
}
