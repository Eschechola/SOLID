using System;

namespace SOLID.SRP.Solucao
{
    public class Equipamento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int HorasTrabalhadas { get; set; }
        public decimal PrecoPorHora { get; set; }
        public DateTime IniciadoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }

        /*
         * CASO PREFIRA OS MÉTODOS PODEM CONTINUAR AQUI
         * PORÉM A SUAS REGRAS DE NÉGOCIO FICAM NOS SERVIÇOS, LOGO
         * A ENTIDADE EQUIPAMENTOS PASSA A SER UM FACADE 
         * CHAMANDO OS SERVIÇOS ESPECÍFICOS.
         * 
         * EU -> PARTICULARMENTE <- PREFIRO UTILIZAR FACADES
         * AO INVÉS DEIXAR MÉTODOS QUE SE COMUNICAM COM FONTES EXTERNAS NAS ENTIDADES
         */

        // public void CriarOrdemDeServicoParaReparo() { /*...*/ }
        // public void FinalizarServicoDeReparo() { /*...*/ }
        // public void IniciarServicoDeReparo() { /*...*/ }
        // public void NotificarCliente() { /*...*/ }
        // public void GerarRelatorioDeConserto() { /*...*/ }
        // public void ConfirmarPagamento() { /*...*/ }
        // public void GerarRelatorioDeLucroPeloReparo() { /*...*/ }
    }
}
