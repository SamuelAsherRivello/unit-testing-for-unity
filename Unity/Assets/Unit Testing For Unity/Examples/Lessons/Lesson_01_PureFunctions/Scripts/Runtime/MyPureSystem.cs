
namespace RMC.UnitTesting.Examples.PureFunctions
{
    /// <summary>
    /// Converts value to a result
    /// </summary>
    public class MyPureSystem
    {
        public int ConvertValue (int value, int multiplier)
        {
            return value * multiplier;
        }
    }
}