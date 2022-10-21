using System.Collections.Generic;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        public Taxas Taxas { get; set; }

        public List<Veiculo> Veiculos = new List<Veiculo>();
    }
}
