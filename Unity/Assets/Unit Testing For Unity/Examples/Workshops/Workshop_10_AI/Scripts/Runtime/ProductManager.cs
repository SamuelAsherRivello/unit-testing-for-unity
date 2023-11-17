using System.Collections.Generic;

namespace RMC.UnitTesting.Examples.AI
{
    /// <summary>
    /// This is an AI example class
    /// </summary>
    public class ProductManager
    {
        private List<Product> products;

        public ProductManager()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public bool RemoveProduct(int productId)
        {
            var product = products.Find(p => p.ID == productId);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int ID { get; set; }
        // Add other product properties here

        public Product(string name, int id)
        {
            Name = name;
            ID = id;
        }

        // You can add more methods or properties as needed
    }
}