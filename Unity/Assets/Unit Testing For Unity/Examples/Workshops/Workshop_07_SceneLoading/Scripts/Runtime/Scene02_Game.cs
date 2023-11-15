using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace RMC.UnitTesting.Examples.SceneLoading
{
    /// <summary>
    /// This example is the main entry point for the
    /// Scene Loading demonstration
    /// </summary>
    public class Scene02_Game: MonoBehaviour
    {
        [SerializeField] 
        private Hero _hero;
        
        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            Debug.Log($"Instructions: This Scene has no UI. See Unity Console.");
            Debug.Log($"Result = {_hero.name}");

            //Uncomment Exception to see a failing test
            //throw new Exception("Something wrong happens :)");
        }

    }
}