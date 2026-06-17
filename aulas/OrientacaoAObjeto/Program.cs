using System;

namespace OrientacaoAObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa(
                "Guilherme", 
                new DateTime(1999, 6, 17), 
                1.75, 
                "03990095012", 
                true);

            Console.WriteLine("Informações da Pessoa 1");
            Console.WriteLine($"Nome {pessoa1.Nome}");
            Console.WriteLine($"Data de Nascimento {pessoa1.DataDeNascimento}");
            Console.WriteLine($"Altura {pessoa1.Altura}");
            Console.WriteLine($"Cpf {pessoa1.Cpf}");
            Console.WriteLine($"Está ativo {pessoa1.IsAtivo}");
            pessoa1.SeComunicar();

            Console.WriteLine($"Novo nome pessoa 1 {pessoa1.Nome}");

            Pessoa pessoa2 = new Pessoa(
                "Douglas",
                new DateTime(1996, 11, 20),
                1.77,
                "03890096031",
                true);

            Console.WriteLine("Informações da Pessoa 2");
            Console.WriteLine($"Nome {pessoa2.Nome}");
            Console.WriteLine($"Data de Nascimento {pessoa2.DataDeNascimento}");
            Console.WriteLine($"Altura {pessoa2.Altura}");
            Console.WriteLine($"Cpf {pessoa2.Cpf}");
            Console.WriteLine($"Está ativo {pessoa2.IsAtivo}");

            pessoa2.SeComunicar();

            Cachorro junior = new Cachorro("Junior", 0.2, false, new DateTime(2016, 10, 10), "Pinscher");

            Console.WriteLine("Informações do cachorro Junior");
            Console.WriteLine($"Nome {junior.Nome}");
            Console.WriteLine($"Data de nascimento {junior.DataDeNascimento}");
            Console.WriteLine($"Raca {junior.Raca}");
            junior.SeComunicar();

            Pedido pedido = new Pedido(pessoa1, DateTime.Now);

            pedido.ValorTotal = 100.99;
            pedido.Observacao = "Cliente vai buscar cachorro às 15:00h";

            Console.WriteLine("Informações do pedido");
            Console.WriteLine($"Cliente {pedido.Cliente.Nome}");
            Console.WriteLine($"Observação do pedido {pedido.Observacao}");

            Console.WriteLine("Criação do pedido 2");
            var pedido2 = new Pedido(pessoa2, DateTime.Now, 199.90, "Sem observação");

            Console.WriteLine("Informações do pedido 2");
            Console.WriteLine($"Cliente {pedido2.Cliente.Nome}");
            Console.WriteLine($"Observação do pedido {pedido2.Observacao}");
        }
    }
}
