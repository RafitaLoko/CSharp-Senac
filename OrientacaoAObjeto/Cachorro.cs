

namespace OrientacaoAObjeto
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, DateTime dataDeNscimento, double peso, string raca, bool adestrado)

        {
            Nome = nome;
            DataDeNascimento = dataDeNscimento;
            Peso = peso;
            Raca = raca;
            Adestrado = adestrado;
        }








        public string Raca { get; private set; }

        public bool Adestrado { get; set; }


        public override void SeComunicar()
        {
            Console.WriteLine($"Au au!");

        }

        public void Caminhar()
        {
            Console.WriteLine("Cachorro caminhando ...");
        }
       
        
    }



    
}
