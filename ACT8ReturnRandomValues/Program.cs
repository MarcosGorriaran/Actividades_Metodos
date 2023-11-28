using System;

namespace ACT8GetNumberPower
{
    public class ACT8
    {
        public static void Main()
        {
            const int AmoutValues = 10;
            const int MinRange = 0;
            const int MaxRange = 256;
            const char WordSpliter = '|';

            Random random = new Random();

            foreach (int i in GetTenRandomValues(AmoutValues, MinRange, MaxRange))
            {
                Console.Write(i+""+WordSpliter);
            }
        }

        public static int[] GetTenRandomValues(int amountValues, int minRange, int maxRange)
        {
            Random random = new Random();
            int[] result = new int[amountValues];

            for(int i = 0; i<result.Length; i++)
            {
                result[i] = random.Next(minRange, maxRange);
            }
            return result;
        }
    }
}