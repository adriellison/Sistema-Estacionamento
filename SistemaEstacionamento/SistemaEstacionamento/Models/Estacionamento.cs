using SistemaEstacionamento.Service;
using SistemaEstacionamento.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            veiculos.Add(placa.ToUpper());
        }

        public void RemoverVeiculo()
        {
            string placa = EstacionamentoView.RemoverVeiculoView();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = EstacionamentoView.TempoEstacionadoView();

                decimal valorTotal = CalculoValores.ValorDoTempoEstacionado(precoInicial, precoPorHora, horas);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
