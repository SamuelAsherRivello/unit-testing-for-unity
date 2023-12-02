using UnityEngine;

namespace RMC.UnitTesting.Examples.TDD
{
	/// <summary>
	/// The input for the cpu using a <see cref="Paddle"/>
	/// </summary>
	public class PaddleInputCpu : PaddleInputBase
	{
		//  Events ----------------------------------------


		//  Properties ------------------------------------

		//  Fields ----------------------------------------


		//  Unity Methods ---------------------------------
		protected void Start()
		{

		}

		//  Methods ---------------------------------------
		public override void Tick()
		{
			if (Ball.Velocity.x < 0)
			{
				return;
			}
			
			if (transform.position.y < Ball.transform.position.y)
			{
				transform.position += new Vector3(0, _speed, 0) * Time.deltaTime;
			}
			else if (transform.position.y > Ball.transform.position.y)
			{
				transform.position += new Vector3(0, -_speed, 0) * Time.deltaTime;
			}
		}


		//  Event Handlers --------------------------------


	}
}
