using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace RMC.UnitTesting.Examples.Addressables
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

            AsyncOperationHandle<GameObject> operation = _assetReferenceTree.LoadAssetAsync<GameObject>();
            await operation.Task;

            Tree tree = operation.Result.GetComponent<Tree>();
            Debug.Log($"Instructions: This Scene has no UI. See Unity Console.");
            Debug.Log($"Result = {tree}");
        }

    }
}