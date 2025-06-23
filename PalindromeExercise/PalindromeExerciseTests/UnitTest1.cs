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
        public void MyTest(string word, bool expected)
        {
            var tester = new WordSmith();
            var actual = tester.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
        public void Test1()
        {

        }
    }
}
