
using UnityEngine;

namespace RMC.UnitTesting.Examples.Addressables
{
    /// <summary>
    /// Represent ann addressable 
    /// </summary>
    public class Tree : MonoBehaviour
    {
        [SerializeField] 
        public Transform _leaves;
        
        [SerializeField] 
        public Transform _trunk;
        
        public int Grow (int height)
        {
            return height + 1;
        }
    }
}