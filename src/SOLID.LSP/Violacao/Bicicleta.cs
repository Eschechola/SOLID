namespace SOLID.LSP.Violacao
{
    public class Bicicleta : Automovel
    {
        public string ModeloBicicleta { get; set; }
        public string FaixaEtaria { get; set; }

        public override decimal CalcularPrecoDoCombustivelPorDistancia(decimal distanciaEmQuilometros)
        {
            /*
             * COMO BICICLETA NÃO É EFETIVAMENTE UM AUTOMOVEL (NAO POSSUI MOTOR)
             * O LSP FOI VIOLADO E A HERANÇA NÃO FOI IMPLEMENTADA CORRETAMENTE
             */

            /*...*/
            return 0;
        }
    }
}
