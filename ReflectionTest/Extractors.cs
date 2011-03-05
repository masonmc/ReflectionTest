using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectionTest
{
    public class MethodExtractor
    {
        public void GenerateActions(Assembly fromAssembly)
        {
            string code = "";

            foreach (Type t in fromAssembly.GetTypes())
            {
                if (!t.IsClass) continue;
                if (!t.FullName.Contains("Facade")) continue;

                MethodInfo[] methodinfos = t.GetMethods();
                
                object[] objattrs = t.GetCustomAttributes(false);
                foreach (object objattr in objattrs)
                {
                    ActionGenesisAttribute genesis = objattr as ActionGenesisAttribute;
                    if (genesis == null) continue;

                    code += "found genesis";
                }


            }

        }
    }
}
