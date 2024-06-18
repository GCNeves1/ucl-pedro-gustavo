using System;
using System.Collections.Generic;
using System.Threading;

namespace Padaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<cadastroCliente> listaDeClientes = DataPersistence.LoadClientes();
            List<estoque> listaDeProdutos = DataPersistence.LoadProdutos();


            listaDeProdutos = DataPersistence.LoadProdutos();

            void menu()
            {
                Console.Clear();
                Console.WriteLine("Bem vindo:");
                Console.WriteLine(@" #####      ##     ####       ##     #####     ####      ##
 ##  ##    ####    ## ##     ####    ##  ##     ##      ####
 ##  ##   ##  ##   ##  ##   ##  ##   ##  ##     ##     ##  ##
 #####    ######   ##  ##   ######   #####      ##     ######
 ##       ##  ##   ##  ##   ##  ##   ####       ##     ##  ##
 ##       ##  ##   ## ##    ##  ##   ## ##      ##     ##  ##
 ##       ##  ##   ####     ##  ##   ##  ##    ####    ##  ##
");

                Console.WriteLine("Digite 1 para registrar uma venda");
                Console.WriteLine("Digite 2 para cadastrar cliente");
                Console.WriteLine("Digite 3 para dar entrada no estoque");
                Console.WriteLine("Digite 4 para ver clientes cadastrados");
                Console.WriteLine("Digite 5 para ver produtos cadastrados");
                Console.WriteLine("Digite -1 para sair do sistema");
            }

            void registrarVenda()
            {
                Vendas venda = new Vendas(listaDeProdutos);
                venda.Registrar();
            }

            void clientes()
            {
                Console.Clear();
                Console.WriteLine("**************************");
                Console.WriteLine("LISTA DE CLIENTES ADICIONADOS");
                Console.WriteLine("**************************");
                Console.WriteLine();

                for (int i = 0; i < listaDeClientes.Count; i++)
                {
                    Console.WriteLine($"Cliente {(i + 1)}:");
                    Console.WriteLine($"Nome: {listaDeClientes[i].GetNome()}");
                    Console.WriteLine($"Telefone: {listaDeClientes[i].GetTelefone()}");
                    Console.WriteLine($"Email: {listaDeClientes[i].GetEmail()}");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

            void cadastro()
            {
                Console.Clear();
                cadastroCliente novoCliente = new cadastroCliente();

                Console.WriteLine("Qual cliente você gostaria de registrar ?");
                novoCliente.SetNome(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Qual o telefone do cliente:");
                novoCliente.SetTelefone(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Qual o email do cliente:");
                novoCliente.SetEmail(Console.ReadLine());
                Console.WriteLine();

                listaDeClientes.Add(novoCliente);
                DataPersistence.SaveClientes(listaDeClientes);
            }

            void adicionarProduto()
            {
                Console.Clear();

                estoque novoProduto = new estoque();

                Console.WriteLine("Qual produto você gostaria de adicionar?");
                novoProduto.SetProduto(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Qual o valor do produto?");
                novoProduto.SetValor(float.Parse(Console.ReadLine()));
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine($"Você adicionou o produto: {novoProduto.GetProduto()} o valor dele é R${novoProduto.GetValor()}");
                Thread.Sleep(5000);

                listaDeProdutos.Add(novoProduto);
                DataPersistence.SaveProdutos(listaDeProdutos);
            }

            void produtos()
            {
                Console.Clear();
                Console.WriteLine("**************************");
                Console.WriteLine("LISTA DE PRODUTOS ADICIONADOS");
                Console.WriteLine("**************************");
                Console.WriteLine();

                for (int i = 0; i < listaDeProdutos.Count; i++)
                {
                    Console.WriteLine($"Produto {(i + 1)}:");
                    Console.WriteLine($"Nome: {listaDeProdutos[i].GetProduto()}");
                    Console.WriteLine($"Valor: R${listaDeProdutos[i].GetValor()}");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

            // Início do código
            bool continuarSwitch = true;
            while (continuarSwitch)
            {
                menu();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Digite uma opção: ");
                int escolhaMenu = Convert.ToInt32(Console.ReadLine());
                switch (escolhaMenu)
                {
                    case 1:
                        if (listaDeProdutos.Count == 0)
                        {
                            Console.WriteLine("Não há produtos cadastrados. Por favor, cadastre produtos antes de registrar uma venda.");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("Opção 1 escolhida");
                            Thread.Sleep(2000);
                            registrarVenda();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Opção 2 escolhida");
                        Thread.Sleep(2000);
                        cadastro();
                        break;
                    case 3:
                        Console.WriteLine("Opção 3 escolhida");
                        adicionarProduto();
                        break;
                    case 4:
                        Console.WriteLine("Opção 4 escolhida");
                        clientes();
                        break;
                    case 5:
                        Console.WriteLine("Opção 5 escolhida");
                        produtos();
                        break;
                    case -1:
                        continuarSwitch = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}