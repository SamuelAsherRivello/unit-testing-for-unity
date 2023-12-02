using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.Assertions;

namespace RMC.UnitTesting.Examples.TDD
{
    /// <summary>
    /// The Example is the main entry point to the demo
    /// </summary>
    public class Scene01_Game: MonoBehaviour
    {
        [SerializeField] 
        private Hud _hud;
        
        [SerializeField] 
        private Ball _ball;
        
        [SerializeField]
        private Paddle _paddleLeft;
        
        [SerializeField]
        private Paddle _paddleRight;

        [ExcludeFromCodeCoverage]
        protected void Awake ()
        {
            //
            PongGame pongGame = new PongGame();
            pongGame.Hud = _hud;
            pongGame.Ball = _ball;
            pongGame.PaddleLeft = _paddleLeft;
            pongGame.PaddleRight = _paddleRight;
            
            //
            Debug.Log($"Instructions: See the in-game UI. See Unity Console.");
            
            //
            pongGame.InitializeGame();
            pongGame.StartGame();
        }
    }
}