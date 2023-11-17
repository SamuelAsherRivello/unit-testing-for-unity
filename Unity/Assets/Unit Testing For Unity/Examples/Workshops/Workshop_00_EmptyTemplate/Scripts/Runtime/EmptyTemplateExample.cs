using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Examples.EmptyTemplate
{
    /// <summary>
    /// The Example is the main entry point to the demo
    /// </summary>
    public class EmptyTemplateExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            EmptyTemplate empty = new EmptyTemplate();

            // TODO: Call a method on the class here
            string result = empty.MyMethod("hello world");
            
            Debug.Log($"Instructions: This Scene has no UI. See Unity Console.");
            Debug.Log($"Result = {result}");
        }

    }
}