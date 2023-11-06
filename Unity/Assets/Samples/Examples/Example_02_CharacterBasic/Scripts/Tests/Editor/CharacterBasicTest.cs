using NUnit.Framework;
using UnityEngine;

namespace RMC.UnitTesting.Samples.CharacterBasic
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.CharacterBasic")]
    public class CharacterBasicTest
    {
        [Test]
        public void MoveTo_Result123_When123()
        {
            // Arrange
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            CharacterBasic characterBasic = go.AddComponent<CharacterBasic>();
            Vector3 position = new Vector3(1, 2, 3);

            Vector3 result = characterBasic.MoveTo(position);
            
            // Assert
            Assert.That(result, Is.EqualTo(position));
        }
    }
}