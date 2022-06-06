using System;
namespace hw
{
    public interface IStore
    {
        Product[] Products { get;}
        int ProductLimit { get; set; }
        double TotalIncome { get;}
        void AddProduct(Product product);
        void SellProduct(Product product);
    }
}
