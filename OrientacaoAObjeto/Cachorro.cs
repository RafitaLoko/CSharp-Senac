

namespace OrientacaoAObjeto
{
    internal class Cachorro
    {
        public Cachorro(string nome, DateTime dataDeNscimento, double peso, string raca, bool adestrado ) 
        
        {
            Nome = nome;
            DataDeNascimento = dataDeNscimento;
            Peso = peso;
            Raca = raca;
            Adestrado = adestrado;
        }



        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }

        public double Peso { get; set; }

        public string Raca { get; private set; }

        public bool Adestrado { get; set; }
    }
}
