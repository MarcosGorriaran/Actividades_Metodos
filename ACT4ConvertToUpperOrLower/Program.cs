using System;

namespace ACT2GetNumberPower
{
    public class ACT4
    {
        public static void Main()
        {
            const char UpperOption = 'M';
            const char LowerOption = 'N';
            const string AskValue = "Proporcioname con un texto para convertir a mayuscula o minuscula: ";
            const string PickConversion = "Mayusculas o minusculas (M/N): ";
            const string ShowResult = "El resultado es el siguiente: ";

            string text;
            bool option;

            Console.Write(AskValue);
            text = Console.ReadLine();

            Console.Write(PickConversion);
            option = Console.ReadLine().ToUpper()[0] switch
            {
                UpperOption => true,
                LowerOption => false
            };

            text = ConvertToUpperOrLower(text,option);
            Console.Write(ShowResult);
            Console.WriteLine(text);
        }

        public static string ConvertToUpperOrLower(string text, bool toUpper=true)
        {
            return toUpper ? text.ToUpper() : text.ToLower();
        }
    }
}