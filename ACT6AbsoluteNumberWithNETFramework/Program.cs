using System;

namespace ACT6GetNumberPower
{
    public class ACT6
    {
        public static void Main()
        {
            const string AskValue = "Porporcioname un valor y te devolvere su valor absoluto: ";
            const string ShowResult = "El valor absoluto es: ";
            int absoluteValue;

            Console.Write(AskValue);
            absoluteValue = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write(ShowResult + Math.Abs(absoluteValue));
        }
    }
}