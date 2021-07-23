namespace SOLID.ISP.Violacao
{
    public class SQLServerRepository : ISQLServerRepository
    {
        /*
         * A VIOLACAO OCOORE POIS CASO HAJA ALGUMA MUDANÇA 
         * NA ASSINATURA DO MÉTODO OU IMPLEMENTAÇAO, A CLASSE TODA
         * SERA AFETADA E QUEM CONSOME ESSES MÉTODOS TAMBÉM SERÁ AFETADO
         */
        public void CreateCategory(object category)
        {
            /*...*/
        }

        public void CreateOrder(object order)
        {
            /*...*/
        }

        public void CreateProduct(object product)
        {
            /*...*/
        }
    }
}
