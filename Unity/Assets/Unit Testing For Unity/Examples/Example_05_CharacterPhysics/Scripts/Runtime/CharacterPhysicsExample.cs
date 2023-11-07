using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Samples.CharacterPhysics
{
    /// <summary>
    /// This example is the main entry point for the
    /// <see cref="CharacterPhysics"/> demonstration
    /// </summary>
    public class CharacterPhysicsExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.name = "CharacterPhysics";
            CharacterPhysicsMb characterPhysicsMb  = go.AddComponent<CharacterPhysicsMb>();
            CharacterPhysics characterPhysics = new CharacterPhysics(characterPhysicsMb);

            Vector3 position = new Vector3(0, 0, 0);
            Vector3 result = characterPhysics.MoveTo(position);
            
            Debug.Log($"Instructions: Move With Arrow Keys");
            Debug.Log($"Result = {result}");
        }

    }
}