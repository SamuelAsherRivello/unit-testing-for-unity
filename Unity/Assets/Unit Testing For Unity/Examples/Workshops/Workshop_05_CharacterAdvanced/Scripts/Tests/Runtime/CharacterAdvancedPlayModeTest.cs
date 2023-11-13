using NUnit.Framework;
using UnityEngine;


namespace RMC.UnitTesting.Examples.CharacterAdvanced
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Samples.CharacterAdvanced")]
    public class CharacterAdvancedPlayModeTest
    {
        private GameObject _testGameObject;
        private CharacterAdvanced _characterAdvanced;

        /// <summary>
        /// Setup method to initialize the test environment before each test is run
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _testGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _testGameObject.name = "TestGameObject";
            CharacterAdvancedMb characterAdvancedMb  = _testGameObject.AddComponent<CharacterAdvancedMb>();
            _characterAdvanced = new CharacterAdvanced(characterAdvancedMb);
        }

        /// <summary>
        /// Teardown method to cleanup the test environment after each test has run
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(_testGameObject);
            _testGameObject = null;
            _characterAdvanced = null;
            
        }

        /// <summary>
        /// Test to check if the character moves left correctly
        /// </summary>
        [Test]
        public void MoveByKeyCode_ResultMovesLeft_WhenMovesLeft()
        {
            // Arrange
            Vector3 initialPosition = _testGameObject.transform.position;
            Vector3 expectedPosition = initialPosition + new Vector3(-_characterAdvanced.Speed, 0, 0);

            // Act
            Vector3 newPosition = _characterAdvanced.MoveByKeyCode(CharacterAdvanced.MoveType.Left);

            // Assert
            Assert.AreEqual(expectedPosition, newPosition);
        }

        /// <summary>
        /// Test to check if the character moves right correctly
        ///
        /// OPTIONAL: Similar tests would be written for MoveType.Up and MoveType.Down
        /// </summary>
        [Test]
        public void MoveByKeyCode_ResultMovesRight_WhenMovesRight()
        {
            // Arrange
            Vector3 initialPosition = _testGameObject.transform.position;
            Vector3 expectedPosition = initialPosition + new Vector3(_characterAdvanced.Speed, 0, 0);

            // Act
            Vector3 newPosition = _characterAdvanced.MoveByKeyCode(CharacterAdvanced.MoveType.Right);

            // Assert
            Assert.AreEqual(expectedPosition, newPosition);
        }

        /// <summary>
        /// Test to check if the character moves to a specific position correctly
        /// </summary>
        [Test]
        public void MoveTo_Result10_10_10_WhenInput10_10_10()
        {
            // Arrange
            Vector3 newPosition = new Vector3(10, 10, 10);

            // Act
            Vector3 returnedPosition = _characterAdvanced.MoveTo(newPosition);

            // Assert
            Assert.AreEqual(newPosition, returnedPosition);
        }

        /// <summary>
        /// Test to check if the character moves by a specific offset correctly
        /// </summary>
        [Test]
        public void MoveBy_Result01_01_01_WhenInput01_01_01()
        {
            // Arrange
            Vector3 offset = new Vector3(1, 1, 1);
            Vector3 initialPosition = _testGameObject.transform.position;
            Vector3 expectedPosition = initialPosition + offset;

            // Act
            Vector3 returnedPosition = _characterAdvanced.MoveBy(offset);

            // Assert
            Assert.AreEqual(expectedPosition, returnedPosition);
        }
    }
}