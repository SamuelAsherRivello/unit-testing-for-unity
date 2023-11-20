using System.Diagnostics.CodeAnalysis;
using UnityEngine;

#pragma warning disable CS4014 // Ignore await warning
namespace RMC.UnitTesting.Examples.MyDataLoaderBasic
{
    /// <summary>
    /// The Example is the main entry point to the demo
    /// </summary>
    public class MyDataLoaderBasicExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            string result = "";
            MyDataLoaderBasic myDataLoader = new MyDataLoaderBasic();
            
            //Load the page contents from a dummy page. The page contents are not important.
            string url = "https://github.com/SamuelAsherRivello/unit-testing-for-unity/";
            
            myDataLoader.OnLoaded.AddListener((string data) =>
            {
                result = data;
                //Any length > 0 is considered a successful load
                Debug.Log($"Result.Length = {result.Length}");
            });
            
            myDataLoader.LoadAsync(url);
            
            Debug.Log($"Instructions: This Scene has no UI. See Unity Console.");
        }

    }
}