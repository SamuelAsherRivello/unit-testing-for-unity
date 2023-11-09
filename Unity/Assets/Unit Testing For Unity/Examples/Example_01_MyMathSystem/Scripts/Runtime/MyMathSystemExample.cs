using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Samples.MyMathSystem
{
    /// <summary>
    /// The Example is the main entry point to the demo
    /// </summary>
    public class MyMathSystemExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            MyMathSystem myMathSystem = new MyMathSystem();

            int a = 5;
            int b = 10;
            int result = myMathSystem.Add(a, b);
            
            Debug.Log($"Instructions: This Scene has no UI. See Unity Console.");
            Debug.Log($"Result = {result}");
        }

    }
}