using NUnit.Framework;

namespace RMC.UnitTesting.Examples.MyMathSystem
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Examples.MyMathSystem")]
    public class MyMathSystemTest
    {
        /// <summary>
        /// Learn More: Parameterized Tests...
        /// * https://docs.unity3d.com/Packages/com.unity.test-framework@2.0/manual/reference-tests-parameterized.html
        /// </summary>
        private static int[] ValuesA = new int[] { -1, -2, -3, 0, 1, 2, 3 };
        private static int[] ValuesB = new int[] { -1, -2, -3, 0, 1, 2, 3 };
        
        [Test]
        public void Add_ResultIs15_When5And10()
        {
            // Arrange
            MyMathSystem myMathSystem = new MyMathSystem();
            
            // Act
            int sum = myMathSystem.Add(5, 10);
            
            // Assert
            Assert.That(sum, Is.EqualTo(15));
        }
        
        [Test]
        public void Subtract_ResultIs5_When10And5()
        {
            // Arrange
            MyMathSystem myMathSystem = new MyMathSystem();
            
            // Act
            int sum = myMathSystem.Subtract(10, 5);
            
            // Assert
            Assert.That(sum, Is.EqualTo(5));
        }
        
        [Test]
        public void Add_ResultIsCorrect_WhenValues(
            [ValueSource("ValuesA")] int valuesA, 
            [ValueSource("ValuesB")] int valuesB )
        {
            // Arrange
            MyMathSystem myMathSystem = new MyMathSystem();
            
            // Act
            int sum = myMathSystem.Add(valuesA, valuesB);
            
            // Assert
            Assert.That(sum, Is.EqualTo(valuesA + valuesB));
        }
        
        [Test]
        public void Subtract_ResultIsCorrect_WhenValues(
            [ValueSource("ValuesA")] int valuesA, 
            [ValueSource("ValuesB")] int valuesB )
        {
            // Arrange
            MyMathSystem myMathSystem = new MyMathSystem();
            
            // Act
            int sum = myMathSystem.Subtract(valuesA, valuesB);
            
            // Assert
            Assert.That(sum, Is.EqualTo(valuesA - valuesB));
        }
    }
}