using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> estoque = new Dictionary<string, int>();

    static int ConsultarEstoque(string produto)
    {
        if (estoque.ContainsKey(produto))
        {
            return estoque[produto];
        }
        else
        {
            Console.WriteLine("\nProduto não encontrado");
            return -1;
        }
    }

    static void Main()
    {
        // Inicializando o estoque com alguns produtos
        estoque.Add("sapatos", 8);
        estoque.Add("camisetas", 32);
        estoque.Add("calças", 15);

        Console.WriteLine("Bem-vindo ao sistema de gerenciamento de estoque");

        // Loop infinito para o menu
        while (true)
        {
            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Cadastro de Produtos no Estoque");
            Console.WriteLine("2 - Consultar Quantidade em Estoque do Produto");
            Console.WriteLine("3 - Mostrar Todos os Produtos em Estoque");
            Console.WriteLine("4 - Sair do Programa");

            Console.Write("Digite uma opção: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    AdicionarProdutoEstoque();
                    break;

                case "2":
                    ConsultarQuantidadeProduto();
                    break;

                case "3":
                    MostrarEstoque();
                    break;

                case "4":
                    Console.WriteLine("\nSaindo do Programa...");
                    return;

                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarProdutoEstoque()
    {
        Console.Write("Digite o nome do produto: ");
        string produto = Console.ReadLine().ToLower();

        Console.Write("Digite a quantidade no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        estoque[produto] = quantidade;
        Console.WriteLine($"\nO produto {produto} foi adicionado ao estoque com quantidade {quantidade}");
    }

    static void ConsultarQuantidadeProduto()
    {
        Console.Write("\nDigite o nome do produto para consultar o estoque: ");
        string produtoConsulta = Console.ReadLine().ToLower();

        int quantidadeEstoque = ConsultarEstoque(produtoConsulta);
        if (quantidadeEstoque != -1)
        {
            Console.WriteLine($"\nA quantidade de {produtoConsulta} em estoque é {quantidadeEstoque}");
        }
        else
        {
            Console.WriteLine($"\nO produto {produtoConsulta} não foi encontrado no estoque");
        }
    }

    static void MostrarEstoque()
    {
        Console.WriteLine("\nProdutos em estoque:");
        foreach (var item in estoque)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
