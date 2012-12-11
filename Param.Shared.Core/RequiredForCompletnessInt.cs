using System;

namespace Param.Shared.Core
{
    public class RequiredForCompletnessInt : RequiredForCompletnessBase
    {
        private readonly int _minValue;

        
        public RequiredForCompletnessInt(int minValue)
        {
            _minValue = minValue;
        }

        public override string ToString()
        {
            return "Int Is Required";
        }

        public override bool IsValid(object obj)
        {
            if(Valid(obj))
                return ((int) obj) > _minValue;

            throw new InvalidOperationException("Object is not of type Int");
        }

        private static bool Valid(object obj)
        {
            return obj != null && obj is int;
        }
    }
}