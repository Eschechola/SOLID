namespace SOLID.ISP.Violacao
{
    public interface ISQLServerRepository
    {
        void CreateProduct(object product);
        void CreateOrder(object order);
        void CreateCategory(object category);
    }
}
