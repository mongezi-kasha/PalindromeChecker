namespace PalindromeCheckerTests
{
    public class PalindromeCheckerTest
    {
        [Fact]
        public void IsPalindrome_InputIsPalindrome_ReturnsTrue()
        {
            string palindrome = "A man, a plan, a canal, Panama";
            bool result = PalindromeChecker.IsPalindrome(palindrome);
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_InputIsNotPalindrome_ReturnsFalse()
        {
            string nonPalindrome = "Hello World";
            bool result = PalindromeChecker.IsPalindrome(nonPalindrome);
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_InputEmptyString_ReturnsTrue()
        {
            string emptyString = "";
            bool result = PalindromeChecker.IsPalindrome(emptyString);
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_InputSingleCharacter_ReturnsTrue()
        {
            string singleCharacter = "a";
            bool result = PalindromeChecker.IsPalindrome(singleCharacter);
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_InputWithSpaces_ReturnsTrue()
        {
            string spacedPalindrome = "A man a plan a canal Panama";
            bool result = PalindromeChecker.IsPalindrome(spacedPalindrome);
            Assert.True(result);
        }
    }
}