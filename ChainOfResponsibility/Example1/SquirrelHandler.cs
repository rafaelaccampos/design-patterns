using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example1
{
    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if(request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.\\n";
            }
            return base.Handle(request);
        }
    }
}
