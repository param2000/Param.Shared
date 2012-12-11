using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Param.Shared.Core
{
    public sealed class RequireForCompletnessValidator
    {
        private readonly IList<PropertyInfo> _failed;
        private readonly IList<PropertyInfo> _all;
        private readonly Object _obj;

        public RequireForCompletnessValidator(object obj)
            {
                if (obj == null) throw new NullReferenceException("Object supplied can not be null");

                _obj = obj;
                _failed = new List<PropertyInfo>();
                _all = new List<PropertyInfo>();

                Evaluate();
            }

        private void Evaluate()
            {
                PropertyInfo[] properties = _obj.GetType().GetProperties();

                foreach (PropertyInfo property in GetProperties(properties))
                {
                    if (property.GetValue(_obj, null) == null) _failed.Add(property);
          
                    _all.Add(property);
                }
            }
        public IEnumerable<PropertyInfo> GetProperties(IEnumerable<PropertyInfo> properties)
            {
                return from property in properties
                       let attribute = Attribute.GetCustomAttribute(property, typeof(RequiredForCompletnessBase)) as RequiredForCompletnessBase
                       where attribute != null
                       select property;
            }

        public override string ToString()
            {
                var str = new StringBuilder();

                foreach (var item in _failed)
                    str.Append(String.Format("{0} is required for completion ", item.Name));

                return str.ToString();
            }

        public IList<PropertyInfo> Failed
            {
                get { return _failed; }
            }

        public IList<PropertyInfo> All
            {
                get { return _all; }
            }
    }
}