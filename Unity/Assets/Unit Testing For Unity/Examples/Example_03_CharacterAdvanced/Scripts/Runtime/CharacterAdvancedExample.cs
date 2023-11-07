using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Samples.CharacterAdvanced
{
    /// <summary>
    /// This example is the main entry point for the
    /// <see cref="CharacterAdvanced"/> demonstration
    /// </summary>
    public class CharacterAdvancedExample: MonoBehaviour
    {
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.name = "CharacterAdvanced";
            CharacterAdvancedMb characterAdvancedMb  = go.AddComponent<CharacterAdvancedMb>();
            CharacterAdvanced characterAdvanced = new CharacterAdvanced(characterAdvancedMb);

            Vector3 position = new Vector3(0, 0, 0);
            Vector3 result = characterAdvanced.MoveTo(position);
            
            Debug.Log($"Instructions: Move With Arrow Keys");
            Debug.Log($"Result = {result}");
        }

    }
}