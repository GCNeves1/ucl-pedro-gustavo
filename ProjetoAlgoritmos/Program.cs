using System;
using System.Collections.Generic;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        // Listas
        // Início das listas
        List<cadastroCliente> listaDeClientes = new List<cadastroCliente>();
        // Fim das listas

        // Menu
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
            Console.WriteLine("Digite 4 para cadastrar uma fornecedora");
            Console.WriteLine("Digite 5 para ver clientes cadastrados");
      
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
            // Criação de um novo cliente
            cadastroCliente novoCliente = new cadastroCliente();

            // Nome
            Console.WriteLine("Qual cliente você gostaria de registrar ?");
            novoCliente.SetNome(Console.ReadLine());
            Console.WriteLine();

            // Telefone
            Console.WriteLine("Qual o telefone do cliente:");
            novoCliente.SetTelefone(Console.ReadLine());
            Console.WriteLine();

            // Email
            Console.WriteLine("Qual o email do cliente:");
            novoCliente.SetEmail(Console.ReadLine());
            Console.WriteLine();

            // Adiciona o novo cliente à lista de clientes
            listaDeClientes.Add(novoCliente);
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
                    Console.WriteLine("Opção 1 escolhida");
                    Thread.Sleep(2000);
                    break;
                case 2:
                    Console.WriteLine("Opção 2 escolhida");
                    Thread.Sleep(2000);
                    cadastro();
                    break;
                case 3:
                    Console.WriteLine("Opção 3 escolhida");
                    break;
                case 4:
                    Console.WriteLine("Opção 4 escolhida");
                    break;
                case 5:
                    Console.WriteLine("Opção 4 escolhida");
                    clientes();
                    break;
                case -1:
                    continuarSwitch = false;
                    Console.WriteLine("Opção -1 escolhida");
                    break;
                default:
                    Console.WriteLine("Opção inválida:");
                    Thread.Sleep(2000);
                    menu();
                    break;
            }
        }
    }
}