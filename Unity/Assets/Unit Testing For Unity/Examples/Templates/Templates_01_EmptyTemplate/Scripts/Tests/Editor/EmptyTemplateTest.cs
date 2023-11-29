using NUnit.Framework;

namespace RMC.UnitTesting.Examples.EmptyTemplate
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Examples.EmptyTemplate")]
    public class EmptyTemplateTest
    {
        [Test]
        public void MethodCall_IsExpected_WhenCondition()
        {
            // Arrange
            EmptyTemplate emptyTemplate = new EmptyTemplate();

            // Act

            // Assert
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
