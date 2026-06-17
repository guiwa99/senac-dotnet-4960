namespace OrientacaoAObjeto
{
    public class Cachorro
    {
        public Cachorro(
            string nome, 
            double altura, 
            bool adestrado, 
            DateTime dataDeNascimento, 
            string raca)
        {
            Nome = nome;
            Altura = altura;
            Adestrado = adestrado;
            DataDeNascimento = dataDeNascimento;
            Raca = raca;
        }

        public string Nome { get; private set; }

        public string Raca { get; private set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        public DateTime DataDeNascimento { get; private set; }

        public bool Adestrado { get; set; }

        public bool IsVacinado { get; set; }

        public bool IsAtivo { get; set; }

        public void SeComunicar()
        {
            Console.WriteLine($"Au au");
        }

        public void Caminhar()
        {
            Console.WriteLine("Cachorro caminhando...");
        }

        public void FazerTruque(string truque)
        {
            Console.WriteLine($"Truque: {truque}");
        }
    }
}
