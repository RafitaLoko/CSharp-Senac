

using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using GerenciamentoDeFuncionarios.Modelos;

namespace GerenciamentoDeFuncionarios.Banco.Repositories
{
    public class FuncionarioRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();
        public static async Task Adicionar(Funcionario funcionario)
        {
            // conectar com o banco e inserir funcionario

            await ConexaoBanco.CriarConexao().QueryAsync(
                @"
                    INSERT INTO Funcionario (Nome, Email, Salario, Sexo, TipoDeContrato, DataDeCadastro, DataDeAtualizacao)
                    VALUES (@Nome, @Email, @Salario, @Sexo, @TipoDeContrato, @DataDeCadastro, @DataDeAtualizacao)
                ",
                 funcionario
                );
        }

        public static async Task<IEnumerable<Funcionario>> ObterTodos()
        {
            var funcionarios = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                @"
                    SELECT 
                        Id,
                        Nome,
                        Email,
                        Sexo,
                        TipoDeContrato,
                        Salario,
                        DataDeCadastro,
                        DataDeAtualizacao,
                        Senha
                    FROM
                        funcionario
                "
                );
            
            return funcionarios;
        }

        public static async Task DeletarPorId(int idFuncionario)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
              @"
                DELETE FROM Funcionario
                WHERE Id = @IdFuncionario
                ", 
              new
              {
                  IdFuncionario = idFuncionario 
              }
              );


        }

        public static async Task<Funcionario>ObterPorId(int idFuncionario)
        {
            var funcionario = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Funcionario>(
            
            @"
                SELECT 
                        Id,
                        Nome,
                        Email,
                        Sexo,
                        TipoDeContrato,
                        Salario,
                        DataDeCadastro,
                        DataDeAtualizacao,
                        Senha
                    FROM
                        funcionario
                    WHERE 
                        Id = @IdFuncionario"
            ,
            new
            {
                IdFuncionario = idFuncionario
            }
            );
            return funcionario;
        }

        public static async Task Editar(Funcionario funcionario)
        {
            await ConexaoBanco.CriarConexao().QueryAsync(
               @"
                    UPDATE Funcionario SET Nome = @Nome, Email = @Email, Salario = @Salario, Sexo = @Sexo, TipoDeContrato = @TipoDeContrato, DataDeCadastro = @DataDeCadastro, Senha = @Senha
                    
                   WHERE
                        Id = @Id
                ",
                funcionario);
            
        }

        public static async Task<List<Funcionario>>BuscarPorNomeOuEmail(string termo, string tipoContrato)
        {
           string sql = @"
                
                SELECT
                Id, Nome, Email, Sexo, TipoDeContrato, Salario, DataDeCadastro, DataDeAtualizacao, Senha
                FROM funcionario
                WHERE 
                Nome ILIKE @Termo OR Email ILIKE @Termo
                ";
                

            if (tipoContrato != "Todos")
            {
                sql += "AND TipoDeContrato = @TipoDeContrato";
            }
            var funcionarios = await ConexaoBanco.CriarConexao().QueryAsync<Funcionario>(
                sql,
                new { Termo = $"%{termo}%", TipoDeContrato = tipoContrato });
                
                
            return funcionarios.ToList();
                
                
        }
    }
}
