using SistemaEstacionamento.Controller;
using SistemaEstacionamento.Models;
using SistemaEstacionamento.Service;
using SistemaEstacionamento.Views;
using System;

namespace SistemaEstacionamento
{
    public class Principal
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Taxas taxas = new Taxas();

            Estacionamento e = new Estacionamento();

            EstacionamentoView ev = new EstacionamentoView();

            taxas = ev.CadastrarValoresView(taxas);
            
            EstacionamentoService es = new EstacionamentoService(e, ev);

            EstacionamentoController controller = new EstacionamentoController(es);

            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        controller.AdicionarVeiculo();
                        break;
                    case "2":
                        controller.RemoverVeiculo(taxas);
                        break;
                    case "3":
                        controller.ListarVeiculos();
                        break;
                    case "4":
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa foi encerrado");
        }
    }
}
