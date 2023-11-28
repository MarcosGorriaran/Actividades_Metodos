using System;

namespace ACT9GetNumberPower
{
    public class ACT9
    {
        public static void Main()
        {
            const int MaxInput = 2;
            const char InputWordSpliter = ' ';
            const string AskRange = "Proporcioname los rangos de numeros separados por espacio o un simple numero: ";
            const string AskValueInRange = "Proporcioname el valor que creas que esta dentro del rango: ";
            const string InputInRange = "El valor proporcionado esta dentro del rango";
            const string InputNotInRange = "El valor proporcionado no esta dentro del rango";
            const string AskValueSmallerThan = "Proporcioname un numero que sea mas pequeño que el valor introducido: ";
            const string InputIsSmaller = "El valor proporcionado es mas pequeño que el valor a comparar proporcionado";
            const string InputIsNotSmaller = "El valor proporcionado no es mas pequeño que el valor a comparar proporcionado";

            string[] userInput;
            int[] range;
            int userAnswer;


            Console.Write(AskRange);
            userInput = Console.ReadLine().Trim().Split(InputWordSpliter,MaxInput);
            if(userInput.Length > 1 && userInput[userInput.Length-1].IndexOf(InputWordSpliter)!=-1)
            {
                userInput[userInput.Length - 1] = userInput[userInput.Length - 1].Remove(userInput[userInput.Length - 1].IndexOf(InputWordSpliter));
            }
            range = ConvertArrayToIntArray(userInput);

            Console.Write(range.Length==MaxInput ? AskValueInRange : AskValueSmallerThan);
            userAnswer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(range.Length==MaxInput ? (IsInRange(userAnswer, range[0], range[1]) ? InputInRange : InputNotInRange) : (IsInRange(userAnswer, range[0]) ? InputIsSmaller:InputIsNotSmaller ));
        }

        public static bool IsInRange (int compareValue, int value)
        {
          return compareValue < value;
        }
        public static bool IsInRange(int compareValue, int firstValue, int secondValue)
        {
            SortTwoValuesAsc(ref firstValue, ref secondValue);
            return compareValue > firstValue && compareValue < secondValue;
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

        public static void SortTwoValuesAsc (ref int firstValue, ref int secondValue)
        {
            if (firstValue > secondValue)
            {
                int aux = firstValue;
                firstValue = secondValue;
                secondValue = aux;
            }
        }

        /*public static int[] SortArrayAsc(int[] values)
        {
            for(int i = 0; i < values.Length -1; i++)
            {
                for(int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] > values[j])
                    {
                        int aux = values[i];
                        values[i] = values[j];
                        values[j] = aux;
                    }
                }
            }
            return values;
        }*/
    }
}