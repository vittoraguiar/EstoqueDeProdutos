using System;

namespace ProdutosEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis
            char criterio = 's';

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Produto: ");
            string nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine()!);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            Produto prod = new Produto(nome, preco, quantidade);
            
            // Mostra os dados do produto
            Console.Write("\nDados do produto: " + prod);
            Console.WriteLine();

            do
            {
                Console.Write("\nVocê deseja adicionar ou remover produtos do estoque (A ou R)? ");
                criterio = char.Parse(Console.ReadLine()!);
                var qnt = 0;
                switch (criterio)
                {
                    case 'A':
                    case 'a':
                        Console.Write("\nDigite o número de produtos a serem adicionados ao estoque: ");
                        qnt = int.Parse(Console.ReadLine()!);
                        prod.AdicionarProdutos(qnt); // Operação que recebe um valor e altera na classe
                        Console.WriteLine("\nDados atualizados: " + prod);
                        break;
                    case 'R':
                    case 'r':
                        Console.Write("\nDigite o número de produtos a serem removidos do estoque: ");
                        qnt = int.Parse(Console.ReadLine()!);
                        prod.RemoverProdutos(qnt);
                        Console.WriteLine("\nDados atualizados: " + prod);
                        break;
                    default:
                        Console.WriteLine("Instrução inserida não existe!");
                        break;
                }
                Console.Write("Você deseja repetir as instruções (s ou n)?: ");
                criterio = char.Parse(Console.ReadLine()!);
            } while (criterio is 's' or 'S');
            Console.WriteLine("Fim do programa!!!");
        }
    }
}
