using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

//Use namespace "Addressable" not "Addressables" to avoid conflicts with Unity Addressables
namespace RMC.UnitTesting.Examples.Addressable 
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Examples.Addressables")]
    public class AddressablesTest
    {
        
        [Test]
        public void Setup01_ResourceManager_IsNotNull_WhenDefault()
        {
            // Arrange
            
            // Act
        
            // Await
            Assert.That(Addressables.ResourceManager, Is.Not.Null);

        }
        
        [Test]
        public void Setup02_LoadAssetAsync_KeyOfDefault_IsFound()
        {
            // Arrange
            bool isSuccess = true;
            string key = "default";
            
            // Act
            try
            {
                Addressables.LoadAssetAsync<GameObject>(key);
            }
            catch
            {
                //Debug.LogError(e);
                isSuccess = false;
            }
            // Assert
            Assert.That(isSuccess, Is.True, $"Addressables key of {key} does not exist. Make key of {key} per https://docs.unity3d.com/Packages/com.unity.addressables@2.2/manual/get-started-make-addressable.html");

        }
        
        
        [Test]
        public void Tree_IsNotNull_WhenLoaded()
        {
            // Arrange
            
            // Act
            AsyncOperationHandle<GameObject> asyncOperationHandle = 
                Addressables.LoadAssetAsync<GameObject>("default");
        
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
