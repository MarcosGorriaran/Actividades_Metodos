using System;

namespace ACT2GetNumberPower
{
    public class ACT5
    {
        public static void Main()
        {
            const int RangeLimit = 100;
            const string AskValue = "Proporcioname con un valor y evaluare si es mas pequeño que {0} y es positivo: ";
            const string TrueResult = "El valor es positivo y mas pequeño que {0}";
            const string FalseResult = "El valor no es positivo y/o mas pequeño que {0}";

            int value;

            Console.Write(AskValue, RangeLimit);
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsSmallerThanAndPositive(value, RangeLimit) ? TrueResult : FalseResult,RangeLimit) ;
        }

        public static bool IsSmallerThanAndPositive(int value, int rangeLimit)
        {
            return value >= 0 && value < rangeLimit;
        }
    }
}