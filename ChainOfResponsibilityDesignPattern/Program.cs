namespace ChainOfResponsibilityDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContextObject question = new ContextObject() { Question = "Who is an ediat in your team?" };

           
            TeamThree teamThree= new TeamThree(null, question);
            TeamTwo teamTwo= new TeamTwo(teamThree, question);
            TeamOne teamOne = new TeamOne(teamTwo, question);
            teamOne.HandleRequest();
            Console.ReadLine();
        }
    }
}
