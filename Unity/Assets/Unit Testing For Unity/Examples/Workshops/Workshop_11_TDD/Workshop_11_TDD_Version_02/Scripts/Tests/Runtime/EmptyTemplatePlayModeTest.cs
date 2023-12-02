using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace RMC.UnitTesting.Examples.TDD
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Examples.TDD")]
    public class EmptyTemplatePlayModeTest
    {
        [UnityTest]
        public IEnumerator MethodCall_IsExpected_WhenCondition_PlayMode()
        {
            // Arrange

            // Act
            
            // Await
            yield return new WaitForSeconds(0.2f);

            // Assert
            Assert.That(true, Is.EqualTo(true));
        }
    }
}