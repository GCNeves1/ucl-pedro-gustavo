using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Padaria
{
    class Vendas
    {
        private List<estoque> produtos;
        private List<(estoque produto, int quantidade)> carrinho;

        public Vendas(List<estoque> produtos)
        {
            this.produtos = produtos;
            this.carrinho = new List<(estoque, int)>();
        }

        public void Registrar()
        {
            Console.Clear();
            bool adicionandoProdutos = true;

            while (adicionandoProdutos)
            {
                Console.WriteLine("Produtos disponíveis:");
                for (int i = 0; i < produtos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {produtos[i].GetProduto()} - R${produtos[i].GetValor()}");
                }

                Console.WriteLine();
                Console.Write("Digite o número do produto que deseja adicionar ao carrinho (ou -1 para finalizar): ");
                int escolhaProduto = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaProduto == -2)
                {
                    adicionandoProdutos = false;
                    continue;
                }

                if (escolhaProduto < 0 || escolhaProduto >= produtos.Count)
                {
                    Console.WriteLine("Produto inválido. Tente novamente.");
                    continue;
                }

                Console.Write("Digite a quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                carrinho.Add((produtos[escolhaProduto], quantidade));

                Console.Clear();
            }

            Console.Clear();
            float total = carrinho.Sum(item => item.produto.GetValor() * item.quantidade);
            Console.WriteLine($"Total do carrinho: R${total}");
            Console.WriteLine();

            float valorPago = 0;
            while (true)
            {
                Console.Write("Digite o valor pago pelo cliente: ");
                valorPago = float.Parse(Console.ReadLine());

                if (valorPago >= total)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Valor insuficiente. O total do carrinho é R${total}. Por favor, digite um valor igual ou superior.");
                }
            }

            float troco = valorPago - total;
            Console.WriteLine($"Troco: R${troco}");
            Console.WriteLine();
            Console.WriteLine("Venda finalizada. Obrigado!");

            Thread.Sleep(5000);
        }
    }
}
