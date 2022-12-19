namespace ArrayExtension.Tests
{
    [TestClass]
    public class ArrayExtensionTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4 }, 10)]
        [DataRow(new int[] { 1, 2, 3, 4, 10, 15 }, 35)]
        [DataRow(new int[] { 1, 2, 3, 4, 1, 11 }, 22)]
        public void Method_SumIntArray_Tests(int[] numbers, int target)
        {
            int sum = numbers.Sum();
            
            Assert.AreEqual(target, sum);
        }
    }
}