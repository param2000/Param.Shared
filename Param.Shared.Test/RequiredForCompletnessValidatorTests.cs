using System;
using NUnit.Framework;
using Param.Shared.Core;
using Param.Shared.Test.Models;

namespace Param.Shared.Test
{
    [TestFixture]
    public class RequiredForCompletnessValidatorTests
    {
        [Test]
        [ExpectedException(typeof(NullReferenceException))]
        public void RequiredForCompletenessThrowNullRefrenceExceptionWhenSuppliedObjectIsNull()
        {
            var sut = new RequireForCompletnessValidator(null);
            Assert.IsNull(sut);
        }

        [Test]
        public void RequiredForCompletenessShouldValidateTheRequiredForCompletiondAttributeWhenPropertiesHAsNoValues()
        {
            var sut = new RequireForCompletnessValidator(new GeneralModelThatHaveRequiredForCompletnessBaseAttributes());

            var all = sut.All;
            var failed = sut.Failed;
            Assert.IsNotNull(all);
            Assert.IsNotNull(failed);
        }

        [Test]
        public void RequiredForCompletenessShouldValidateTheRequiredForCompletiondBaseWhenPropertiesHAsNoValues()
        {
            var sut = new RequireForCompletnessValidator(new GeneralModelThatHaveRequiredForCompletnessBaseAttributes());

            Assert.AreEqual(2, sut.All.Count);
            Assert.AreEqual(2, sut.Failed.Count);
        }
       
        [Test]
        public void RequiredForCompletenessShouldValidateTheRequiredForCompletiondAttributeWhenAllPropertiesMarkedHasValues()
        {
            var sut = new RequireForCompletnessValidator(new GeneralModelThatHaveRequiredForCompletnessBaseAttributes
                                                      {
                                                          AppAcronym = 2,
                                                          AppVersion = ""
                                                      });
            Assert.AreEqual(2, sut.All.Count);
            Assert.AreEqual(0, sut.Failed.Count);
        }

        [Test]
        public void RequiredForCompletenessShouldValidateTheRequiredForCompletiondAttributeWhenSomePropertiesMarkedHasValuesSomeDont()
        {
            var sut = new RequireForCompletnessValidator(new GeneralModelThatHaveRequiredForCompletnessBaseAttributes
            {
                AppAcronym = 13
            });
            Assert.AreEqual(2, sut.All.Count);
            Assert.AreEqual(1, sut.Failed.Count);
        }


        [Test]
        public void RequiredForCompletenessShouldValidateTheRequiredForCompletiondAttributeWhenHasMarkedAttribute()
        {
            var sut = new RequireForCompletnessValidator(new GeneralViewModelThatDoesNotHaveAnyAttributes());

            Assert.AreEqual(0, sut.All.Count);
            Assert.AreEqual(0, sut.Failed.Count);
        }


    }
}