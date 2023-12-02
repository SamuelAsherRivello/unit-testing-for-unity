using System;
using UnityEngine;

namespace RMC.UnitTesting.Examples.TDD
{
	/// <summary>
	/// The input for the cpu using a <see cref="Paddle"/>
	/// </summary>
	public abstract class PaddleInputBase : MonoBehaviour
	{
		//  Events ----------------------------------------

		//  Properties ------------------------------------
		public Ball Ball { get; set; }

		//  Fields ---------------------------------------
		[SerializeField] 
		protected float _speed = 1f;

		//  Unity Methods ---------------------------------

		//  Methods ---------------------------------------
		public virtual void Tick()
		{
			throw new Exception("Must override");
		}


		//  Event Handlers --------------------------------

	}
}
