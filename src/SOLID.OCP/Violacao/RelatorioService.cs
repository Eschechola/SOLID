namespace SOLID.OCP.Violacao
{
    public class RelatorioService
    {
        /*
         * O MAIOR PROBLEMA SERIA, CASO SEJA SOLICITADO ALGUMA
         * MUDANÇA NO GRÁFICO DE COLUNAS POR EXEMPLO, 
         * O DESENVOLVEDOR PODERIA TER QUE MEXER EM BOA PARTE
         * DESSE SERVICO, LOGO TEM CHANCE DE QUEBRAR OS OUTROS
         * RELATORIOS, OU SEJA, OS OUTROS MODELOS DE RELATORIO ESTARIAM
         * DESPROTEGIDOS EM CASO DE UMA ALTERAÇAO QUE NÃO É RELACIONADA A ELES.
         */

        public object Dados { get; set; }
        public void BuscarDados() { /*...*/ }

        public void GerarRelatorioParaGraficoDeColunas()
        {
            BuscarDados();
            /*...*/
        }

        public void GerarRelatorioParaGraficoDeBarras()
        {
            BuscarDados();
            /*...*/
        }

        public void GerarRelatorioParaGraficoDePizza()
        {
            BuscarDados();
            /*...*/
        }

        public void GerarRelatorioParaGraficoDeRede()
        {
            BuscarDados();
            /*...*/
        }
    }
}
