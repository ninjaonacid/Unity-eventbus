using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
