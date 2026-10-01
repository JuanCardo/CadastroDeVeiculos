namespace CadastroDeVeiculos
{
    public class Veiculo
    {
        // Atributos da classe Veiculo
        public Marcas Marca;
        public string Modelo { get; }
        public int Ano;
        public decimal Preco;
        public double Quilometragem;

        // Metodo Construtor da classe Veiculo
        public Veiculo(Marcas marca, string modelo, int ano, decimal preco, float quilometragem)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Preco = preco;
            Quilometragem = quilometragem;
        }

        // Comportamento da classe Veiculo
        public void ExibirInformacoes()
        {
            Console.WriteLine("INFORMAÇÕES DO VEICULO");
            Console.WriteLine($"MARCA: {Marca} | MODELO: {Modelo}");
            Console.WriteLine($"ANO: {Ano} | PREÇO: {Preco} | QUILOMETRAGEM: {Quilometragem}");
        }

        public string SituacaoVeiculo(double quilometragem) //Verifica se Veiculo é Novo
        {
            if (quilometragem == 0)
                return "Veiculo Novo, 0 km rodados";
            else
            {
                return $"Veiculo Usado, {quilometragem} km rodados.";
            }
        }

        public decimal ValorVeiculo(int anoAtual, decimal preco, double quilometragem)
        {
            int idadeVeiculo = anoAtual - Ano;
            int kmEsperado = idadeVeiculo * 10000;
            decimal ajuste;

            if(quilometragem > kmEsperado)// Desvaloriza o Carro
            {
                ajuste = preco * 0.3m;
                preco = preco - ajuste;
                return preco;
            }
            else if(quilometragem < kmEsperado) // Valoriza o Carro
            {
                ajuste = preco * 0.1m;
                preco = preco + ajuste;
                return preco;
            }
            else
            {
                return preco;
            }
        }
    }
}

