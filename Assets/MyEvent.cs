using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEvent : IEvent
{
    public string Message;
    public MyEvent(string message)
    {
        Message = message;
    }
}
