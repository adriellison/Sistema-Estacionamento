using SistemaEstacionamento.Models;
using SistemaEstacionamento.Service;

namespace SistemaEstacionamento.Controller
{
    public class EstacionamentoController
    {
        EstacionamentoService _service;
        public EstacionamentoController(EstacionamentoService service)
        {
            _service = service;
        }

        public void AdicionarVeiculo()
        {
            _service.AdicionarVeiculo();
        }

        public void RemoverVeiculo(Taxas taxas)
        {
            _service.RemoverVeiculo(taxas);
        }

        public void ListarVeiculos()
        {
            _service.ListarVeiculos();
        }
    }
}
