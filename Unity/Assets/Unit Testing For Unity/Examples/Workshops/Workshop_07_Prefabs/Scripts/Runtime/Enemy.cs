using UnityEngine;

namespace RMC.UnitTesting.Examples.Prefabs
{
    /// <summary>
    /// This class will handle Unity specific logic
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class Enemy : MonoBehaviour
    {
        [SerializeField] 
        public Rigidbody Rigidbody;
        
        private void Awake()
        {
    
        }
        
        private void Update()
        {
        }
    }

}
