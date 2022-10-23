namespace SistemaEstacionamento.Models
{
    public class Veiculo
    {
        public string Tipo { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }

        public override string ToString()
        {
            return $"Tipo: {Tipo}\nPlaca: {Placa}\nCor: {Cor}\n";
        }
    }
}
