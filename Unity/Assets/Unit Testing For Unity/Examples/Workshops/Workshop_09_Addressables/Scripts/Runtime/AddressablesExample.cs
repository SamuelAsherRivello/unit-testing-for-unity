using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace RMC.UnitTesting.Examples.Addressable
{
    /// <summary>
    /// Create a custom AssetReference for a Tree
    /// </summary>
    [Serializable]
    public class AssetReferenceTree : AssetReferenceT<Tree>
    {
        public AssetReferenceTree(string guid) : base(guid)
        {
        }
    }
    
    /// <summary>
    /// The Example is the main entry point to the demo
    /// </summary>
    public class AddressablesExample: MonoBehaviour
    {
        [SerializeField]
        private AssetReference _assetReferenceTree;

        [ExcludeFromCodeCoverage]
        protected async void Awake ()
        {
            Debug.Log($"Instructions: See Tree added to Scene View. See Console for logs.");
            
            AsyncOperationHandle<GameObject> operation = _assetReferenceTree.LoadAssetAsync<GameObject>();
            await operation.Task;

            if (operation.Status == AsyncOperationStatus.Succeeded)
            {
                GameObject instantiatedObject = operation.Result;
                Tree tree = instantiatedObject.GetComponent<Tree>();

                var gameObject = tree.gameObject;
                Instantiate(gameObject);

                Debug.Log($"Result = {tree}");
            }
            else
            {
                Debug.LogError("Failed to instantiate the asset.");
            }
       
            // Release the handle to free up resources
            Addressables.Release(operation);

        }

    }
}