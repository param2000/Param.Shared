using System;

namespace Param.Shared.Core
{
    public class RequiredForCompletenessAttribute :Attribute
    {
        public override string ToString()
        {
            return "Is Required";
        }   
    }

   
}