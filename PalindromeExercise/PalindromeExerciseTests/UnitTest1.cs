using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("hannah", true)]
        [InlineData("smash", false)]
        [InlineData("pop", true)]
        [InlineData("tree", false)]
        [InlineData("rock", false)]
        [InlineData("fish", false)]
        [InlineData("kayak", true)]
        [InlineData("level", true)]
        public void MyTest(string word, bool expected)
        {
            var tester = new WordSmith();
            var actual = tester.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
