namespace RussianMath
{
    class Execute
    {
        public static void Main()
        {
            const string AskFirstValue = "Cual es el primer valor de la multiplicacion: ";
            const string AskSecondValue = "Cual es el segundo valor de la multiplicacion: ";

            int firstValue, secondValue;

            Console.Write(AskFirstValue);
            firstValue = Convert.ToInt32(Console.ReadLine());
        }
        
        public static int RussianMult(int firstValue, int secondValue)
        {
            int sum = secondValue;
            for(int i = firstValue; i >= 1; i = Convert.ToInt32(Math.Truncate((double)i / 2)))
            {
                sum+= sum;
            }
            return sum;
        }

        public static int RussianMultRec(int firstValue, int secondValue)
        {
            return firstValue == 1 ? secondValue + secondValue : RussianMult(Convert.ToInt32(Math.Truncate((double)firstValue / 2)), secondValue + secondValue);
        }
    }
}