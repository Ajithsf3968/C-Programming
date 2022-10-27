using System;
namespace SampleEvent;

class Program
{
    public static void Main(string[] args)
    {
        Events event1=new Events("Quiz");
        Events event2=new Events("Debugging");
        Events event3=new Events("Presentation");
        Events event4=new Events("Games");
        //subscribe to events  - Example event registration by management
        Events.eventlink+=new EventManager(event1.StartEvent);
        Events.eventlink+=new EventManager(event2.StartEvent);
        Events.eventlink+=new EventManager(event3.StartEvent);
        Events.eventlink+=new EventManager(event4.StartEvent);
        // Event delegates assigned with method

        // process trigerring to start  events
        Events.HandleEvent();
        //Event cancellation/deregistration-unsubscribe from event
        Events.eventlink-=new EventManager(event4.StartEvent);
        Events.HandleEvent();
    }
}