# Cadastro de Veículos

Projeto desenvolvido em C# para praticar conceitos de Programação Orientada a Objetos (POO).

## Objetivo

Criar um sistema de cadastro de veículos em console, aplicando conceitos de Orientação a Objetos para organizar melhor o código e separar responsabilidades.

## Requisitos

- .NET 10 SDK
- Visual Studio 2022/2026 ou outro editor compatível

## Como executar

1. Abra a solução no Visual Studio ou use o terminal na pasta do projeto.
2. No terminal, execute:

   dotnet run --project CadastroDeVeiculos

Ou execute a aplicação a partir do Visual Studio (Start / F5).

## Formato de entrada

- Marca: texto.
- Modelo: texto.
- Ano: número inteiro.
- Placa: texto.

Exemplo de entrada: "Toyota", "Corolla", "2020", "ABC-1234"

## Conceitos de Orientação a Objetos aplicados

- Criação de classes e objetos.
- Encapsulamento de atributos e propriedades.
- Métodos para definir comportamentos dos objetos.
- Separação de responsabilidades.
- Organização dos dados utilizando objetos.
- Utilização de `List<T>` para armazenar os veículos.

## Funcionalidades implementadas

- Cadastro de veículos.
- Armazenamento dos veículos cadastrados.
- Consulta dos veículos.
- Exibição das informações dos veículos.
- Utilização de classes para representar os veículos.

## Comportamento atual e limitações

- Todos os dados ficam em memória utilizando `List<T>`.
- Ao encerrar o programa, os dados cadastrados são perdidos.
- A aplicação funciona por meio do console.
- O sistema ainda possui validações básicas de entrada.
- Não há persistência de dados em banco de dados ou arquivos.

## Exemplo de uso (fluxo)

1. Iniciar o sistema.
2. Cadastrar um veículo informando seus dados.
3. Consultar os veículos cadastrados.
4. Visualizar as informações dos veículos.
5. Encerrar a aplicação.

## Melhorias sugeridas

- Implementar persistência de dados utilizando arquivos ou banco de dados.
- Adicionar validação mais robusta das entradas.
- Implementar busca por marca ou modelo.
- Adicionar edição e exclusão de veículos.
- Melhorar a interface e a experiência de uso no console.
- Evoluir posteriormente para uma aplicação com interface gráfica ou API.
