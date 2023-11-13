using NUnit.Framework;

namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.MyPureSystem")]
    public class MyPureSystemTest
    {
        [Test]
        public void Add_ResultIs15_When5And10()
        {
            // Arrange
            MyPureSystem myPureSystem = new MyPureSystem();
            int productId = 0;
            
            // Act
            string result = myPureSystem.GetProduct(productId);
            
            // Assert
            Assert.That(result, Is.EqualTo("Console"));
        }
    }
}