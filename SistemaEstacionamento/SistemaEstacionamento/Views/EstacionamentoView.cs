using SistemaEstacionamento.Models;
using SistemaEstacionamento.Service;
using System;

namespace SistemaEstacionamento.Views
{
    public class EstacionamentoView
    {
        public Taxas CadastrarValoresView(Taxas taxas)
        {
            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");
            
            Console.WriteLine("Digite o preço inicial:");
            taxas.PrecoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora:");
            taxas.PrecoPorHora = Convert.ToDecimal(Console.ReadLine());

            return taxas;
        }

        public string RemoverVeiculoView()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            return placa;
        }

        public int TempoEstacionadoView()
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = Convert.ToInt32(Console.ReadLine());

            return horas;
        }

        public Veiculo AdicionarVeiculoView()
        {
            Veiculo veiculo = new Veiculo();

            Console.WriteLine("Digite o tipo do veículo: ");
            veiculo.Tipo = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculo.Placa = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a cor do veículo");
            veiculo.Cor = Console.ReadLine().ToUpper();

            return veiculo;
        }
    }
}
