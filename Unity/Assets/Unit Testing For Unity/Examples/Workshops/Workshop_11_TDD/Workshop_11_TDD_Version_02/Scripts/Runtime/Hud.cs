using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.UnitTesting.Examples.TDD
{
	/// <summary>
	/// Wrap the UI Document with convenient getters
	/// </summary>
	public class Hud : MonoBehaviour
	{
		//  Events ----------------------------------------

		//  Properties ------------------------------------
		public Label ScoreLabelLeft
		{
			get
			{
				return _uiDocument.rootVisualElement.Q<Label>("ScoreLabelLeft");
			}
		}

		public Label ScoreLabelRight
		{
			get
			{
				return _uiDocument.rootVisualElement.Q<Label>("ScoreLabelRight");
			}
		}
		
		//  Fields ----------------------------------------
		[SerializeField]
		private UIDocument _uiDocument;
		
		//  Unity Methods ---------------------------------

		//  Methods ---------------------------------------

		//  Event Handlers --------------------------------
	}
}
