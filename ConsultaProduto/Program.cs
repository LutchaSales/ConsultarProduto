using ConsultaProduto;
using System;
using System.Globalization;

namespace ConsultaProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do Produto: ");
            Console.Write("Nome do Produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do Produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Dados do Produto :" + p);

            Console.WriteLine();
            Console.Write("Digite o Número de Produtos a ser Adicionados no Estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


            Console.WriteLine();
            Console.Write("Digite o Número de Produtos a ser Removidos do Estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);



        }
    }
}