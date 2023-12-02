using UnityEngine;

namespace RMC.UnitTesting.Examples.TDD
{
	/// <summary>
	/// Wall for 4 sides of the screen
	/// </summary>
	public class Wall : MonoBehaviour
	{
		//  Events ----------------------------------------

		//  Properties ------------------------------------
		public bool IsAGoal { get { return _isAGoal; } }
		public bool IsLeft { get { return _isAGoal; } }
	
		//  Fields ----------------------------------------
		[SerializeField] 
		private bool _isLeft = false;

		[SerializeField] 
		private bool _isAGoal = false;
		
		//  Unity Methods ---------------------------------

		//  Methods ---------------------------------------

		//  Event Handlers --------------------------------
	}
}
