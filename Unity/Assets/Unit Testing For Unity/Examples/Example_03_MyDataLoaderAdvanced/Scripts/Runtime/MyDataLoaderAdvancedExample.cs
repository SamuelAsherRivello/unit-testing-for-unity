using System.Diagnostics.CodeAnalysis;
using UnityEngine;

#pragma warning disable CS4014 // Ignore await warning
namespace RMC.UnitTesting.Samples.MyDataLoaderAdvanced
{
    /// <summary>
    /// The Example is the main entry point to the demo
    /// </summary>
    public class MyDataLoaderAdvancedExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            string result = "";
            MyDataLoaderAdvanced myDataLoader = new MyDataLoaderAdvanced();
            
            //Load the page contents from a dummy page. The page contents are not important.
            string url = "https://github.com/SamuelAsherRivello/unit-testing-for-unity/";
            
            myDataLoader.OnLoaded.AddListener((string data) =>
            {
                result = data;
                //Any length > 0 is considered a successful load
                Debug.Log($"Result.Length = {result.Length}");
            });
            
            myDataLoader.LoadAsync(url);
            
            Debug.Log($"This Scene has no UI. It has only console logging.");
        }

    }
}