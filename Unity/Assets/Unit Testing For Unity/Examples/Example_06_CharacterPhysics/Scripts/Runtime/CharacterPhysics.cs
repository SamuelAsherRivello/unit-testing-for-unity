using UnityEditor.SceneManagement;
using UnityEngine;

namespace RMC.UnitTesting.Samples.CharacterPhysics
{
    /// <summary>
    /// This class will handle Unity specific logic
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class CharacterPhysicsMb : MonoBehaviour
    {
        public Rigidbody Rigidbody
        {
            get { return _rigidbody; }
        }

        private Rigidbody _rigidbody;
        public CharacterPhysics CharacterPhysics { set; get; }

        private void Awake()
        {
            //////////////////////////////////////////////
            // USE PHYSICS
            _rigidbody = gameObject.GetComponent<Rigidbody>();
            if (_rigidbody == null)
            {
                _rigidbody = gameObject.AddComponent<Rigidbody>();
            }
            _rigidbody.isKinematic = false;
            _rigidbody.useGravity = false;
            //////////////////////////////////////////////
    
        }
        
        private void Update()
        {
            CharacterPhysics.MoveByInput();
        }
    }

   /// <summary>
   /// This class will be easier to test and does not depend on MonoBehaviour
   /// </summary>
    public class CharacterPhysics
    {
        public float Speed { get { return _speed;}}
        public Vector3 Position { get { return _characterPhysicsMb.transform.position;} }

        private const float _speed = 50f;

        private CharacterPhysicsMb _characterPhysicsMb;

        public CharacterPhysics(CharacterPhysicsMb characterPhysicsMb)
        {
            _characterPhysicsMb = characterPhysicsMb;
            _characterPhysicsMb.CharacterPhysics = this;
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
                AddForce(new Vector3(-_speed, 0, 0));
            }
            if (moveType == MoveType.Right)
            {
                AddForce(new Vector3(_speed, 0, 0));
            }
            if (moveType == MoveType.Up)
            {
                AddForce(new Vector3(0, _speed, 0));
            }
            if (moveType == MoveType.Down)
            {
                AddForce(new Vector3(0, -_speed, 0));
            }

            return _characterPhysicsMb.transform.position;
        }
        
        public Vector3 MoveTo(Vector3 position)
        {
            //////////////////////////////////////////////
            // USE PHYSICS
            _characterPhysicsMb.Rigidbody.MovePosition(position);
            //////////////////////////////////////////////
            
            return _characterPhysicsMb.transform.position;
        }

        public Vector3 AddForce(Vector3 position)
        {
            //////////////////////////////////////////////
            // USE PHYSICS
            _characterPhysicsMb.Rigidbody.AddForce(position);
            //////////////////////////////////////////////
  
            return _characterPhysicsMb.transform.position;
        }
    }
}
