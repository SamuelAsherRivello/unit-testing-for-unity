using UnityEngine.Events;

namespace RMC.UnitTesting.Samples.MyDataLoader
{
    public class StringUnityEvent : UnityEvent<string>{}
    
    /// <summary>
    /// This performs common math operations on
    /// operands of a and b.
    /// </summary>
    public class MyDataLoader
    {
        public StringUnityEvent OnLoaded = new StringUnityEvent();
        
        public string Result { get; private set; }
        public bool IsLoaded { get { return Result != string.Empty ; }}
        
        public void Load (string url)
        {
            Result = "Hello World!";
            OnLoaded.Invoke(Result);
        }
    }
}