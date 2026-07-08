namespace GerenciamentoDeFuncionarios.Modelos
{
    public class Funcionario
    {
        public Funcionario(string nome, 
            string email, 
            char sexo, string 
            tipoDeContrato, 
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

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public char Sexo { get; private set; }

        public string TipoDeContrato { get; private set; }

        public decimal Salario { get; private set; }

        public DateTime DataDeCadastro { get; private set; }

        public DateTime? DataDeAtualizacao { get; set; }
    }
}
