using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example1
{
    //Declara o método para construir a sequencia de handlers.
    //Também declara o método para executar um request.
    public interface IHandler
    {
        IHandler AddNext(IHandler handler);
        object Handle(object request);
    }
}
