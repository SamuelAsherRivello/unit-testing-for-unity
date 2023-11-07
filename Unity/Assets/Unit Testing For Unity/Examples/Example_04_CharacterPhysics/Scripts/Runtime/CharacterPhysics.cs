using UnityEngine;

namespace RMC.UnitTesting.Samples.CharacterPhysics
{
    /// <summary>
    /// This class will handle Unity specific logic
    /// </summary>
    public class CharacterPhysicsMb : MonoBehaviour
    {
        private CharacterPhysics _characterPhysics;

        private void Awake()
        {
            _characterPhysics = new CharacterPhysics(this);
        }
        
        private void Update()
        {
            _characterPhysics.MoveByInput();
        }
    }

   /// <summary>
   /// This class will be easier to test and does not depend on MonoBehaviour
   /// </summary>
    public class CharacterPhysics
    {
        public float Speed { get { return _speed;}}
        private const float _speed = 0.5f;

        private CharacterPhysicsMb _characterMB;

        public CharacterPhysics(CharacterPhysicsMb characterMB)
        {
            _characterMB = characterMB;
        }

        public enum MoveType
        {
            Left,
            Right,
            Up,
            Down
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
                MoveBy(new Vector3(0, _speed, 0));
            }
            if (moveType == MoveType.Down)
            {
                MoveBy(new Vector3(0, -_speed, 0));
            }

            return _characterMB.transform.position;
        }
        
        public Vector3 MoveTo(Vector3 position)
        {
            _characterMB.transform.position = position;
            return _characterMB.transform.position;
        }

        public Vector3 MoveBy(Vector3 position)
        {
            _characterMB.transform.position += position;
            return _characterMB.transform.position;
        }
    }
}
