using System;

namespace ACT15
{
    public class ACT15
    {
        public static void Main()
        {
            const string AskValue = "Proporcioname un año: ";
            const string IsTransitional = "El año especificado es un año de traspaso";
            const string IsNotTransitional = "El año especificado no es un año de traspaso";

            int year;

            Console.Write(AskValue);
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsTransitionalYear(year) ? IsTransitional : IsNotTransitional);
        }
        public static bool IsTransitionalYear(int year)
        {
            int transitionYear=4;
            return year % transitionYear==0;
        }
    }
}