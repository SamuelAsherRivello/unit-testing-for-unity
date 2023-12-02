
using NUnit.Framework;
using UnityEngine;

namespace RMC.UnitTesting.Examples.TDD
{
    /// <summary>
    /// Empty Template, replace as you like
    /// </summary>
    public class PongGame
    {
        public Hud Hud { get; set; }
        public Ball Ball { get; set; }
        public Paddle PaddleLeft { get; set; }
        public Paddle PaddleRight { get; set; }

        private int ScoreLeft = 1;
        private int ScoreRight = 2;
        
        //  Methods ---------------------------------------

        
        public void InitializeGame ()
        {
            Assert.IsNotNull(Hud);
            Assert.IsNotNull(Ball);
            Assert.IsNotNull(PaddleLeft);
            Assert.IsNotNull(PaddleRight);

            Ball.OnCollisionEnteredWithPaddle.AddListener(Ball_OnCollisionEnteredWithPaddle);
            Ball.OnCollisionEnteredWithWall.AddListener(Ball_OnCollisionEnteredWithWall);
        }

        public void StartGame ()
        {
            StartNextBall();
        }
        
        public void StartNextBall ()
        {
            RefreshScores();
            PaddleLeft.ResetPosition();
            PaddleRight.ResetPosition();
            Ball.ResetPosition();
            Ball.ResetVelocity();
        }

        private void RefreshScores()
        {
            Hud.ScoreLabelLeft.text = $"Score:{ScoreLeft.ToString():000}";
            Hud.ScoreLabelRight.text = $"Score:{ScoreRight.ToString():000}";
        }

        //  Event Handlers --------------------------------
        private void Ball_OnCollisionEnteredWithWall(Wall wall)
        {
            //TODO: Play sound
            
            //
            if (wall.IsAGoal)
            {
                if (wall.IsLeft)
                {
                    ScoreRight++;
                    RefreshScores();
                }
                else
                {
                    ScoreLeft++;
                    RefreshScores();
                }
         
                StartGame();
            }
        }

        private void Ball_OnCollisionEnteredWithPaddle(Paddle paddle)
        {
            //TODO: Play sound
            
            //
        }
    }
}