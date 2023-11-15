using NUnit.Framework;

namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Examples.PureFunctions")]
    public class MySystem02_NonPureTest
    {
        [Test]
        public void ConvertValue_ResultIs30_WhenInputIs_3()
        {
            // Arrange
            int value = 3;
            int multiplier = 10;
            MySystem02_NonPure system = new MySystem02_NonPure(multiplier);

            // Act
            int result = system.ConvertValue(value);

            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
    }
}