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
    public class MySystem03_NonPureAdvancedPlayModeTest
    {
        
        [UnityTest]
        public IEnumerator ConvertValue_ResultIs40_WhenInputIs_4_()
        {
            // Arrange
            int value = 4;
            int multiplier = 10;
            IConverter converter = new Converter(multiplier);
            MySystem03_NonPureAdvanced system = new MySystem03_NonPureAdvanced(converter);
            
            // Act
            int result = system.ConvertValue(value);
            
            // Await
            yield return new WaitForSeconds(0.2f);
            
            // Assert
            Assert.That(result, Is.EqualTo(40));
        }
        
    }
}