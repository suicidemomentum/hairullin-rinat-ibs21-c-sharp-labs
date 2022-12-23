namespace Circle.Tests
{
    [TestClass]
    public class CircleTests
    {
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(5)]
        [DataRow(15)]
        public void Method_FillQueue_Tests(int n)
        {
            Queue<int> circle = LocalClass.FillQueue(n);

            Assert.AreEqual(n, circle.Count);
        }

        [DataTestMethod]
        [DataRow(new int[] { 2, 4, 1, 5 }, 5)]
        [DataRow(new int[] { 2, 4, 6, 8, 10, 3, 7, 1, 9 }, 10)]
        [DataRow(new int[] { 2, 4, 6, 8, 10, 12, 14, 1, 5, 9, 13, 3, 11, 7 }, 15)]
        public void Method_StrikingOutEverySecond_Tests(int[] target, int n)
        {
            Queue<int> circle = LocalClass.FillQueue(n);
            List<int> list = LocalClass.StrikingOutEverySecond(circle);

            CollectionAssert.AreEqual(target, list);
        }

        [DataTestMethod]
        [DataRow(3, 5)]
        [DataRow(5, 10)]
        [DataRow(15, 15)]
        public void LastPerson_InCircle_Test(int target, int n)
        {
            Queue<int> circle = LocalClass.FillQueue(n);
            List<int> list = LocalClass.StrikingOutEverySecond(circle);

            Assert.AreEqual(target, circle.Dequeue());
        }
    }
}