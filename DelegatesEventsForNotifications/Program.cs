using System.Buffers.Text;
using System.Runtime.CompilerServices;

namespace DelegatesEventsForNotifications
{
    public class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            subscriber.Subscribe(publisher);

            // Simulate some action that triggers the event
            publisher.DoSamething();

            // Output: "Notification received!"
        }
    }
    public class Publisher
    {
        //step 1: Define a delegates
        public delegate void EventHandler(object sender, EventArgs e);

        // Step 2: Declare an event based on the delegate
        public event EventHandler myEvents;
        // Step 3: Raise the event
        protected virtual void OnMyEvent(EventArgs e)
        {
            myEvents?.Invoke(this, e);
        }
        // Method that does something and raises the event
        public void DoSamething()
        {
            // Do some work...

            // Raise the event when something significant happens
            OnMyEvent(EventArgs.Empty);
        }

    }
    public class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            // Step 4: Subscribe to the event
            publisher.myEvents += HandleEvent;
        }

        // Step 5: Define the event handler method
        void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Notification received!");
            // Handle the event (e.g., log, update UI, etc.)
        }
    }

}
