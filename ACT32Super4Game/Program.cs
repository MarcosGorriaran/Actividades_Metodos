namespace Super4Game
{
    public class Execute
    {
        public static void Main()
        {
            const int MinEvil = 1000, MaxEvil = 50000, MaxChar=4, VocalAmountLimit = 2, PartyAmount = 4, PercentToExtract=5;
            const string TargetWords = "aeiou";
            const string AskChar = "Elige uno de los siguientes personajes [1-{0}]: ";
            const string AskName = "Proporcioname el nombre del personaje: ";
            const string AskEvilAmount = "Proporcioname la maldad del personaje dentro del rango permitido [{0}, {1}]: ";
            const string EvilAmountExchanged = "Espurna extra {0} de maldad del malvado y lo pasa a todos los miembros de super 4 dejando al malvado con {1} de maldad.";

            bool error;
            int charAvatar, charEvilAmount, evilExtracted, amountVocals;
            string charName;
            do
            {
                Console.Write(AskChar, MaxChar);
                charAvatar = Convert.ToInt32(Console.ReadLine());
                error = !InRange(charAvatar, 1, MaxChar);
                if (error)
                {
                    //Write Error Msg
                }
            } while (error);
            
            Console.Write(AskName);
            charName = Console.ReadLine();
            
            do
            {
                Console.Write(AskEvilAmount, MinEvil, MaxEvil);
                charEvilAmount = Convert.ToInt32(Console.ReadLine());
                error = !InRange(charEvilAmount, MinEvil, MaxEvil);
                if (error)
                {
                    //Write Error Msg
                }
            } while (error);

            amountVocals = ContainsWordGroup(charName.ToLower(), TargetWords.ToCharArray());
            evilExtracted = amountVocals >= VocalAmountLimit ? SplitBetweenGroup(PartyAmount,charEvilAmount) : SplitBetweenGroup(PartyAmount, ExtractPercentAmount(charEvilAmount, PercentToExtract));
            Console.WriteLine(EvilAmountExchanged, evilExtracted*PartyAmount, charEvilAmount-evilExtracted*PartyAmount);
        }
        public static int ContainsWordGroup(string text, params char[] targetWords) 
        {
            int sum = 0;
            for(int i = 0; i<text.Length; i++)
            {
                if (ContainsWordGroup(text[i],targetWords)) sum++;
            }
            return sum;
        }
        public static bool ContainsWordGroup(char word, params char[] targetWords)
        {
            for(int i = 0;i<targetWords.Length; i++)
            {
                if (word.Equals(targetWords[i])) return true;
            }
            return false;
        }
        public static int SplitBetweenGroup(int amountTargets, int splitObject)
        {
            return Convert.ToInt32(Math.Truncate((decimal)splitObject/amountTargets));
        }
        public static int ExtractPercentAmount(int extractObject, int percentualValue)
        {
            const int TopPercent = 100;
            return Convert.ToInt32(Math.Truncate((decimal)(extractObject*percentualValue)/TopPercent));
        }
        public static bool InRange(int checkValue ,int minRange, int maxRange)
        {
            return checkValue>=minRange && checkValue<=maxRange;
        }
    }
}