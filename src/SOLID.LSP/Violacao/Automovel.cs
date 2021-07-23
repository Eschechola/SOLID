using System;

namespace SOLID.LSP.Violacao
{
    public abstract class Automovel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string TipoCombustivel { get; set; }
        public decimal PrecoCombustivelLitro { get; set; }
        public decimal QuilometrosPorLitroDeCombustivel { get; set; }
        public decimal ValorAluguelHora { get; set; }

        public abstract decimal CalcularPrecoDoCombustivelPorDistancia(decimal distanciaEmQuilometros);
    }
}
