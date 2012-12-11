using NUnit.Framework;
using Param.Shared.Core.MinValueValidations;

namespace Param.Shared.Test
{
    [TestFixture]
    public class DoubleMinValueCheckTester
    {
        [Test]
        public void WhenMinvalueIsPresentTheCheckerShouldNotValidate()
        {
            var result = new DoubleMinValueCheck("").IsValid(double.MinValue);
            Assert.IsTrue(result);
        }

        [Test]
        public void WhenMinvalueIsNotPresentTheCheckerShouldValidate()
        {
            var val = double.MinValue;
            val = val + 5;
            var result = new DoubleMinValueCheck("").IsValid(val);
            Assert.IsTrue(result);
        }

        [Test]
        public void WhenMinvalueIsNullTheCheckerShouldNotValidate()
        {
            var result = new DoubleMinValueCheck("").IsValid(null);
            Assert.IsFalse(result);
        }
    }
}