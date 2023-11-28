using System;

namespace ACT2GetNumberPower
{
    public class ACT3
    {
        public static void Main()
        {
            const string AskValue = "Porporcioname un valor y te devolvere su valor absoluto: ";
            const string ShowResult = "El valor absoluto es: ";
            int absoluteValue;

            Console.Write(AskValue);
            absoluteValue = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write(ShowResult+Exponent(absoluteValue));
        }

        public static int Exponent(int value)
        {
            return value < 0 ? value * -1 : value;
        }
    }
}
