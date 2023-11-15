using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Examples.Prefab
{   
    /// <summary>
    /// This example is the main entry point for the
    /// Scene Loading demonstration
    /// </summary>
    public class Scene01_Intro: MonoBehaviour
    {
        [SerializeField] 
        private Enemy _enemy;
        
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            Debug.Log($"Instructions: This Scene has no UI. See Unity Console.");
            Debug.Log($"Result = {_enemy.name}");
        }

    }
}