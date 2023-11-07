using NUnit.Framework;

namespace RMC.UnitTesting.Samples.MyDataLoader
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Samples.MyDataLoader")]
    public class MyDataLoaderTest
    {
        private static int[] ValuesA = new int[] { -1, -2, -3, 0, 1, 2, 3 };
        private static int[] ValuesB = new int[] { -1, -2, -3, 0, 1, 2, 3 };
        
        [Test]
        public void Load_ResultIsHelloWorld_WhenIsLoaded()
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
            
            // Assert
            Assert.That(result, Is.EqualTo("Hello World!"));
        }
        
    }
}