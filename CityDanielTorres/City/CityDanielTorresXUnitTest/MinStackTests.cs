using CityDanielTorres;
using System;
using Xunit;

namespace CityDanielTorresXUnitTest
{
    public class MinStackTests
    {
        [Fact]
        public void Valid_Case1()
        {
            var minStack = new MinStack();

            // STEPS
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            // ASSERT
            Assert.Equal(-3, minStack.GetMin());

            // STEPS
            minStack.Pop();

            // ASSERT
            Assert.Equal(0, minStack.Top());

            // ASSERT
            Assert.Equal(-2, minStack.GetMin());
        }

        [Fact]
        public void Valid_Case2()
        {
            var minStack = new MinStack();

            // STEPS
            minStack.Push(200);
            minStack.Push(50000);
            minStack.Push(650);
            minStack.Push(0);
            minStack.Push(-10);

            // ASSERT
            Assert.Equal(-10, minStack.GetMin());

            // STEPS
            minStack.Pop();
            minStack.Pop();
            minStack.Pop();

            // ASSERT
            Assert.Equal(50000, minStack.Top());

            // ASSERT
            Assert.Equal(200, minStack.GetMin());
        }
    }
}
