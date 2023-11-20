using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Examples.PureFunctions")]
    public class MySystem02_NonPurePlayModeTest
    {
        [UnityTest]
        public IEnumerator ConvertValue_ResultIs30_WhenInputIs_3_()
        {
            // Arrange
            int value = 3;
            int multiplier = 10;
            MySystem02_NonPure system = new MySystem02_NonPure(multiplier);
            
            // Act
            int result = system.ConvertValue(value);
            
            // Await
            yield return new WaitForSeconds(0.2f);
            
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
    }
}