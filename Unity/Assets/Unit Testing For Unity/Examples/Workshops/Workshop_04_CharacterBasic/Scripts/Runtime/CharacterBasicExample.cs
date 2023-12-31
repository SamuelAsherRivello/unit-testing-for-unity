using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Examples.CharacterBasic
{
    /// <summary>
    /// This example is the main entry point for the
    /// <see cref="CharacterBasic"/> demonstration
    /// </summary>
    public class CharacterBasicExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.name = "CharacterBasic";
            CharacterBasic characterBasic = go.AddComponent<CharacterBasic>();

            Vector3 position = new Vector3(0, 0, 0);
            Vector3 result = characterBasic.MoveTo(position);
            
            Debug.Log($"Instructions: Move With Arrow Keys");
            Debug.Log($"Result = {result}");
        }

    }
}