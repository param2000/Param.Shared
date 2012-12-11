using NUnit.Framework;
using Param.Shared.Core.MinValueValidations;

namespace Param.Shared.Test
{
    [TestFixture]
    public class IntMinValueCheckTester
    {
        [Test]
        public void WhenMinvalueIsPresentTheCheckerShouldNotValidate()
        {
            var result = new IntMinValueCheck("").IsValid(int.MinValue);
            Assert.IsTrue(result);
        }

        [Test]
        public void WhenMinvalueIsNotPresentTheCheckerShouldValidate()
        {
            var result = new IntMinValueCheck("").IsValid(int.MinValue + 1);
            Assert.IsFalse(result);
        }

        [Test]
        public void WhenMinvalueIsNullTheCheckerShouldNotValidate()
        {
            var result = new IntMinValueCheck("").IsValid(null);
            Assert.IsFalse(result);
        }
    }
}