
using System;
using UnityEngine;

namespace RMC.UnitTesting.Examples.Addressable
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

        protected void Update()
        {
            transform.Rotate(new Vector3 ( 0, Time.deltaTime * 100, 0));
        }
    }
}