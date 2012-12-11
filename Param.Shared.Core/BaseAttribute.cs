using System;

namespace Param.Shared.Core
{
    public class BaseAttribute : Attribute
    {
        public string ErrorMessage { get; set; }

        public BaseAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}