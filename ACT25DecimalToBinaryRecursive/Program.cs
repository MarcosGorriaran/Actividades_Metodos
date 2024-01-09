using System.Security.Cryptography.X509Certificates;

namespace DecimalToBinary
{
    public class Execute
    {
        public static void Main()
        {
            Console.WriteLine(DecimalToBinary(Convert.ToInt32(Console.ReadLine())));
        }
        public static string DecimalToBinary(int decimalValue)
        {
            return decimalValue / 2 < 2 ? $"1{decimalValue % 2}" : $"{DecimalToBinary(Convert.ToInt32(decimalValue / 2))}{decimalValue % 2}";
        }
    }
}