using NUnit.Framework;

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
            return program.SwapItems(first, second);
        }

        [TestCase(new[] { 0, 1, 2 }, ExpectedResult = 0)]
        [TestCase(new[] { int.MinValue, int.MaxValue }, ExpectedResult = int.MinValue)]
        [TestCase(new[] { 10, 10, 10 }, ExpectedResult = 10)]
        public int Task_ShouldProperlyGetMinimumValue(int[] array)
        {
            return program.GetMinimumValue(array);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Task_ShouldThrowExceptionForInvalidInput(int[] array)
        {
            Assert.Catch(() => program.GetMinimumValue(array));
        }
    }
}
