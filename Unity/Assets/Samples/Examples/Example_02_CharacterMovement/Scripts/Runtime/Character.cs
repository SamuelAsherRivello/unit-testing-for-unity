
using UnityEngine;

namespace RMC.UnitTesting.Samples.CharacterMovement
{
    /// <summary>
    /// This performs common math operations on
    /// operands of a and b.
    /// </summary>
    public class Character : MonoBehaviour
    {
        public float Speed { get { return _speed;}}
        private const float _speed = 0.5f;
        
        protected void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                MoveByKeyCode(KeyCode.LeftArrow);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                MoveByKeyCode(KeyCode.RightArrow);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                MoveByKeyCode(KeyCode.UpArrow);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveByKeyCode(KeyCode.DownArrow);
            }
        }

        public Vector3 MoveByKeyCode(KeyCode keyCode)
        {
            if (keyCode == KeyCode.LeftArrow)
            {
                MoveBy(new Vector3(-_speed, 0, 0));
            }
            if (keyCode == KeyCode.RightArrow)
            {
                MoveBy(new Vector3(_speed, 0, 0));
            }
            if (keyCode == KeyCode.UpArrow)
            {
                MoveBy(new Vector3(0,  -_speed, 0));
            }
            if (keyCode == KeyCode.DownArrow)
            {
                MoveBy(new Vector3(0,  _speed, 0));
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