
namespace RMC.UnitTesting.Examples.PureFunctions
{
    public interface IConverter
    {
        int ConvertValue (int value);
    }

    public class Converter : IConverter
    {
        /// <summary>
        /// IMPURE: This is an example of a INDIRECT INPUT to the ConvertValue method.
        /// </summary>
        private readonly int _multiplier;
        
        public Converter (int multiplier)
        {
            _multiplier = multiplier;
        }
        
        public int ConvertValue (int value)
        {
            return value * _multiplier;;
        }
    }
    
    /// <summary>
    /// Converts value to a result
    /// </summary>
    public class MySystem03_NonPureAdvanced
    {
        private readonly IConverter _converter;
        
        /// <summary>
        /// IMPURE: This is an example of a INDIRECT OUTPUT to the ConvertValue method.
        /// </summary>
        public int LastResult { get; private set; }
        
        public MySystem03_NonPureAdvanced (IConverter converter)
        {
            LastResult = -1;
            _converter = converter;
        }
        
        public int ConvertValue (int value)
        {
            LastResult = _converter.ConvertValue(value);
            return LastResult;
        }
    }
}