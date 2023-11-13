using NUnit.Framework;

namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.PureFunctions")]
    public class MyPureSystemTest
    {
        [Test]
        public void GetProduct_ResultIs20_WhenInputIs_2_10()
        {
            // Arrange
            MyPureSystem myPureSystem = new MyPureSystem();
            int value = 2;
            int multiplier = 10;
            
            // Act
            int result = myPureSystem.ConvertValue(value, multiplier);
            
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }
    }
}