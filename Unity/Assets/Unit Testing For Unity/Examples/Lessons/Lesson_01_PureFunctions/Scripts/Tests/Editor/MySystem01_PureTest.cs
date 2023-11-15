using NUnit.Framework;

namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Examples.PureFunctions")]
    public class MySystem01_PureTest
    {
        [Test]
        public void ConvertValue_ResultIs20_WhenInputIs_2_10()
        {
            // Arrange
            int value = 2;
            int multiplier = 10;
            MySystem01_Pure system = new MySystem01_Pure();

            // Act
            int result = system.ConvertValue(value, multiplier);
            
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }
    }
}