namespace SOLID.LSP.Violacao
{
    public class Carro : Automovel
    {
        public string Placa { get; set; }
        public string ModeloDoCarro { get; set; }
        public string FabricanteDoCarro { get; set; }

        public override decimal CalcularPrecoDoCombustivelPorDistancia(decimal distanciaEmQuilometros)
            => PrecoCombustivelLitro * (distanciaEmQuilometros / QuilometrosPorLitroDeCombustivel);
    }
}
