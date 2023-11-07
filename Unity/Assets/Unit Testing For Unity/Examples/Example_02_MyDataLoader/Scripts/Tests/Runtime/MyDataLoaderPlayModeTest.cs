using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace RMC.UnitTesting.Samples.MyDataLoader
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.MyDataLoader")]
    public class MyDataLoaderPlayModeTest
    {
        [UnityTest]
        public IEnumerator Load_ResultIsHelloWorld_WhenIsLoaded()
        {
            // Arrange
            MyDataLoader myDataLoader = new MyDataLoader();
            string url = "https://www.google.com/anyurl/";
            string result = "";
            
            // Act
            myDataLoader.OnLoaded.AddListener((string data) =>
            {
                result = data;
            });
            myDataLoader.Load(url);
            
            // Await
            yield return new WaitUntil(() => myDataLoader.IsLoaded);
            
            // Assert
            Assert.That(result, Is.EqualTo("Hello World!"));
        }
    }
}