using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example1
{
    //Responsável pela sequência de comportamentos que podem ser implementados
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _proximoHandle;

        public IHandler AddNext(IHandler handler)
        {
            this._proximoHandle = handler;

            //Retornar um handler daqui permite que a instância pode ser chamada assim: monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request)
        {
            if(this._proximoHandle != null)
            {
                return this._proximoHandle.Handle(request);
            }

            return null;
        }
    }
}
