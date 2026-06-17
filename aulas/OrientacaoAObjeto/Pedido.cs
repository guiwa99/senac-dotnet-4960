namespace OrientacaoAObjeto
{
    public class Pedido
    {
        public Pedido(Pessoa cliente, DateTime dataDoServico)
        {
            Cliente = cliente;
            DataDoServico = dataDoServico;
        }

        public Pedido(
            Pessoa cliente, 
            DateTime dataDoServico, 
            double valorTotal, 
            string observacao)
        {
            Cliente = cliente;
            DataDoServico = dataDoServico;
            ValorTotal = valorTotal;
            Observacao = observacao;
        }

        public Pessoa Cliente { get; private set; }

        public IList<string> Produtos { get; set; }

        public double ValorTotal { get; set; }

        public DateTime DataDoServico { get; private set; }

        public bool IsPago { get; set; }

        public string Observacao { get; set; }
    }
}
