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
            MyPureSystem myPureSystem = new MyPureSystem();
            int value = 2;
            int multiplier = 10;
            
            // Act
            int result = myPureSystem.ConvertValue(value, multiplier);
            
            Debug.Log($"Instructions: This Scene has no UI. See Unity Console.");
            Debug.Log($"Result = {result}");
        }

    }
}