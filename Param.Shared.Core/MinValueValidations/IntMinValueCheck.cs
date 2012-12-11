using System;
using System.ComponentModel.DataAnnotations;

namespace Param.Shared.Core.MinValueValidations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class IntMinValueCheck : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)  return false;
            return int.Parse(value.ToString()) == int.MinValue;
        }

        public IntMinValueCheck(string errorMessage) : base(errorMessage)
        {}
    }
}