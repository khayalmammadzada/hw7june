using System;
namespace hw
{
    public class Market : IStore
    {
        private Product[] _products;
        private double _totalIncome;
        public Product[] Products { get => Products; }
        
        //product limit menfiye dusmesin deye incapsulation
        public int ProductLimit { get ; set ; }

        public double TotalIncome { get =>_totalIncome; }

        public void AddProduct(Product product)
        {
            if (_products.Length < ProductLimit)
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1]=product;
            }
            
        }

        public void SellProduct(string No)
        {
            Product product = new Product();
            for(int i=0; i<_products.Length; i++)
            {
                if (_products[i].No != _products[i + 1].No && _products[i].Count != 0)
                    _totalIncome += _products[i].Price;
            }

        }

        
    }
}
