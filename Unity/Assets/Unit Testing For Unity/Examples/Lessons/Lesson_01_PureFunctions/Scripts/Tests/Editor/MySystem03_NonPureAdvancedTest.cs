using System;
using NSubstitute;
using NUnit.Framework;

// ReSharper disable once ExpressionIsAlwaysNull
namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.PureFunctions")]
    public class MySystem03_NonPureAdvancedTest
    {
        /// <summary>
        /// TEST DOUBLES: Here we are using **NO** Test Double
        ///
        /// DEFINITION: Let's call this the 'standard' 
        /// </summary>
        [Test]
        public void EX_00_STANDARD_ConvertValue_ResultIs40_WhenInputIs_4()
        {
            // Arrange
            int value = 4;
            int multiplier = 10;
            IConverter converter = new Converter(multiplier);
            MySystem03_NonPureAdvanced system = new MySystem03_NonPureAdvanced(converter);

            // Act
            int result = system.ConvertValue(value);

            // Assert
            Assert.That(result, Is.EqualTo(40));
        }

        /// <summary>
        /// TEST DOUBLES: Here we are using **DUMMY** Test Double
        ///
        /// DEFINITION: The Dummy is a Test Double that is never used in the TESTED method
        /// </summary>
        [Test]
        public void EX_01_DUMMY_LastResult_ReturnsNegative1_WhenDefault()
        {
            // Arrange
            IConverter converter = null;
            MySystem03_NonPureAdvanced system = new MySystem03_NonPureAdvanced(converter);

            // Act
            int result = system.LastResult;

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }
        
        /// <summary>
        /// TEST DOUBLES: Here we are using **STUB** Test Double
        ///
        /// DEFINITION: A STUB is a Test Double that is configured to return a specific value
        /// </summary>
        [Test]
        public void EX_02_STUB_ConvertValue_ThrowsException_WhenConverterIsNull()
        {
            // Arrange
            int value = 4;
            IConverter converter = null; //Testing a specific value, (null or not) is a STUB
            MySystem03_NonPureAdvanced system = new MySystem03_NonPureAdvanced(converter);

            // Assert
            Assert.Throws<NullReferenceException>(() =>
            {
                // Act
                system.ConvertValue(value);
            });
        }

        /// <summary>
        /// TEST DOUBLES: Here we are using a **SPY** Test Double
        ///
        /// DEFINITION: A Spy Test Double is a Test Double that
        ///             confirms that a method was called
        /// </summary>
        [Test]   
        public void EX_03_SPY_ConvertValue_ConvertValueReceived1_WhenAnyArgs()
        {
            // Arrange
            int value = 3;
            IConverter converter = Substitute.For<IConverter>();
            MySystem03_NonPureAdvanced system = new MySystem03_NonPureAdvanced(converter);

            // Act
            system.ConvertValue(value);

            // Assert
            converter.Received(1).ConvertValue(Arg.Any<int>());
        }
        
        
        /// <summary>
        /// TEST DOUBLES: Here we are using a **MOCK** Test Double
        ///
        /// DEFINITION: A Mock Test Double is a Test Double that is
        ///             configured to return a specific value
        /// </summary>
        [Test]
        public void EX_04_MOCK_ConvertValue_ResultIs30_WhenInputIs_3()
        {
            // Arrange
            int value = 3;
            int multiplier = 10;
            IConverter converter = Substitute.For<IConverter>();
            converter.ConvertValue(Arg.Any<int>()).Returns(value * multiplier);
            MySystem03_NonPureAdvanced system = new MySystem03_NonPureAdvanced(converter);

            // Act
            int result = system.ConvertValue(value);

            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        

        /// <summary>
        /// TEST DOUBLES: Here we are using **FAKE** Test Double
        ///
        /// DEFINITION: A Fake Test Double is a 'real' implementation
        ///             but one that is not used in production
        /// </summary>

        public class FakeConverter : IConverter
        {
            public int LastResult { get; private set; }
            
            public int ConvertValue(int value)
            {
                LastResult = value * 10;
                return LastResult;
            }
        }
        
        [Test]
        public void EX_05_FAKE_ConvertValue_ResultIs40_WhenInputIs_4()
        {
            // Arrange
            int value = 4;
            IConverter converter = new FakeConverter();
            MySystem03_NonPureAdvanced system = new MySystem03_NonPureAdvanced(converter);

            // Act
            int result = system.ConvertValue(value);

            // Assert
            Assert.That(result, Is.EqualTo(40));
        }
    }
}