namespace SOLID.SRP.Solucao.Facade
{
    public class EquipamentoService
    {
        /*
         * OS MÉTODOS PODEM FICAR JUNTOS AQUI
         * PORÉM A SUAS REGRAS DE NÉGOCIO FICAM NOS SERVIÇOS, LOGO
         * A CLASSE DE FACADE CHAMA OS SERVIÇOS ESPECÍFICOS.
         */

        // Chama o ReparoService e executa suas regras de negócio
        public void CriarOrdemDeServicoParaReparo() { /*...*/ }
        public void FinalizarServicoDeReparo() { /*...*/ }
        public void IniciarServicoDeReparo() { /*...*/ }

        // Chama o ComunicacaoService e executa suas regras de negócio
        public void NotificarCliente() { /*...*/ }
        public void GerarRelatorioDeConserto() { /*...*/ }

        // Chama o PagamentoService e executa suas regras de negócio
        public void ConfirmarPagamento() { /*...*/ }
        public void GerarRelatorioDeLucroPeloReparo() { /*...*/ }
    }
}
