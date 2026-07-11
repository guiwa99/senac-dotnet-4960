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
                    VALUES (@Nome, @Email, @Salario, @Sexo, @TipoDeContrato, @DataDeCadastro, @DataDeAtualizacao);
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
                        DataDeAtualizacao
                    FROM 
                        Funcionario
                "
                );

            return funcionarios;
        }
    }
}
