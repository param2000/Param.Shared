using NUnit.Framework;
using Param.Shared.Core.MinValueValidations;

namespace Param.Shared.Test
{
    [TestFixture]
    public class FloatMinValueCheckTester
    {
        [Test]
        public void WhenMinvalueIsPresentTheCheckerShouldNotValidate()
        {
            var result = new FloatMinValueCheck("").IsValid(float.MinValue);
            Assert.IsTrue(result);
        }

        [Test]
        public void WhenMinvalueIsNotPresentTheCheckerShouldValidate()
        {
            var val = float.MinValue;
            val = val + 5;
            var result = new FloatMinValueCheck("").IsValid(val);
            Assert.IsTrue(result);
        }

        [Test]
        public void WhenMinvalueIsNullTheCheckerShouldNotValidate()
        {
            var result = new FloatMinValueCheck("").IsValid(null);
            Assert.IsFalse(result);
        }
    }
}