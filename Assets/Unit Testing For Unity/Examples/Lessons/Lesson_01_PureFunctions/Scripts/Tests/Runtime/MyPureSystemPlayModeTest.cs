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
    public class MyPureSystemPlayModeTest
    {
        [UnityTest]
        public IEnumerator ConvertValue_ResultIs20_WhenInputIs_2_10_()
        {
            // Arrange
            int value = 2;
            int multiplier = 10;
            MySystem01_Pure system = new MySystem01_Pure();

            // Act
            int result = system.ConvertValue(value, multiplier);
        
            // Await
            yield return new WaitForSeconds(0.2f);
        
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }
    }
}