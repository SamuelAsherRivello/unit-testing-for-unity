using NUnit.Framework;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace RMC.UnitTesting.Examples.Addressables
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Examples.Addressables")]
    public class AddressablesTest
    {
        [Test]
        public void Tree_IsNotNull_WhenLoaded_()
        {
            // Arrange
            
            // Act
            AsyncOperationHandle<GameObject> asyncOperationHandle = 
                UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>("default");
        
            // Await
            asyncOperationHandle.Completed += operationHandle =>
            {
                // Assert
                Assert.AreEqual(asyncOperationHandle.Status, AsyncOperationStatus.Succeeded);
                
                Tree tree = operationHandle.Result.GetComponent<Tree>();
                Assert.That(tree, Is.Not.Null);
            };

        }
    }
}
