namespace StringExtension.Tests
{
    [TestClass]
    public class StringExtensionTests
    {
        [DataTestMethod]
        [DataRow("123")]
        [DataRow("891235")]
        [DataRow("123474")]
        [DataRow("0234963")]
        public void Method_IsPositiveIntegerString_ValidValues_Tests(string target)
        {
            bool isPositiveInteger = target.IsPositiveInteger();
           
            Assert.IsTrue(isPositiveInteger);
        }

        [DataTestMethod]
        [DataRow("-123")]
        [DataRow("asf643sd")]
        [DataRow("23590+o325")]
        [DataRow("Stringer")]
        public void Method_IsPositiveIntegerString_InvalidValues_Tests(string target)
        {
            bool isPositiveInteger = target.IsPositiveInteger();

            Assert.IsFalse(isPositiveInteger);
        }
    }
}