
namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// Converts value to a result
    /// </summary>
    public class MySystem02_NonPure
    {
        /// <summary>
        /// IMPURE: This is an example of a INDIRECT INPUT to the ConvertValue method.
        /// </summary>
        private readonly int _multiplier;
        
        /// <summary>
        /// IMPURE: This is an example of a INDIRECT OUTPUT to the ConvertValue method.
        /// </summary>
        public int LastResult { get; private set; }
        
        public MySystem02_NonPure (int multiplier)
        {
            _multiplier = multiplier;
        }
        
        public int ConvertValue (int value)
        {
            LastResult = value * _multiplier;
            return LastResult;
        }
    }
}