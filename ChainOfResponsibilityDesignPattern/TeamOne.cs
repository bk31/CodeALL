using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    //
    public class TeamOne : Handlerbase
    {
        public TeamOne(Handlerbase nextHandler, ContextObject question) : base(nextHandler, question) { }
        public override void HandleRequest()
        {

            Console.WriteLine("Question : {0}", Question.Question.ToString());
            Console.WriteLine("*******************************************");

            Console.WriteLine("Wating for team one to respond");
            Thread.Sleep(10000);
            NextTeam.HandleRequest();
        }
    }
}
