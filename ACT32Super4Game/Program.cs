namespace Super4Game
{
    public class Execute
    {
        public static void Main()
        {

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
        public static float SplitBetweenGroup(int amountTargets, int splitObject)
        {
            
            return 0;
        }
        public static int ExtractPercentAmount(int extractObject, int percentualValue)
        {
            return 0;
        }
        public static bool InRange(int checkValue ,int minRange, int maxRange)
        {
            return false;
        }
    }
}