using NUnit.Framework;
using UnityEngine;

#pragma warning disable CS4014 // Ignore await warning
namespace RMC.UnitTesting.Examples.MyDataLoaderBasic
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.MyDataLoaderBasic")]
    public class MyDataLoaderBasicTest
    {
        private const string _url = "https://github.com/SamuelAsherRivello/unit-testing-for-unity/";

        [Test]
        public void LoadAsync_ResultContainsDOCTYPE_WhenIsLoaded()
        {
            // Arrange
            string expectedResult = "DOCTYPE"; // Silly test, to prove we loaded a webpage
            MyDataLoaderBasic myDataLoader = new MyDataLoaderBasic();
            
            myDataLoader.OnLoaded.AddListener((string result) =>
            {
                // Assert
                Assert.That(result.Contains(expectedResult), Is.True);
            });
            
            // Act
            myDataLoader.LoadAsync(_url);
        }
    }
}