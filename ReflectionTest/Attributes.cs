using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionTest
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ActionGenesisAttribute : Attribute
    {
        public string FriendlyName { get; set; }
        public string Desc { get; set; }
    }

    public enum eIDType
    {
        idType1,
        idType2,
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple=true)]
    public class ActionGenesisArgAttribute : Attribute
    {
        public string Name { get; set; }
        public string FriendlyName { get; set; }
        public string Desc { get; set; }
        public eIDType IDType { get; set; }
    }

}
