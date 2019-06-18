using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace prog2
{
    static class OperationTypeExtention
    {
        public static string GetLabel(this OperationType e)
        {
            Type type = e.GetType();
            Array values = Enum.GetValues(type);

            foreach (int val in values)
            {
                if ((OperationType)val == e)
                {
                    System.Reflection.MemberInfo[] memberInfo = type.GetMember(type.GetEnumName(val));
                    DescriptionAttribute descriptionAttribute = memberInfo[0]
                        .GetCustomAttributes(typeof(DescriptionAttribute), false)
                        .FirstOrDefault() as DescriptionAttribute;

                    if (descriptionAttribute != null)
                    {
                        return descriptionAttribute.Description;
                    }
                }
            }

            return null;
        }
    }
}
