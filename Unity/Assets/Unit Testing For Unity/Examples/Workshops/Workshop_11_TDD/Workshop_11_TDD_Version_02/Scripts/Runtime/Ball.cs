using UnityEngine;
using UnityEngine.Events;

namespace RMC.UnitTesting.Examples.TDD
{
	public class CollisionEnteredWithWallUnityEvent : UnityEvent<Wall>{}
	public class CollisionEnteredWithPaddleUnityEvent : UnityEvent<Paddle>{}
	
	/// <summary>
	/// The shared paddle behaviour for both Human and CPU
	/// </summary>
	public class Ball : MonoBehaviour
	{
		//  Events ----------------------------------------
		[HideInInspector]
		public CollisionEnteredWithWallUnityEvent OnCollisionEnteredWithWall = 
			new CollisionEnteredWithWallUnityEvent();
		
		[HideInInspector]
		public CollisionEnteredWithPaddleUnityEvent OnCollisionEnteredWithPaddle = 
			new CollisionEnteredWithPaddleUnityEvent();

		//  Properties ------------------------------------
		[SerializeField] 
		private Rigidbody _rigidbody;

		public Vector3 Velocity { get; private set; }
		
		//  Fields ----------------------------------------
		
		//  Unity Methods ---------------------------------
		protected void Update()
		{
			transform.position += Velocity * Time.deltaTime;
		}


		//  Methods ---------------------------------------
		public void ResetPosition()
		{
			transform.position = Vector3.zero;	
		}
		
		public void ResetVelocity()
		{
			_rigidbody.velocity = Vector3.zero;
			_rigidbody.angularVelocity = Vector3.zero;
			_rigidbody.AddForce(RandomVector3(10, 5, 0), ForceMode.Impulse);
			
		}

		private Vector3 RandomVector3(float x, float y, float z)
		{
			return new Vector3(
				Random.Range(-x, x),
				Random.Range(-y, y),
				Random.Range(-z, z)
			);
		}
		
		//  Event Handlers --------------------------------
		private void OnCollisionEnter(Collision collision)
		{
		    // Check if the ball collided with a wall
		    Wall wall = collision.gameObject.GetComponent<Wall>();
		    if (wall!= null)
		    {
		        OnCollisionEnteredWithWall.Invoke(wall);
		    }

		    Paddle paddle = collision.gameObject.GetComponent<Paddle>();
		    if (wall!= null)
		    {
			    OnCollisionEnteredWithPaddle.Invoke(paddle);
		    }
		}
		
	}
}
