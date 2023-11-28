using System;

namespace ACT11GetNumberPower
{
    public class ACT11
    {
        public static void Main()
        {
            const string AskValue = "Proporcioname un valor a factorizar: ";
            const string ShowFactorial = "El factorial de {0} es: ";

            uint userInput;

            Console.Write(AskValue);
            userInput = Convert.ToUInt32(Console.ReadLine());

            Console.Write(ShowFactorial+Factorial(userInput),userInput);
        }

        public static uint Factorial(uint value)
        {
            uint result=1;
            for(uint i = 1; i <= value; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}