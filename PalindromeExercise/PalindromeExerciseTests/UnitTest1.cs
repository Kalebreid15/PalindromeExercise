using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Mom", true)]
        [InlineData("Kayak", true)]
        [InlineData("Racecar", true)]
        public void IsAPalindrome_Test(string word, bool expected) =>
            Assert.Equal(expected, new WordSmith().IsAPalindrome(word));
    }
}
