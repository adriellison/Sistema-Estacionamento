using SistemaEstacionamento.Models;
using SistemaEstacionamento.Views;
using System;
using System.Linq;

namespace SistemaEstacionamento.Service
{
    public class EstacionamentoService
    {
        public Estacionamento _estacionamento;
        public EstacionamentoView _view;
        
        public EstacionamentoService(Estacionamento estacionamento, EstacionamentoView view)
        {
            _estacionamento = estacionamento;
            _view = view;
        }

        public void AdicionarVeiculo()
        {
            Veiculo veiculo = _view.AdicionarVeiculoView();

            _estacionamento.Veiculos.Add(veiculo);
        }

        public void RemoverVeiculo(Taxas taxas)
        {
            string placa = _view.RemoverVeiculoView();

            if (_estacionamento.Veiculos.Any(x => x.Placa.ToUpper() == placa.ToUpper()))
            {
                int horas = _view.TempoEstacionadoView();

                decimal valorTotal = CalculoValores.ValorDoTempoEstacionado(taxas.PrecoInicial, taxas.PrecoPorHora, horas);

                Veiculo veiculo = _estacionamento.Veiculos.FirstOrDefault(x => x.Placa.ToUpper() == placa.ToUpper());

                _estacionamento.Veiculos.Remove(veiculo);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (_estacionamento.Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (Veiculo veiculo in _estacionamento.Veiculos)
                {
                    Console.WriteLine("");
                    Console.WriteLine(veiculo.ToString());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
