public class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        // Removing non-alphanumeric characters and converting to lowercase
        string cleanedInput = new string(input.ToLower().Where(char.IsLetterOrDigit).ToArray());

        // Comparing characters from both ends
        int left = 0;
        int right = cleanedInput.Length - 1;

        while (left < right)
        {
            if (cleanedInput[left] != cleanedInput[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public static void Main(string[] args)
    {
        // Example usage with hardcoded value
        string input = "A man, a plan, a canal, Panama";
        bool isPalindrome = IsPalindrome(input);

        Console.WriteLine($"IsPalindrome: {isPalindrome}");
    }
}
