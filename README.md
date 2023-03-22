<h1> Type based event bus for unity <h2>

<h2>How to use<h2>

First create class inherited by IEvent interface

```C# 
public class MyEvent : IEvent {
public Message;
MyEvent(string message) {
Message = message;
} 
}


```
