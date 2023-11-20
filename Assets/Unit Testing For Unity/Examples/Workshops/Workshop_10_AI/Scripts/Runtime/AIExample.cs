using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using System.Collections.Generic;

namespace RMC.UnitTesting.Examples.AI
{
    /// <summary>
    /// This example is the main entry point for the
    /// <see cref="ProductManager"/> demonstration
    /// </summary>
    public class AIExample : MonoBehaviour
    {
        private ProductManager productManager;

        [ExcludeFromCodeCoverage]
        protected void Awake()
        {
            productManager = new ProductManager();

            // Add some products
            productManager.AddProduct(new Product("Product 1", 101));
            productManager.AddProduct(new Product("Product 2", 102));
            productManager.AddProduct(new Product("Product 3", 103));

            // Retrieve and log the list of products
            List<Product> products = productManager.GetProducts();
            foreach (Product product in products)
            {
                Debug.Log($"Product: {product.Name}, ID: {product.ID}");
            }
        }
    }
}