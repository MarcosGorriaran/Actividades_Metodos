using System;

namespace ACT14
{
    public class ACT14
    {
        public static void Main()
        {
            const string AskValue = "Proporcioname con el valor con el que separar y sumar sus valores: ";
            const string ShowCountResult = "El valor tiene esta cantidad de numeros: ";
            const string ShowSumEven = "Esta es la suma de todos los numeros pares: ";
            const string ShowSumOdd = "Esta es la suma de todos los numeros impares: ";

            int toBeSplited;

            Console.Write(AskValue);
            toBeSplited = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ShowCountResult+CountAmountValues(toBeSplited));
            Console.WriteLine(ShowSumEven+SumEven(toBeSplited));
            Console.WriteLine(ShowSumOdd+SumOdd(toBeSplited));
        }
        public static int CountAmountValues(int value)
        {
            int div = 10;
            int count = 0;
            while (value >= 1)
            {
                count++;
                value = Convert.ToInt32(Math.Truncate((double)value / div));
            }
            return count;
        }
        public static int SumEven(int value)
        {
            int div = 10;
            int isEven = 2;
            int sum = 0;
            while(value >= 1)
            {
                int splited= value % div;
                if (splited % isEven==0)
                {
                    sum += splited;
                }
                value = Convert.ToInt32(Math.Truncate((double)value / div));
            }
            return sum;
        }
        public static int SumOdd(int value)
        {
            int div = 10;
            int isEven = 2;
            int sum = 0;
            while (value >= 1)
            {
                int splited = value % div;
                if (splited % isEven != 0)
                {
                    sum += splited;
                }
                value = Convert.ToInt32(Math.Truncate((double)value / div));
            }
            return sum;
        }
    }
}