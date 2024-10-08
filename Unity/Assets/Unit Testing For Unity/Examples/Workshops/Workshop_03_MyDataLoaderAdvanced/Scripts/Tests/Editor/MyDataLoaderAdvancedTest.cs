using System.Collections;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;

#pragma warning disable CS4014 // Ignore await warning
namespace RMC.UnitTesting.Examples.MyDataLoaderAdvanced
{
    public static class TaskExtensions
    {
        public static IEnumerator AsIEnumerator(this Task task)
        {
            while (!task.IsCompleted) yield return null;
            // if task is faulted, throws the exception
            task.GetAwaiter ().GetResult ();
        }
    }
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category ("RMC.UnitTesting.Examples.MyDataLoaderAdvanced")]
    public class MyDataLoaderAdvancedTest
    {
        private const string _url = "https://github.com/SamuelAsherRivello/unit-testing-for-unity/";
        private const string _urlInvalid = "";

        [Test]
        public void LoadAsync_ResultContainsDOCTYPE_WhenIsLoaded()
        {
            // Arrange
            string expectedResult = "DOCTYPE"; // Silly test, to prove we loaded a webpage
            UnityWebRequestNetworkService networkService = new UnityWebRequestNetworkService();
            MyDataLoaderAdvanced myDataLoader = new MyDataLoaderAdvanced(networkService);
            
            myDataLoader.OnLoaded.AddListener((string result) =>
            {
                // Assert
                Assert.That(result.Contains(expectedResult), Is.True);
            });
            
            // Act
            myDataLoader.LoadAsync(_url);
        }

        [Test]
        public void MockLoadAsync_ResultContainsMockedData_WhenIsLoaded()
        {
            // Arrange
            string expectedResult = "MockedData";
            var networkService = Substitute.For<INetworkService>();
            networkService.LoadAsync(Arg.Any<string>()).Returns(expectedResult);
            MyDataLoaderAdvanced myDataLoader = new MyDataLoaderAdvanced(networkService);

            myDataLoader.OnLoaded.AddListener((string result) =>
            {
                // Assert
                Assert.That(result.Contains(expectedResult), Is.True);
            });

            // Act
            myDataLoader.LoadAsync(_url);
        }

        public async Task MockLoadAsync_ThrowsError_WhenUrlIsInvalid()
        {
            ////////////////////////////////////////////////////
            // NOTE: We can use NSubstitute in EditMode
            // SPECIFIC PACKAGE ALREADY INCLUDED IN PROJECT:
            //      https://github.com/Thundernerd/Unity3D-NSubstitute/tree/main
            // GENERAL GUIDE:
            //      https://nsubstitute.github.io/help/creating-a-substitute/#substituting_infrequently_and_carefully_for_classes
            ////////////////////////////////////////////////////
   
            // Arrange
            string expectedResult = "MockedData";
            var networkService = Substitute.For<INetworkService>();
            networkService.LoadAsync(Arg.Any<string>()).Returns(expectedResult);
            MyDataLoaderAdvanced myDataLoader = new MyDataLoaderAdvanced(networkService);
            
            myDataLoader.OnLoaded.AddListener((string result) =>
            {
                //TODO: This must throw error
                // Assert
                Assert.That(result.Contains(expectedResult), Is.True);
            });
            
            // Act
            await myDataLoader.LoadAsync(_urlInvalid);

        }

    }
}