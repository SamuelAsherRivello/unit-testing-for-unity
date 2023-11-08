using UnityEngine.Events;
using UnityEngine.Networking;
using System.Threading.Tasks;
using RMC.UnitTesting.Shared.Networking;

namespace RMC.UnitTesting.Samples.MyDataLoaderBasic
{
    public class StringUnityEvent : UnityEvent<string>{}
    
    /// <summary>
    /// This performs common math operations on
    /// operands of a and b.
    /// </summary>
    public class MyDataLoaderBasic
    {
        public StringUnityEvent OnLoaded = new StringUnityEvent();
        
        public string Result { get; private set; }
        public bool IsLoaded { get { return Result != string.Empty ; }}
        
        public async Task LoadAsync (string url)
        {
            Result = string.Empty;
            UnityWebRequest www = UnityWebRequest.Get(url);
            await www.SendWebRequest();
            Result = www.downloadHandler.text;
            OnLoaded.Invoke(Result);
        }
    }
}