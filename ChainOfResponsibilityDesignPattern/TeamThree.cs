using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public class TeamThree : Handlerbase
    {
        public TeamThree(Handlerbase nextHandler, ContextObject question) : base(nextHandler, question) { }

        public override void HandleRequest()
        {

            Console.WriteLine("Wating for team three to respond");
            Thread.Sleep(10000);
            Console.WriteLine("\t I'm the one :) .....");
        }
    }
}
