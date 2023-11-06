using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Samples.CharacterMovement
{
    /// <summary>
    /// The Example is the main entry point to the demo
    /// </summary>
    public class CharacterMovementExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Character character = go.AddComponent<Character>();

            Vector3 position = new Vector3(0, 0, 0);
            Vector3 result = character.MoveTo(position);
            
            Debug.Log($"Result = {result}");
        }

    }
}