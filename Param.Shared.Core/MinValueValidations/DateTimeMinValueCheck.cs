using System;
using System.ComponentModel.DataAnnotations;

namespace Param.Shared.Core.MinValueValidations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class DateTimeMinValueCheck : ValidationAttribute 
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;
            return DateTime.Parse(value.ToString()) == DateTime.MinValue;
        }

        public DateTimeMinValueCheck(string errorMessage) : base(errorMessage)
        {}
    }
}