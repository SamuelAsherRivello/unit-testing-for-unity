
using UnityEngine;

namespace RMC.UnitTesting.Samples.CharacterBasic
{
    /// <summary>
    /// This performs common math operations on
    /// operands of a and b.
    /// </summary>
    public class CharacterBasic : MonoBehaviour
    {
        public float Speed { get { return _speed;}}
        private const float _speed = 0.5f;

        public enum MoveType
        {
            Left,
            Right,
            Up,
            Down
        }
        
        protected void Update()
        {
            MoveByInput();
        }
        
        public void MoveByInput()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) ||
                Input.GetKeyDown(KeyCode.A))
            {
                MoveByKeyCode(MoveType.Left);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) ||
                Input.GetKeyDown(KeyCode.D))
            {
                MoveByKeyCode(MoveType.Right);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) ||
                Input.GetKeyDown(KeyCode.W))
            {
                MoveByKeyCode(MoveType.Up);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) ||
                Input.GetKeyDown(KeyCode.S))
            {
                MoveByKeyCode(MoveType.Down);
            }
        }

        public Vector3 MoveByKeyCode(MoveType moveType)
        {
            if (moveType == MoveType.Left)
            {
                MoveBy(new Vector3(-_speed, 0, 0));
            }
            if (moveType == MoveType.Right)
            {
                MoveBy(new Vector3(_speed, 0, 0));
            }
            if (moveType == MoveType.Up)
            {
                MoveBy(new Vector3(0,  _speed, 0));
            }
            if (moveType == MoveType.Down)
            {
                MoveBy(new Vector3(0,  -_speed, 0));
            }

            return transform.position;
        }
        
        public Vector3 MoveTo (Vector3 position)
        {
            transform.position = position;
            return transform.position;
        }

        public Vector3 MoveBy (Vector3 position)
        {
            transform.position = transform.position + position;
            return transform.position;
        }
    }
}