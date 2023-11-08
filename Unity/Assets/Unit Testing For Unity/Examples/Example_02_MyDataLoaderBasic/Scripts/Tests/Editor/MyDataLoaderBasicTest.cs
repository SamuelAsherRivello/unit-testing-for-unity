using NUnit.Framework;
using UnityEngine;

#pragma warning disable CS4014 // Ignore await warning
namespace RMC.UnitTesting.Samples.MyDataLoaderBasic
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
            MyDataLoaderBasic myDataLoader = new MyDataLoaderBasic();
            
            myDataLoader.OnLoaded.AddListener((string result) =>
            {
                // Assert
                Assert.That(result.Contains("DOCTYPE"), Is.True);
            });
            
            // Act
            myDataLoader.LoadAsync(_url);
        }
    }
}