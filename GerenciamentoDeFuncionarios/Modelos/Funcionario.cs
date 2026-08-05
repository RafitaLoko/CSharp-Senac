using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeFuncionarios.Modelos
{
    public class Funcionario
    {
        public Funcionario(string nome,
            string email,
            char sexo,
            string tipoDeContrato,
            decimal salario,
            DateTime dataDeCadastro)
           
        {
            Nome = nome;
            Email = email;
            Sexo = sexo;
            TipoDeContrato = tipoDeContrato;
            Salario = salario;
            DataDeCadastro = dataDeCadastro;
            
        }

        public Funcionario(int id,
            string nome,
            string email,
            char sexo,
            string tipoDeContrato,
            decimal salario,
            DateTime dataDeCadastro,
            DateTime? dataDeAtualizacao,
            string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Sexo = sexo;
            TipoDeContrato = tipoDeContrato;
            Salario = salario;
            DataDeCadastro = dataDeCadastro;
            DataDeAtualizacao = dataDeAtualizacao;
            Senha = senha;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O campo 'Nome' deve tar entre 3 e 255 caracteres")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatório")]
        [EmailAddress(ErrorMessage = "O 'Email' é invalido")]

        public string Email { get; private set; }
        public char Sexo { get; private set; }
        public string TipoDeContrato { get; private set; }
        public decimal Salario { get; private set; }
        public DateTime DataDeCadastro { get; private set; }
        public DateTime? DataDeAtualizacao { get; set; }
        public string Senha { get; private set; }


        public void SetEmail(string email) { this.Email = email; }

        public void SetSalario (decimal salario) { this.Salario = salario; }

        public void SetNome(string nome) { this.Nome = nome; }

        public void SetSexo (char sexo) { this.Sexo = sexo; }

        public void SetTipoDeContrato (string tipoDeContrato) { this.TipoDeContrato = tipoDeContrato; }

        public void SetSenha (string senha) {  this.Senha = senha;}
        
    }
}
