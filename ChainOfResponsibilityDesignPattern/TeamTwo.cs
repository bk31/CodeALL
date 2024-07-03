using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    //chain object tree
    public class TeamTwo:Handlerbase
    {
        public TeamTwo(Handlerbase nextHandler, ContextObject question) : base(nextHandler, question) { }

        public override void HandleRequest()
        {
            Console.WriteLine("Wating for team two to respond");

            Thread.Sleep(10000);

            Console.WriteLine("\t no response from team two.....");
            NextTeam.HandleRequest();
        }
    }
}
