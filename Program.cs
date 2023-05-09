class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain)
        {
            Console.WriteLine("Welcome to the Palindrome program!");
            Console.WriteLine("Enter a word or phrase:");
            string text = Console.ReadLine();

            if (IsPalindrome(text))
            {
                Console.WriteLine("The text is a palindrome.");
            }
            else
            {
                Console.WriteLine("The text is not a palindrome.");
            }

            Console.WriteLine("Would you like to play again? (Y/N)");
            string playAgainResponse = Console.ReadLine();
            if (playAgainResponse.ToUpper() == "N")
            {
                playAgain = false;
            }
        }
    }

    public static bool IsPalindrome(string text)
    {
        // Clean the text by removing punctuation, whitespace, and converting to lower case
        string cleanedText = "";
        foreach (char c in text)
        {
            if (Char.IsLetterOrDigit(c))
            {
                cleanedText += Char.ToLower(c);
            }
        }
        // Create a stack and a queue to hold the characters
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();

        // Add each character in cleaned text to the stack and the queue
        for (int i = 0; i < cleanedText.Length; i++)
        {
            char c = cleanedText[i];
            stack.Push(c);
            queue.Enqueue(c);
        }

        // Compare characters from the stack and the queue
        while (stack.Count > 0 && queue.Count > 0)
        {
            char s = stack.Pop();
            char q = queue.Dequeue();
            if (s != q)
            {
                return false;
            }
        }

        // User input is a palindromee
        return true;
    }
}
