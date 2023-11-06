using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace RMC.UnitTesting.Samples.CharacterMovement
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.CharacterMovement")]
    public class CharacterPlayModeTest
    {
        [UnityTest]
        public IEnumerator MoveTo_Result123_When123()
        {
            // Arrange
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Character character = go.AddComponent<Character>();
            Vector3 position = new Vector3(1, 2, 3);

            Vector3 result = character.MoveTo(position);
            
            // Await
            yield return new WaitForSeconds(1);
            
            // Assert
            Assert.That(result, Is.EqualTo(position));
        }
    }
}