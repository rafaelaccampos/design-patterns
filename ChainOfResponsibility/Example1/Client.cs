using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example1
{
    //O cliente geralmente só trabalha com um handle, não tem ideia da cadeia
    //fonteDados =>cliente
    public class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffe" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if(result != null)
                {
                    Console.Write($"{result}");
                }
                else
                {
                    Console.WriteLine($"{food} was left untouched.");
                }
            }

        }
    }
}
