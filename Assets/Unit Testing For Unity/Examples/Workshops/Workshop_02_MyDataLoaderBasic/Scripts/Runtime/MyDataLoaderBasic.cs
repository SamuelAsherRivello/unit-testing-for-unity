using System;
using UnityEngine.Events;
using UnityEngine.Networking;
using System.Threading.Tasks;
using RMC.UnitTesting.Shared.Networking;

namespace RMC.UnitTesting.Examples.MyDataLoaderBasic
{
    public class StringUnityEvent : UnityEvent<string>{}
    
    /// <summary>
    /// Load text data from a web url.
    /// This is not a real-world example.
    /// It is a simple demo of asynchronous operations.
    /// </summary>
    public class MyDataLoaderBasic
    {
        public StringUnityEvent OnLoaded = new StringUnityEvent();
        
        public string Result { get; private set; }
        public bool IsLoaded { get { return Result != string.Empty ; }}

        public MyDataLoaderBasic()
        {
            Result = string.Empty;
        }
        
        public async Task LoadAsync (string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException();
            }
            Result = string.Empty;
            UnityWebRequest www = UnityWebRequest.Get(url);
            await www.SendWebRequest();
            Result = www.downloadHandler.text;
            OnLoaded.Invoke(Result);
        }
    }
}