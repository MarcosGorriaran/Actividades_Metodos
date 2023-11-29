using System;

namespace ACT13
{
    public class ACT13
    {
        public static void Main()
        {
            const ConsoleColor ErrorColor = ConsoleColor.Red;
            const int AmountValues = 20;
            const char NumberSpliter = ' ';
            const string AskValues = "Escribe {0} valores separados por espacios: ";
            const string ErrorTooShort = "Hay menos valores de los solicitados";
            const string ErrorTooMany = "Hay mas valores de los solicitados";

            bool repeat = false;
            int[] userInput = new int[0];

            do
            {
                if (repeat)
                {
                    Console.ForegroundColor = ErrorColor;
                    if (userInput.Length < AmountValues)
                    {
                        Console.WriteLine(ErrorTooShort);
                    }
                    if(userInput.Length > AmountValues)
                    {
                        Console.WriteLine(ErrorTooMany);
                    }
                    Console.ResetColor();
                }
                repeat = true;

                Console.Write(AskValues, AmountValues);
                userInput = ConvertArrayToIntArray(Console.ReadLine().Trim().Split(NumberSpliter));
            } while (userInput.Length!=AmountValues);

            for(int i = 0; i < userInput.Length; i++)
            {
                if (isEven(userInput[i]))
                {
                    Console.Write(userInput[i]+""+NumberSpliter);
                }
            }
        }

        public static int[] ConvertArrayToIntArray(string[] values)
        {
            int[] result = new int[values.Length];

            for(int i = 0; i < values.Length; i++)
            {
                result[i] = Convert.ToInt32(values[i]);
            }

            return result;
        }

        public static bool isEven(int value)
        {
            return value % 2 == 0;
        }
        /*public static bool areEven(int[] values)
        {
            for(int i = 0; i < values.Length; i++)
            {
                if (!isEven(values[i]))
                {
                    return false;
                }
            }
            return true;
        }*/
    }
}