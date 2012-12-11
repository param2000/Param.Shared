using NUnit.Framework;
using Param.Shared.Core;
using Param.Shared.Test.Models;

namespace Param.Shared.Test
{
    [TestFixture]
    public class RequiredForTest
    {

        [Test]
        public void RequiredForCompletenessShouldValidateTheRequiredForCompletiondAttributeWhenPropertiesHAsNoValues()
        {
            var sut = new RequiredFor<RequiredForCompletenessAttribute>(new GeneralViewModel());

            var result = sut.ToString();
            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.IsFalse(sut.IsValid);
        }
        [Test]
        public void RequiredForCompletenessShouldValidateTheRequiredForCompletiondAttributeWhenAllPropertiesMarkedHasValues()
        {
            var sut = new RequiredFor<RequiredForCompletenessAttribute>(new GeneralViewModel
                                                      {
                                                          AppAcronym = "",
                                                          AppVersion = ""
                                                      });
            var result = sut.ToString();
            Assert.IsTrue(string.IsNullOrEmpty(result));
            Assert.IsTrue(sut.IsValid);
        }



    }
}