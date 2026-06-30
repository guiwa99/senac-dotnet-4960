namespace NumeroEhImparOuPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber se é impar ou par");
            string numeroInput = Console.ReadLine();

            try
            {
                int numero = int.Parse(numeroInput);

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"O número {numero} é par");
                }
                else
                {
                    Console.WriteLine($"O número {numero} é impar");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("O número digitado está inválido. Digite somente valores numéricos");
            }
        }
    }
}
