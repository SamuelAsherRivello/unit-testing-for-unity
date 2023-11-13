using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.PureFunctions")]
    public class MyPureSystemPlayModeTest
    {
        [UnityTest]
        public IEnumerator GetProduct_ResultIs20_WhenInputIs_2_10()
        {
            // Arrange
            MyPureSystem myPureSystem = new MyPureSystem();
            int value = 2;
            int multiplier = 10;
            
            // Act
            int result = myPureSystem.ConvertValue(value, multiplier);
        
            // Await
            yield return new WaitForSeconds(0.2f);
        
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }
    }
}