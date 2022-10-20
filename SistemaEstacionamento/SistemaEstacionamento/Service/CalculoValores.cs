using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Service
{
    public static class CalculoValores
    {
        public static decimal ValorDoTempoEstacionado(decimal precoInicial, decimal precoPorHora, int horas)
        {
            return precoInicial + precoPorHora * horas;
        }
    }
}
