namespace CadastroDeAlunos
{
    public class Alunos
    {
        public string Nome {  get; protected set; }

      public DateTime DataNascimento { get; protected set; }

        public string Cpf { get; protected set; }

        public int Idade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now < DataNascimento.AddYears(idade))
                idade--;
            return idade;

        }
        
    }
}
