using Module1;
using NUnit.Framework;
using System;

namespace M1
{
    [TestFixture]
    public class Module1Tests
    {
        Module1 program = new Module1();

        [TestCase(0, 0, ExpectedResult = new[] { 0, 0 })]
        [TestCase(0, 10, ExpectedResult = new[] { 10, 0 })]
        [TestCase(int.MinValue, int.MaxValue, ExpectedResult = new[] { int.MaxValue, int.MinValue })]
        public int[] Task_ShouldProperlySwapItems(int first, int second)
        {
            return program.Task(first, second);
        }
    }
}
