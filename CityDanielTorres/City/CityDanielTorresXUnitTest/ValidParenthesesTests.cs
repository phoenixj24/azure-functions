using CityDanielTorres;
using System;
using Xunit;

namespace CityDanielTorresXUnitTest
{
    public class ValidParenthesesTests
    {
        [Fact]
        public void Valid_Case1()
        {
            var validParentheses = new ValidParentheses();
            var input = "(){[]}";

            // ASSERT
            Assert.True(validParentheses.IsValid(input));
        }

        [Fact]
        public void Valid_Case2()
        {
            var validParentheses = new ValidParentheses();
            var input = "[]((){[]})";

            // ASSERT
            Assert.True(validParentheses.IsValid(input));
        }

        [Fact]
        public void InValid_Case1()
        {
            var validParentheses = new ValidParentheses();
            var input = "(){[]}{";

            // ASSERT
            Assert.False(validParentheses.IsValid(input));
        }

        [Fact]
        public void InValid_Case2()
        {
            var validParentheses = new ValidParentheses();
            var input = "(){[]})))))))))))";

            // ASSERT
            Assert.False(validParentheses.IsValid(input));
        }
    }
}
