using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.Banco.Repositories
{
    public class DependenteRepository
    {
        public void Cadastrar(Dependente dependente)
        {
            string sql = @"INSERT INTO Dependente
            (Nome, DataDeNascimento, Parentesco, IdFuncionario)
            VALUES
            (@Nome, @DataDeNascimento, @Parentesco, @IdFuncionario)";
            // Conexao com o banco

            SqlCommand.Parameters.AddWithValue();
            
        }





    }
}
