namespace OrientacaoAObjeto
{
    public class Pedido
    {
        public Pessoa Cliente { get; set; }

        public IList<string> Produto { get; set; }

        public double ValorTotal { get; set; }

        public DateTime DataDoServico { get; set; }

        public bool IsPago { get; set; }

        public string Observacao { get; set; }
    }
}
