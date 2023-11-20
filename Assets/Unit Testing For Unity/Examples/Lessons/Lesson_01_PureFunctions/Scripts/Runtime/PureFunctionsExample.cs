using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// The Example is the main entry point to the demo
    /// </summary>
    public class PureFunctionsExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            MySystem01_Pure mySystem01Pure = new MySystem01_Pure();
            int value = 2;
            int multiplier = 10;
            
            // Act
            int result = mySystem01Pure.ConvertValue(value, multiplier);
            
            Debug.Log($"Instructions: This Scene has no UI. See Unity Console.");
            Debug.Log($"Result = {result}");
        }

    }
}