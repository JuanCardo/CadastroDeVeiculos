namespace CadastroDeVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            var veiculo = new Veiculo(Marcas.Honda, "City Sedan", 2002, 105.550m, 10000);

            veiculo.ExibirInformacoes();
        }
    }
}
