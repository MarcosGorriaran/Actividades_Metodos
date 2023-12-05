using System;

namespace ACT7GetNumberPower
{
    public class ACT7
    {
        public static void Main()
        {
            const string AskValue = "Proporcioname la base del calculo: ";
            const string AskExponent = "Proporcioname el exponente del calculo: ";
            const string ShowResult = "La potencia final es: ";

            int value, exponent;

            Console.Write(AskValue);
            value = Convert.ToInt32(Console.ReadLine());
            Console.Write(AskExponent);
            exponent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ShowResult + Math.Pow(value, exponent));
        }
    }
}