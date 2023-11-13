using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.MyPureSystem")]
    public class MyPureSystemPlayModeTest
    {
        [UnityTest]
        public IEnumerator Add_ResultIs15_When5And10()
        {
            // Arrange
            MyPureSystem myPureSystem = new MyPureSystem();
            int productId = 0;
            
            // Act
            string result = myPureSystem.GetProduct(productId);
            
            // Await
            yield return new WaitForSeconds(0.1f);
            
            // Assert
            Assert.That(result, Is.EqualTo("Console"));

        }
    }
}