using Param.Shared.Core.Play.RequiredFor;
using NUnit.Framework;
using Param.Shared.Test.Models;

namespace Param.Shared.Test
{
    [TestFixture]
    public class RequiredForCompletenessTest2
    {

        [Test]
        public void RequiredForCompletenessShouldValidateTheRequiredForCompletiondAttributeWhenPropertiesHAsNoValues()
        {
            var sut = new RequiredForCompleteness2(new GeneralViewModel());

            var result = sut.ToString();
            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.IsFalse(sut.IsValid);
        }
        [Test]
        public void RequiredForCompletenessShouldValidateTheRequiredForCompletiondAttributeWhenAllPropertiesMarkedHasValues()
        {
            var sut = new RequiredForCompleteness2(new GeneralViewModel
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