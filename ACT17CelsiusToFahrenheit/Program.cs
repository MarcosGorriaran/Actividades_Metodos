using System;
using Utilities;

namespace ACT17
{
    public class ACT17
    {
        public static void Main()
        {
            const string AskCelsiusTemp = "Proporcioname la temperatura en Celsius: ";

            int celsius;

            celsius = FunctionUtilities.AskUserValue(AskCelsiusTemp);
        }

        public static decimal CelsiusToFahrenheit(decimal celsius)
        {
            int amountDecimals = 2;
            decimal conversionValue = 1.8M;
            decimal farenheitStartingPoint = 32M;
            decimal amountIncreases = celsius<0 ? celsius*-1 : celsius;
            decimal result = farenheitStartingPoint;

            while(Math.Truncate(amountIncreases) > 0)
            {
                result += celsius < 0 ? conversionValue * -1 : conversionValue;
                amountIncreases--;
            }
            if(result != 0)
            {
                result += celsius < 0 ? (amountIncreases * conversionValue) * -1 : amountIncreases * conversionValue;
            }
            
            return Math.Round(result,amountDecimals,MidpointRounding.ToZero);
        }
    }
}