using NUnit.Framework;

namespace RMC.UnitTesting.Examples.TDD
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Examples.TDD")]
    public class EmptyTemplateTest
    {
        [Test]
        public void MethodCall_IsExpected_WhenCondition()
        {
            // Arrange

            // Act

            // Assert
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
