using SistemaEstacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void MenuPrincipal()
        {

        }
    }
}
