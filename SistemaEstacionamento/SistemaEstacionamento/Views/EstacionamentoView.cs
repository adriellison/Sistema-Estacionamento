using SistemaEstacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Views
{
    public static class EstacionamentoView
    {
        public static Taxas CadastrarValoresView(Taxas taxas)
        {
            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");
            Console.WriteLine("Digite o preço inicial:");
            taxas.PrecoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora:");
            taxas.PrecoPorHora = Convert.ToDecimal(Console.ReadLine());

            return taxas;
        }

        public static string RemoverVeiculoView()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            return placa;
        }

        public static int TempoEstacionadoView()
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = Convert.ToInt32(Console.ReadLine());

            return horas;
        }

        public static void MenuPrincipal()
        {

        }
    }
}
