
using System.Collections;
using System.Threading.Tasks;
using NUnit.Framework;
using RMC.UnitTesting.Shared.Extensions;
using UnityEngine;
using UnityEngine.TestTools;

#pragma warning disable CS4014 // Ignore await warning
namespace RMC.UnitTesting.Examples.MyDataLoaderBasic
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Samples.MyDataLoaderBasic")]
    public class MyDataLoaderBasicPlayModeTest
    {
        private const string _url = "https://github.com/SamuelAsherRivello/unit-testing-for-unity/";

        [UnityTest]
        public IEnumerator LoadAsync_ResultContainsDOCTYPE_WhenIsLoaded()
        {
            ////////////////////////////////////////////////////
            // SETUP: Allow for async code within a [UnityTest]
            ////////////////////////////////////////////////////
            yield return Run().AsCoroutine();
            async Task Run() 
            {
                ////////////////////////////////////////////////////
                // TEST: Now add the test logic
                ////////////////////////////////////////////////////

                // Arrange
                string expectedResult = "DOCTYPE"; // Silly test, to prove we loaded a webpage
                MyDataLoaderBasic myDataLoader = new MyDataLoaderBasic();

                string result = "";

                // Act
                myDataLoader.OnLoaded.AddListener((string data) => { result = data; });

                // Await
                await myDataLoader.LoadAsync(_url);

                // Assert
                Assert.That(result.Contains(expectedResult), Is.True);
            }
        }
    }
}
