using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductBusiness
    {
        public List<Product> Get()
        {
            ProductData data = new ProductData();
            var products = data.Get();
            return products;
        }
        public List<Product> GetByName(string name)
        {
            ProductData data = new ProductData();
            var products = data.GetByName(name);
            return products;
        }
        public void InsertProduct(string name, double price, int stock)
        {
            ProductData data = new ProductData();
            data.InsertProduct(name, price, stock);
        }

        public void DeleteProduct(int productId)
        {
            ProductData data = new ProductData();
            data.DeleteProduct(productId);
        }
    }
}
