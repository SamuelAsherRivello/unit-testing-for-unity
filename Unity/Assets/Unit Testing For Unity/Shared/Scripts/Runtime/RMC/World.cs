using UnityEngine;

namespace RMC.UnitTesting.Shared
{
	/// <summary>
	/// Reusable background 'world' graphics. 
	/// Toggle elements on/off easily with inspector.
	/// </summary>
	public class World : MonoBehaviour
	{
		//  Events ----------------------------------------

		//  Properties ------------------------------------

		//  Fields ----------------------------------------
		[SerializeField]
		private bool _willShowCanvas = true;

		[SerializeField]
		private Canvas _canvas;

		//  Unity Methods ---------------------------------
		protected void Start()
		{
			_canvas.enabled = _willShowCanvas;
		}
		
		//  Methods ---------------------------------------

		//  Event Handlers --------------------------------
	}
}
