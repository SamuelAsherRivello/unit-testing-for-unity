using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace RMC.UnitTesting.Examples.EmptyTemplate
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Examples.EmptyTemplate")]
    public class EmptyTemplatePlayModeTest
    {
        [UnityTest]
        public IEnumerator MethodCall_IsExpected_WhenCondition_PlayMode()
        {
            // Arrange
            EmptyTemplate emptyTemplate = new EmptyTemplate();

            // Act
            
            // Await
            yield return new WaitForSeconds(0.2f);

            // Assert
            Assert.That(true, Is.EqualTo(true));
        }
    }
}