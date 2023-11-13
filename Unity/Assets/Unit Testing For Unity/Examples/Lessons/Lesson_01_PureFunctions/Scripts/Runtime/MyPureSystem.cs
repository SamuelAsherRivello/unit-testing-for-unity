
using System.Collections.Generic;

namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// This performs common math operations on
    /// operands of a and b.
    /// </summary>
    public class MyPureSystem
    {
        private readonly Dictionary<int, string> _productsDictionary = 
            new Dictionary<int, string>
        {
            { 1, "Console" },
            { 2, "Computer" },
            { 3, "Phone" }
        };
            
        public string GetProduct (int productId)
        {
            return _productsDictionary[productId];
        }
    }
}