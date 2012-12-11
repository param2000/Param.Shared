using System;

namespace Param.Shared.Core
{
    public abstract class RequiredForCompletnessBase : Attribute
    {  
        public virtual bool IsValid(object obj)
        {
            return true;
        }
        
        public string DisplayName { get; set; }
        public string SecionName { get; set; }
    }
}