using System;

namespace ACT2GetNumberPower
{
    public class ACT2
    {
        public static void Main()
        {
            const string AskValue = "Proporcioname la base del calculo: ";
            const string AskExponent = "Proporcioname el exponente del calculo: ";
            const string ShowResult = "La potencia final es: ";

            int value;
            int exponent;

            Console.Write(AskValue);
            value = Convert.ToInt32(Console.ReadLine());
            Console.Write(AskExponent);
            exponent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ShowResult+Exponent(value, exponent));
        }

        public static float Exponent(int value, int exponent)
        {
            float result = 1;

            if (exponent >= 0)
            {
                for (int i = 1; i <= exponent; i++)
                {
                    result *= value;
                }
            }
            else
            {
                for (int i = 1; i <= exponent*-1; i++)
                {
                    result /= value;
                }
            }
            return result;
        }
    }
}