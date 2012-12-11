using System;
using System.ComponentModel.DataAnnotations;

namespace Param.Shared.Core.MinValueValidations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class FloatMinValueCheck : ValidationAttribute 
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;
            return ((float)value ) >= float.MinValue;                
        }

        public FloatMinValueCheck(string errorMessage) : base(errorMessage)
        {}
    }
}