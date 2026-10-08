using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace CadastroDeVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;

            do
            {
                Console.Clear();
                ExibirMenu();
                string? entrada = Console.ReadLine();
                if (int.TryParse(entrada, out menu))
                {
                    switch (menu)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        default:
                            Console.WriteLine("Digite Valores Entre (1 - 7)");
                            Console.Write("Pressione qualquer para continuar...");
                            Console.ReadKey();                       
                            continue;
                    }
                }
                else
                {
                    Console.WriteLine("Digite um Valor Valido!!!");
                    Console.Write("Pressione qualquer para continuar...");
                    Console.ReadKey();
                }
            } while (menu != 7);
            /*
            var veiculo = new Veiculo(Marcas.Honda, "City Sedan", 2002, 105550m, 10000);
            // Calcular Preço do Carro
            bool status = true;
            int anoAtual;
            decimal valor = 0;

            while(status == true)
            {
                Console.Write("Digite Ano Atual: ");
                string entrada = Console.ReadLine();
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
            Console.WriteLine($"{valor: F2}");
            */
        }

        public static void ExibirMenu()
        {
            Console.WriteLine("=== SISTEMA DE VEICULOS ===");
            Console.WriteLine("1.Cadastrar Veículo");
            Console.WriteLine("2.Listar Veículo");
            Console.WriteLine("3.Consultar Veículo");
            Console.WriteLine("4.Alterar Preço");
            Console.WriteLine("5.Situação do Veiculo");
            Console.WriteLine("6.Excluir Veículo");
            Console.WriteLine("7.Sair");
            Console.WriteLine("Escolha uma Opção: ");
        }


    }
}
