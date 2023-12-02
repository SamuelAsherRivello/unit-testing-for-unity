using System.Collections.Generic;
using UnityEngine;

namespace RMC.UnitTesting.Examples.TDD
{
	/// <summary>
	/// The shared paddle behaviour for both Human and CPU
	/// </summary>
	public class Paddle : MonoBehaviour
	{
		//  Events ----------------------------------------

		//  Properties ------------------------------------

		//  Fields ----------------------------------------
		[SerializeReference]
		private PaddleInputBase _paddleInput;

		[SerializeField]
		private Ball _ball;
		
		//  Unity Methods ---------------------------------
		protected void Start()
		{
			_paddleInput.Ball = _ball;
		}


		protected void Update()
		{
			_paddleInput.Tick();
		}


		//  Methods ---------------------------------------
		public void ResetPosition()
		{
			Vector3 nextPosition = transform.position;
			nextPosition.y = 0;
			transform.position = nextPosition;
		}

		//  Event Handlers --------------------------------
	}
}
