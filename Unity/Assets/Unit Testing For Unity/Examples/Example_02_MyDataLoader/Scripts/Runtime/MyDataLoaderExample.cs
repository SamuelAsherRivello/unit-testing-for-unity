using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Samples.MyDataLoader
{
    /// <summary>
    /// The Example is the main entry point to the demo
    /// </summary>
    public class MyDataLoaderExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected async void Awake ()
        {
            MyDataLoader myDataLoader = new MyDataLoader();
            string url = "https://www.google.com/anyurl/";
            string result = "";
            
            myDataLoader.OnLoaded.AddListener((string data) =>
            {
                result = data;
                Debug.Log($"Result = {result}");
            });
            myDataLoader.Load(url);
            
            
            Debug.Log($"This Scene has no UI. It has only console logging.");
        }

    }
}