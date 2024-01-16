using System.Security.Cryptography.X509Certificates;

namespace FindWordInText
{
    class Execute
    {
        public static void Main()
        {
            const string AskText = "Proporcioname la palabra con la que buscar y contar el caracter que desea: ";
            const string AskWord = "Proporcioname la letra que desea buscar: ";
            const string ShowResult = "Hay {0} '{1}' en la palabra";
            string text;
            char word;
            int amountWordInText;

            Console.Write(AskText);
            text = Console.ReadLine();
            Console.Write(AskWord);
            word = Convert.ToChar(Console.ReadLine());
            amountWordInText = CountWordInText(text, word);
            Console.WriteLine(ShowResult, amountWordInText, word);
        }
        public static int CountWordInText(string word, char targetWord)
        {
            if (word.Length <= 1)
            {
                return word[0]==targetWord ? 1 : 0;
            }
            return word[0] == targetWord ? CountWordInText(word.Substring(1), targetWord) + 1 : CountWordInText(word.Substring(1), targetWord);
        }
    }
}