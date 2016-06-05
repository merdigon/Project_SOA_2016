using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class ResourceBase
    {
        [Browsable(false)]
        public int Id { get; set; }
        public static string GetPropertyDisplayName(string propertyName, Type type)
        {
            PropertyInfo pInfo = type.GetProperty(propertyName);

            if (pInfo == null)
                throw new Exception("No property with given name: " + propertyName);

            var displayAttribute = (DisplayNameAttribute)(pInfo.GetCustomAttributes(true)).Where(p => p is DisplayNameAttribute).FirstOrDefault();

            if (displayAttribute == null)
                return pInfo.Name;

            return displayAttribute.DisplayName;
        }
    }
}
