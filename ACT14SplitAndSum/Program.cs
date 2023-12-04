using System;

namespace ACT14
{
    public class ACT14
    {
        public static void Main()
        {
            const string AskValue = "Proporcioname con el valor con el que separar y sumar sus valores: ";

            int toBeSplited;

            Console.WriteLine(AskValue);
            toBeSplited = Convert.ToInt32(Console.ReadLine());


        }
        public static int CountAmountValues(int value)
        {
            int div = 10;
            int count = 0;
            while (value/div >= 1)
            {
                count++;
                value = value / div;
            }
            return value;
        }
        public static int SumEven(int value)
        {
            int div = 10;
            int isEven = 2;
            int sum = 0;
            while(value/div >= 1)
            {
                int splited= value % div;
                if (splited % isEven==0)
                {
                    sum += splited;
                }
                value /= div;
            }
            return sum;
        }
        public static int[] SplitValues(int value)
        {
            int div = 10;
            int[] result = new int[0];
            while (value/div>=1)
            {
                int splited = value % div;
                value = Convert.ToInt32(Math.Truncate((decimal)value / div));
                result = AddNewArrayValue(result, splited);
            }
            return result;
        }
        
        public static int[] AddNewArrayValue(int[] values, int newValue)
        {
            int[] aux = values;
            values = new int[aux.Length+1];

            for(int i = 0; i < aux.Length; i++)
            {
                values[i] = aux[i];
            }
            values[values.Length - 1] = newValue;
            return values;
        }
    }
}