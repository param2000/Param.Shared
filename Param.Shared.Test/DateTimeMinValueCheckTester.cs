using System;
using NUnit.Framework;
using Param.Shared.Core.MinValueValidations;

namespace Param.Shared.Test
{
    [TestFixture]
    public class DateTimeMinValueCheckTester
    {
        [Test]
        public void WhenMinvalueIsPresentTheCheckerShouldNotValidate()
        {
            var result = new DateTimeMinValueCheck("").IsValid(DateTime.MinValue);
            Assert.IsTrue(result);
        }

        [Test]
        public void WhenMinvalueIsNotPresentTheCheckerShouldValidate()
        {
            var datetime = DateTime.Now;
            var result = new DateTimeMinValueCheck("").IsValid(datetime);
            Assert.IsFalse(result);
        }

        [Test]
        public void WhenMinvalueIsNullTheCheckerShouldNotValidate()
        {
            var result = new DateTimeMinValueCheck("").IsValid(null);
            Assert.IsFalse(result);
        }
    }
}