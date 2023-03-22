# Type based event bus for unity

## How to use

First create class inherited by IEvent interface

```C# 
public class MyEvent : IEvent
{
    public string Message;
    
    public MyEvent(string message)
    {
        Message = message;
    }
}
```
Inject EventService in DI way or simply use it like a singletone.

```C#
public class EventTester : MonoBehaviour
{
    private IEventService _eventService;
    private void Awake()
    {
        _eventService = new EventService();

        _eventService.Subscribe<MyEvent>(DoSomething);

        _eventService.FireEvent(new MyEvent("Event fired"));
    }

    private void DoSomething(MyEvent eventData)
    {
        Debug.Log(eventData.Message);
    }
}
```
![Alt text](/relative/path/to/img.jpg?raw=true "Optional Title")
