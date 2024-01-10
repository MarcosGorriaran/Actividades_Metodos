using System.Runtime.CompilerServices;

namespace GameModules
{
    class Execute()
    {
        public static void Main()
        {
            const int CharacterLimit = 10;
            const int MinLimit = 1;
            const int MaxLimit = 500;
            const int PointALocation = 1;
            const int PointBLocation = 100;
            const string AskName = "Proporcioname el nombre de su personaje: ";
            const string TooManyCharacters = "Ha superado el limite de {0} caracteres en el nombre";
            const string AskValue = "Dame un valor dentro del siguiente rango [{0}, {1}]: ";
            const string InputOutsideRange = "El valor esta fuera del rango designado";
            const string ShowMapCordinates = "Su heroe se encuentra en la siguiente posicion: {0}";

            bool error;
            int userInput;
            string characterName;
            do
            {
                Console.Write(AskName);
                characterName = Console.ReadLine();

                error = OvercomesLengthLimit(characterName, CharacterLimit);
                if (error) Console.WriteLine(TooManyCharacters, CharacterLimit);
            } while (error);

            do
            {
                Console.Write(AskValue, MinLimit, MaxLimit);
                userInput = Convert.ToInt32(Console.ReadLine());

                error = !InRange(userInput, MinLimit, MaxLimit);
                if (error) Console.WriteLine(InputOutsideRange);
            } while (error);

            Console.WriteLine(ShowMapCordinates, RandomLocation(PointALocation, PointBLocation));
        }
        public static bool OvercomesLengthLimit(string word, int characterLimit)
        {
            return word.Length > characterLimit;
        }
        public static bool InRange(int compareValue, int firstValue, int secondValue)
        {
            ReorderAsc(ref firstValue, ref secondValue);

            return firstValue <= compareValue && secondValue >= compareValue;
        }
        public static void ReorderAsc(ref int firstValue, ref int secondValue)
        {
            if(firstValue > secondValue)
            {
                int aux = firstValue;
                firstValue = secondValue;
                secondValue = aux;
            }
        }
        public static int RandomLocation(int firstLocation, int secondLocation)
        {
            ReorderAsc(ref firstLocation, ref secondLocation);
            Random rng = new Random();
            return rng.Next(firstLocation, secondLocation);
        }
    }
}
    