namespace SumDigital
{
    class Execute()
    {
        public static void Main()
        {
            Console.WriteLine(GetDigitSum(24455));
        }
        public static int GetDigitSum(int value)
        {
            return value / 10 < 1 ? value : GetDigitSum(Convert.ToInt32(Math.Truncate((double)value/10)))+value%10;
        }
    }
}