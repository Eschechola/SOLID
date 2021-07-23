namespace SOLID.OCP.Solucao
{
    public abstract class RelatorioService
    {
        public object Dados { get; set; }
        public void BuscarDados() { /*...*/ }

        public abstract void GerarRelatorio();
    }
}
