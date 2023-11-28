using System;

namespace ACT10GetNumberPower
{
    public class ACT10
    {
        public static void Main()
        {
            const int MinRange = 0, MaxRange = 200;
            const string AskValue = "Puedes adivinar el numero aleatorio entre {0}-{1}: ";
            const string InList = "El valor esta en la lista";
            const string NotInList = "El valor no esta en la lista";

            int[] guessList = GenerateRandomNumbers(MinRange, MaxRange);
            int userGuess;

            Console.Write(AskValue,MinRange,MaxRange);
            userGuess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ValueExists(guessList,userGuess) ? InList : NotInList);
        }

        public static int[] GenerateRandomNumbers(int smallRange, int bigRange, uint amount = 10)
        {
            Random random = new Random();
            int[] numbers = new int[amount];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(smallRange, bigRange);
            }

            return numbers;
        }
        public static int[] GenerateRandomNumbers(uint amount = 10)
        {
            Random random = new Random();
            int[] numbers = new int[amount];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }

            return numbers;
        }

        public static bool ValueExists(int[] list, int searchTarget)
        {
            int i = 0;
            while(i < list.Length)
            {
                if (list[i] == searchTarget)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
    }
}