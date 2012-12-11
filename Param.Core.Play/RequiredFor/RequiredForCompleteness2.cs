using System;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections.Generic;

namespace Param.Shared.Core.Play.RequiredFor
{
    public class RequiredForCompleteness2
    {
        private readonly IList<PropertyInfo> _list;
        private readonly Object _obj;

        public RequiredForCompleteness2(object obj)
        {
            _obj = obj;
            _list = new List<PropertyInfo>();
            IsValid = true;

            Evaluate();
        }

        private void Evaluate()
        {
            PropertyInfo[] properties = _obj.GetType().GetProperties();

            foreach (PropertyInfo property in GetProperties(properties))
            {
                IsValid = false;
                _list.Add(property);
            }
        }

        private IEnumerable<PropertyInfo> GetProperties(IEnumerable<PropertyInfo> properties)
        {
            return from property in properties 
                   let attribute = Attribute.GetCustomAttribute(property, typeof(RequiredForCompletenessAttribute)) as RequiredForCompletenessAttribute 
                   where attribute != null && property.GetValue(_obj, null) == null 
                   select property;
        }

        public override string ToString()
        {
            var str = new StringBuilder();

            foreach (var item in _list)
                str.Append(String.Format("{0} is required for completion ", item.Name));

            return str.ToString();
        }

        public bool IsValid { get; private set; }
    }
}