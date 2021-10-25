using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowserLib
{
    public class Container : MemberInfo
    {
        public List<MemberInfo> Members { get; set; }

        public Container(string @namespace, string @class) : base(@namespace, @class)
        {
            Members = new List<MemberInfo>();
        }

        public Container(string @namespace, string @class, string signature, List<MemberInfo> members) : base(@namespace, @class)
        {
            Signature = signature;
            Members = members;
        }    
    }
}
