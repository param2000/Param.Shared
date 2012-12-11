using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Param.Shared.Core.Play.RequiredFor
{
   
    public class RequiredForCompleteness 
    {
        private readonly IList<Tuple<PropertyInfo, bool>> _list ;
        private readonly Object _obj;

        public RequiredForCompleteness(object obj)
        {
            _obj = obj;
            _list = new List<Tuple<PropertyInfo, bool>>();
            IsValid = true;

            Evaluate();
        }

        private void Evaluate()
        {
            PropertyInfo[] properties = _obj.GetType().GetProperties();
            
            foreach (PropertyInfo property in properties)
            {
                var attribute = Attribute.GetCustomAttribute(property, typeof(RequiredForCompletenessAttribute)) as RequiredForCompletenessAttribute;

                if (attribute == null) continue;

                var value = property.GetValue(_obj, null);
                if(value == null )
                    {
                        IsValid = false;
                        _list.Add(new Tuple<PropertyInfo, bool>(property, false));
                    }
                else
                    _list.Add( new Tuple<PropertyInfo, bool>(property, true));
                
            }
        }

        public override string ToString()
        {
            var str = new StringBuilder();

            foreach (var tuple in _list.Where( t=>t.Item2==false))
                str.Append(String.Format("{0} is required for completion", tuple.Item1));
           
            return str.ToString();
        }

        public bool IsValid { get; private set; }
    }
}
