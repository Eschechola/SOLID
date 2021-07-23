using SOLID.ISP.Solucao.Interfaces;

namespace SOLID.ISP.Solucao.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        /*
         * AGORA TENDO AS INTERFACES ESPECIALIZADAS
         * QUEM CONSOME NÃO SERÁ AFETADO CASO HAJA ALGUMA MUDANÇA
         * EM ASSINATURA DE MÉTODO E NEM IRÁ IMPORTAR COISAS
         * QUE NÃO UTILIZA
         *
         * NAO DEPENDA DE COISAS DESNECESSARIAS!
         */
        public void CreateOrder(object order)
        {
            /*...*/
        }
    }
}
