using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example1
{
    //regra => quando não atende uma regra ele vai retorna uma resposta e finished.
    //condição => não atendeu uma regra => segue o baile pra próxima regra => até dar finished
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request.ToString()}.\n";
            }
            return base.Handle(request);
        }
    }
}
