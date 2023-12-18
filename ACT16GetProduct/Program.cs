using System;

namespace ACT16
{
    public class ACT16
    {
        public static void Main()
        {
            const string AskAmountValues = "Cuantos valores tendra el producto: ";
            const string AskValue = "Proporcioname el valor ";
            const string ShowAmountAttempts = "Tiene {0} intentos";
            const string ShowResult = "El producto de los valores proporcionados es: ";
            const string TooManyErrors = "Ha superado el limite de errores";
            const char SideNotInRangeSymbolLeft = '(', SideNotInRangeSymbolRight = ')';
            const int ProductStartingPoint = 1;
            const int MinRange = 15, MaxRange = 100, AllowedErrors = 5;
            const bool IsMinValueInRange = false;
            const bool IsMaxValueInRange = false;

            int result = ProductStartingPoint, amountValues, providedValue, errors = 0;
            bool outOfRange;

            amountValues = AskUserValue(AskAmountValues);

            for(int i = 0; i<amountValues && errors<AllowedErrors; i++)
            {
                errors = 0;
                do
                {
                    Console.WriteLine(ShowAmountAttempts, AllowedErrors-errors);
                    providedValue = AskUserValue(AskValue+$"{i}{SideNotInRangeSymbolLeft}{MinRange}-{MaxRange}{SideNotInRangeSymbolRight}: ");
                    outOfRange = !InRange(providedValue, MinRange, MaxRange, IsMinValueInRange, IsMaxValueInRange);
                    if (outOfRange)
                    {
                        errors++;
                    }
                } while (outOfRange && errors<AllowedErrors);
                if (errors < AllowedErrors)
                {
                    result *= providedValue;
                }
            }

            Console.Write(errors<AllowedErrors ? ShowResult+result : TooManyErrors);
            
        }
        public static bool InRange(int compareValue, int firstValue, int secondValue, bool minInRange = true, bool maxInRange = true)
        {
            ReorderVarAsc(ref firstValue, ref secondValue);
            if (minInRange)
            {
                firstValue--;
            }
            if (maxInRange)
            {
                secondValue++;
            }

            return compareValue>firstValue && compareValue<secondValue;
        }
        public static void ReorderVarAsc(ref int firstValue, ref int secondValue)
        {
            if(firstValue > secondValue)
            {
                int aux = firstValue;
                firstValue = secondValue;
                secondValue = aux;
            }
        }
        public static int AskUserValue(string askMsg = "Proporcioname un valor: ")
        {
            int result;
            Console.Write(askMsg);
            result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
    }
}