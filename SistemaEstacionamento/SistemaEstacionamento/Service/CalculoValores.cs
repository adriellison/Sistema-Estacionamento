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
