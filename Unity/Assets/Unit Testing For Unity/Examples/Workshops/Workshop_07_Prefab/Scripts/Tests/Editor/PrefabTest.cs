using NUnit.Framework;

namespace RMC.UnitTesting.Examples.Prefab
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Examples.Prefab")]
    public class PrefabTest
    {
        /// <summary>
        /// While using EDITOR tests on a Scene-based
        /// is possible, it is not recommended. Instead, use a PlayModeTest
        /// </summary>
        [Test]
        public void Empty_Passing_Test()
        {
            // Arrange
            
            // Act
            
            // Assert
            Assert.That(true, Is.True); //Replace with any test you like
        }
    }
}