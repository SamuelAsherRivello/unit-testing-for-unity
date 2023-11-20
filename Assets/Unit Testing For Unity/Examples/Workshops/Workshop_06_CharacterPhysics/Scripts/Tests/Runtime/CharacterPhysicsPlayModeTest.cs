using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace RMC.UnitTesting.Examples.CharacterPhysics
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Examples.CharacterPhysics")]
    public class CharacterPhysicsPlayModeTest
    {
        private GameObject _testGameObject;
        private CharacterPhysics _characterPhysics;
        private const float WaitSeconds = 0.5f; 

        /// <summary>
        /// Setup method to initialize the test environment before each test is run
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _testGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _testGameObject.name = "TestGameObject";
            CharacterPhysicsMb characterPhysicsMb  = _testGameObject.AddComponent<CharacterPhysicsMb>();
            _characterPhysics = new CharacterPhysics(characterPhysicsMb);
        }

        /// <summary>
        /// Teardown method to cleanup the test environment after each test has run
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(_testGameObject);
            _testGameObject = null;
            _characterPhysics = null;
            
        }

        /// <summary>
        /// Test to check if the character moves left correctly
        /// </summary>
        [UnityTest]
        public IEnumerator MoveByKeyCode_ResultXIsLessThan_WhenMovesLeft()
        {
            // Arrange
            Vector3 initialPosition = _testGameObject.transform.position;

            // Act
            _characterPhysics.MoveByKeyCode(CharacterPhysics.MoveType.Left);

            // Await
            yield return new WaitForSeconds(WaitSeconds);
            Vector3 result = _characterPhysics.Position;
            
            // Assert
            Assert.IsTrue(result.x < initialPosition.x );
            Assert.IsTrue(Mathf.Approximately(result.y,initialPosition.y) ); //Same Value
            Assert.IsTrue(Mathf.Approximately(result.z,initialPosition.z) ); //Same Value
        }

        /// <summary>
        /// Test to check if the character moves right correctly
        ///
        /// OPTIONAL: Similar tests would be written for MoveType.Up and MoveType.Down
        /// </summary>
        [UnityTest]
        public IEnumerator MoveByKeyCode_ResultXIsGreaterThan_WhenMovesRight_()
        {
            // Arrange
            Vector3 initialPosition = _testGameObject.transform.position;

            // Act
            _characterPhysics.MoveByKeyCode(CharacterPhysics.MoveType.Right);

            // Await
            yield return new WaitForSeconds(WaitSeconds);
            Vector3 result = _characterPhysics.Position;
            
            // Assert
            Assert.IsTrue(result.x > initialPosition.x );
            Assert.IsTrue(Mathf.Approximately(result.y,initialPosition.y) ); //Same Value
            Assert.IsTrue(Mathf.Approximately(result.z,initialPosition.z) ); //Same Value
        }

        /// <summary>
        /// Test to check if the character moves to a specific position correctly
        /// </summary>
        [UnityTest]
        public IEnumerator MoveTo_Result10_10_10_WhenInput10_10_10()
        {
            // Arrange
            Vector3 newPosition = new Vector3(10, 10, 10);

            // Act
            _characterPhysics.MoveTo(newPosition);
            
            // Await
            yield return new WaitForSeconds(WaitSeconds);
            Vector3 result = _characterPhysics.Position;
            
            // Assert
            Assert.AreEqual(newPosition, result);
        }
    }
}