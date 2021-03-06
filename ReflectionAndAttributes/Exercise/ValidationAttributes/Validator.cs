using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            //reflection
            //get object properties
            //foreach property check if there are custom attributes
            //isValid(value)
            //model is valid or not valid

            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                //IEnumerable<MyValidationAttribute> propertyCustomAttributes = property.GetCustomAttributes().Where(x => x is MyValidationAttribute).Cast<MyValidationAttribute>();

                IEnumerable<MyValidationAttribute> propertyCustomAttributes = property.GetCustomAttributes<MyValidationAttribute>();

                foreach (MyValidationAttribute attribute in propertyCustomAttributes)
                {
                    bool result = attribute.IsValid(property.GetValue(obj));

                    if (!result)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
