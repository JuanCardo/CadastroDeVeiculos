using System.Xml;

namespace CadastroDeVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            var veiculo = new Veiculo(Marcas.Honda, "City Sedan", 2002, 105550m, 10000);

            bool status = true;
            int anoAtual;
            decimal valor = 0;

            while(status == true)
            {
                Console.Write("Digite Ano Atual: ");
                string? entrada = Console.ReadLine();
                if (entrada?.Length == 4 && int.TryParse(entrada, out anoAtual))
                {
                    valor = veiculo.ValorVeiculo(anoAtual,veiculo.Preco,veiculo.Quilometragem);
                    status = false;
                }
                else
                {
                    Console.WriteLine("Digite um Ano Valido!!!");
                }
            }
            Console.WriteLine(valor);
        }
    }
}
