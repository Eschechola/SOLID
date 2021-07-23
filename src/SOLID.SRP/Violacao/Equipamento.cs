using System;

namespace SOLID.SRP.Violacao
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

        // O responsável é o setor de reparos
        public void CriarOrdemDeServicoParaReparo() { /*...*/ }
        public void FinalizarServicoDeReparo() { /*...*/ }
        public void IniciarServicoDeReparo() { /*...*/ }

        // O responsável é o contexto de comunicação
        public void NotificarCliente() { /*...*/ }
        public void GerarRelatorioDeConserto() { /*...*/ }

        // O responsável é o contexto de pagamentos
        public void ConfirmarPagamento() { /*...*/ }
        public void GerarRelatorioDeLucroPeloReparo() { /*...*/ }

        /*
         * CASO EXISTA ALGUMA ALTERAÇÃO EM ALGUM CONTEXTO
         * VOCÊ QUE TERA QUE ALTERAR O MÉTODO EM QUESTÃO
         * E ISSO PODE ACABAR QUEBRANDO OUTRO MÉTODO DA RESPONSABILIDADE
         * DE OUTRO CONTEXTO.
         */
    }
}
