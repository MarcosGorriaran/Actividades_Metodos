
using System;

namespace ACT1IsNaturalAndBig
{
    public class ACT1
    {
        public static void Main()
        {
            const string AskFirstValue = "Proporcioname el primer valor: ";
            const string AskSecondValue = "Proporcioname el segundo valor: ";
            const string AreEqual = "Los valores son similares";
            const string FirstBigger = "El primer valor es mas grande";
            const string SecondBigger = "El segundo valor es mas grande";

            float firstValue, secondValue;
            do
            {
                Console.Write(AskFirstValue);
                firstValue = Convert.ToSingle(Console.ReadLine());
            } while (!IsNatural(firstValue));
            do
            {
                Console.Write(AskSecondValue);
                secondValue = Convert.ToSingle(Console.ReadLine());
            } while (!IsNatural(secondValue));

            Console.WriteLine(NumbersAreEqual(firstValue, secondValue) ? AreEqual : firstValue>secondValue ? FirstBigger : SecondBigger);
        }
        public static bool IsNatural(float checkValue)
        {
            const int Div = 1;
            return checkValue > 0 && checkValue%Div==0;
        }
        public static bool NumbersAreEqual(float firstValue, float secondValue)
        {
            return firstValue == secondValue;
        }
        
    }
}
