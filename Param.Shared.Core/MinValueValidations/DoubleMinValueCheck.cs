using System;
using System.ComponentModel.DataAnnotations;

namespace Param.Shared.Core.MinValueValidations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class DoubleMinValueCheck : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;
            return ((double)value) >= double.MinValue;
        }

        public DoubleMinValueCheck(string errorMessage) : base(errorMessage)
        {}
    }
}