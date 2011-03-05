using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodExtractor me = new MethodExtractor();

            me.GenerateActions(Assembly.GetExecutingAssembly());

        }
    }
}
