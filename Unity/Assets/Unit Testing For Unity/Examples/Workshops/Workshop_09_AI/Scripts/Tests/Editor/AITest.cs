using NUnit.Framework;
using System.Linq;

namespace RMC.UnitTesting.Examples.AI
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Examples.AI")]
    public class AITest
    {
        private ProductManager productManager;

        [SetUp]
        public void Setup()
        {
            // Setup runs before each test method
            productManager = new ProductManager();
        }

        [Test]
        public void AddProduct_GetProductsContainsProduct_WhenProductAdded()
        {
            // Arrange
            var product = new Product("Test Product", 1);

            // Act
            productManager.AddProduct(product);

            // Assert
            Assert.IsTrue(productManager.GetProducts().Contains(product), "Product should be added to the list.");
        }

        [Test]
        public void RemoveProduct_GetProductsDoesNotContainProduct_WhenProductRemoved()
        {
            // Arrange
            var product = new Product("Test Product", 1);
            productManager.AddProduct(product);

            // Act
            bool result = productManager.RemoveProduct(1);

            // Assert
            Assert.IsTrue(result, "Product should be removed successfully.");
            Assert.IsFalse(productManager.GetProducts().Contains(product), "Product should no longer be in the list.");
        }

        [Test]
        public void GetProducts_ReturnsAllProducts_WhenMultipleProductsAdded()
        {
            // Arrange
            productManager.AddProduct(new Product("Product 1", 1));
            productManager.AddProduct(new Product("Product 2", 2));

            // Act
            var products = productManager.GetProducts();

            // Assert
            Assert.AreEqual(2, products.Count, "GetProducts should return all added products.");
        }
    }
}