using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionTest
{
    public class TestFacade
    {
        [ActionGenesis(Desc="Does something cool.", FriendlyName="My Cool Action")]
        [ActionGenesisArg(Name = "arg1", Desc="desc of argument 1", IDType=eIDType.idType1, FriendlyName="Argument 1")]
        [ActionGenesisArg(Name = "arg2", Desc = "desc of argument 2", IDType = eIDType.idType2, FriendlyName = "Argument 2")]
        public void DoSomethingCool(int arg1, int arg2)
        {
            int @default = 5;
            @default = @default + 1;
        }
    }
}
