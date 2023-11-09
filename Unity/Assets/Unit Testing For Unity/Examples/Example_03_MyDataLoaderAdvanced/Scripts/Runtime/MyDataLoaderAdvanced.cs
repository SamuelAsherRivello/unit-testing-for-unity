using System;
using UnityEngine.Events;
using UnityEngine.Networking;
using System.Threading.Tasks;
using RMC.UnitTesting.Shared.Networking;
using UnityEngine;

namespace RMC.UnitTesting.Samples.MyDataLoaderAdvanced
{
    public class StringUnityEvent : UnityEvent<string>{}
    
    /// <summary>
    /// Increase Testability: Extract the network service to an interface.
    /// </summary>
    public interface INetworkService
    {
        Task<string> LoadAsync(string url);
    }

    /// <summary>
    /// Increase Testability: Extract the network service to an interface.
    /// </summary>
    public class UnityWebRequestNetworkService : INetworkService
    {
        public async Task<string> LoadAsync(string url)
        {
            UnityWebRequest www = UnityWebRequest.Get(url);
            await www.SendWebRequest();
            return www.downloadHandler.text;
        }
    }
    
    /// <summary>
    /// Load text data from a web url.
    /// This is not a real-world example.
    /// It is a simple demo of asynchronous operations.
    /// </summary>
    public class MyDataLoaderAdvanced
    {
        private readonly INetworkService networkService;
        public StringUnityEvent OnLoaded = new StringUnityEvent();
        public bool IsLoaded { get { return Result != string.Empty ; }}
        public string Result { get; private set; }

        public MyDataLoaderAdvanced(INetworkService networkService)
        {
            Result = string.Empty;
            this.networkService = networkService;
        }

        public async Task LoadAsync(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException();
            }
            Result = string.Empty;
            Result = await networkService.LoadAsync(url);
            OnLoaded.Invoke(Result);
        }
    }
}